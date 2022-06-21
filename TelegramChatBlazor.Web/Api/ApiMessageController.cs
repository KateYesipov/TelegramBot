using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Client;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.Settings;
using TelegramChatBlazor.Domain.Models.SignalR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

            var messageNotification = _mapper.Map<MessageNotification>(newMessage);
            await _hubConnection.StartAsync();
            await _hubConnection.SendAsync("SendMessageAsync", messageNotification);
        }
    }
}
