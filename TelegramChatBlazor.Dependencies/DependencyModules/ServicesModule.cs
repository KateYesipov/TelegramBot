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
            services.AddScoped<IHasher, Hasher>();
            services.AddHttpClient<IBackgroundTelegramService, BackgroundTelegramService>();
            services.AddScoped<IChatRepository, ChatRepository>();
            services.AddHttpClient<ITelegramService, TelegramService>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IBotRepository, BotRepository>();
            services.AddScoped<IBotService, BotService>();

            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IColorService, ColorService>();

            services.AddScoped<IManagerRepository, ManagerRepostitory>();
            services.AddScoped<IManagerService, ManagerService>();

            services.AddScoped<IAttachmentRepository, AttachmentRepository>();
            services.AddScoped<IAttachmentService, AttachmentService>();

            services.AddScoped<ICategoryAnswerRepository, CategoryAnswerRepository>();
            services.AddScoped<ICategoryAnswerService, CategoryAnswerService>();

            services.AddScoped< IAnswerRepository , AnswerRepository>();
            services.AddScoped<IAnswerService, AnswerService>();

            services.AddScoped<IDeepService, DeepService>();

            services.AddScoped<ICategoryAnswerRepository, CategoryAnswerRepository>();
            services.AddScoped<ICategoryAnswerService, CategoryAnswerService>();

            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<ILanguageService, LanguageService>();

            services.AddSignalR();
            services.AddScoped<IAppSettingsService, AppSettingsService>();
            services.AddHttpContextAccessor();
        }
    }
}
