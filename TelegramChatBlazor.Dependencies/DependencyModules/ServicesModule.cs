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
            services.AddHttpClient<ITelegramService, TelegramService>();

            services.AddScoped<IChatRepository, ChatRepository>();
            services.AddScoped<IChatService, ChatService>();

            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<IStatusService, StatusService>();

            services.AddScoped<IUserStatusService, UserStatusService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IMessageService, MessageService>();
            
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

            services.AddScoped<IFilterRepository, FilterRepository>();
            services.AddScoped<IFilterService, FilterService>();
           
            services.AddSignalR();
            services.AddScoped<IAppSettingsService, AppSettingsService>();
            services.AddHttpContextAccessor();
        }
    }
}
