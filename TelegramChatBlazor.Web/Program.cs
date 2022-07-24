using Microsoft.EntityFrameworkCore;
using TelegramChatBlazor.BLL.MappingProfile;
using TelegramChatBlazor.BLL.Services;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.DAL.MappingProfile;
using TelegramChatBlazor.Dependencies;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Web.MappingProfile;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.RegisterDependencyModules();
builder.Services.AddAutoMapper(typeof(WebMappingProfile), typeof(DataAccessMapingProfile),typeof(BllMappingProfile));

builder.Services
  .AddServerSideBlazor()
  .AddCircuitOptions(options => { options.DetailedErrors = true; });

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapHub<SignalRHub>("/signalRHub");

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");


using (var scope = app.Services.CreateScope())
{
    var botRepository = scope.ServiceProvider.GetRequiredService<IBotRepository>();
    var bots = botRepository.GetAll();

    app.UseEndpoints(async endpoints =>
    {
        endpoints.MapControllers();
        foreach (var item in bots)
        {
            await scope.ServiceProvider.GetRequiredService<IBackgroundTelegramService>().Start(item.Token);
        }
    });
}

app.Run();
