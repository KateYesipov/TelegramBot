using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Client;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.Settings;
using TelegramChatBlazor.Domain.Models.SignalR;

namespace TelegramChatBlazor.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiMessageController : ControllerBase
    {
        private readonly ITelegramService _telegramService;
        private readonly HubConnection _hubConnection;
        protected readonly IMapper _mapper;
        private readonly TelegramChatBlazorSettings _chatBlazorSettings;

        public ApiMessageController(IMapper mapper,
                                    ITelegramService telegramService,
                                    IAppSettingsService appSettingsService)
        {
            _chatBlazorSettings = appSettingsService.TelegramChatBlazorSettings;
            _telegramService = telegramService;
            _mapper = mapper;
            _hubConnection = new HubConnectionBuilder()
              .WithUrl(_chatBlazorSettings.BaseUrl + "signalRHub")
              .Build();
        }

        [HttpPost]
        public async void Post([FromBody] MessageRequest value)
        {
            var newMessage= _telegramService.AddMessage(value);
            if (newMessage != null)
            {
                var messageNotification = _mapper.Map<ChatNotification>(newMessage);
                messageNotification.Message.CreateAt = DateTime.Now;
                await _hubConnection.StartAsync();
                await _hubConnection.SendAsync("SendMessageAsync", messageNotification);
            }
        }
    }
}
