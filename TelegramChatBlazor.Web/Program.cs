using Microsoft.EntityFrameworkCore;
using TelegramChatBlazor.BLL.Services;
using TelegramChatBlazor.DAL.Context;
using TelegramChatBlazor.DAL.MappingProfile;
using TelegramChatBlazor.DAL.Repository;
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
builder.Services.AddAutoMapper(typeof(WebMappingProfile), typeof(DataAccessMapingProfile));


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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");


using (var scope = app.Services.CreateScope())
{
    //var telegramService = new TelegramService(messageReposti);

    //scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    //scope.ServiceProvider.GetRequiredService<IMessageRepository>();
    //var telegramService = scope.ServiceProvider.GetRequiredService<ITelegramService>();

    var backgroundTelegramService = scope.ServiceProvider.GetRequiredService<IBackgroundTelegramService>();

    app.UseEndpoints(async endpoints =>
    {
        endpoints.MapControllers();
        await backgroundTelegramService.Start();
    });
}

app.Run();
