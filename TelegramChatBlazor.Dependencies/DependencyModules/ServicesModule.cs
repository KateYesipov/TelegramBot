using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Concrete;
using TelegramChatBlazor.DAL.Repository;
using TelegramChatBlazor.BLL.Services;

namespace TelegramChatBlazor.Dependencies.DependencyModules
{
    public static class ServicesModule
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.TryAddSingleton<IAppSettingsService, AppSettingsService>();      
            services.AddTransient<IHasher, Hasher>();
            services.AddHttpClient<IBackgroundTelegramService, BackgroundTelegramService>();
            services.AddTransient<IChatRepository, ChatRepository>();
            services.AddHttpClient<ITelegramService, TelegramService>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IBotRepository, BotRepository>();
            services.AddScoped<IBotService, BotService>();

            services.AddTransient<IColorRepository, ColorRepository>();
            services.AddTransient<IColorService, ColorService>();

            services.AddTransient<IManagerRepository, ManagerRepostitory>();
            services.AddTransient<IManagerService, ManagerService>();

            services.AddTransient<IAttachmentRepository, AttachmentRepository>();
            services.AddTransient<IAttachmentService, AttachmentService>();

            services.AddTransient<ICategoryAnswerRepository, CategoryAnswerRepository>();
            services.AddTransient<ICategoryAnswerService, CategoryAnswerService>();

            services.AddTransient< IAnswerRepository , AnswerRepository>();
            services.AddTransient<IAnswerService, AnswerService>();

            services.AddTransient<IDeepService, DeepService>();

            services.AddTransient<ICategoryAnswerRepository, CategoryAnswerRepository>();
            services.AddTransient<ICategoryAnswerService, CategoryAnswerService>();

            services.AddTransient<ILanguageRepository, LanguageRepository>();
            services.AddTransient<ILanguageService, LanguageService>();

            services.AddSignalR();
            services.TryAddSingleton<IAppSettingsService, AppSettingsService>();
            services.AddHttpContextAccessor();
        }
    }
}
