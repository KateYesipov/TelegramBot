using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Client;
using TelegramChatBlazor.BLL.Services;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.SignalR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TelegramChatBlazor.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiMessageController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;
        private readonly ITelegramService _telegramService;
        private readonly HubConnection _hubConnection;
        protected readonly IMapper _mapper;

        public ApiMessageController(IMessageRepository messageRepository,
                                    IMapper mapper,
                                    ITelegramService telegramService)
        {
            _telegramService = telegramService;
            _messageRepository = messageRepository;
            _mapper = mapper;
            _hubConnection = new HubConnectionBuilder()
              .WithUrl("https://localhost:7142/signalRHub")
              .Build();
        }

        [HttpPost]
        public async void Post([FromBody] MessageRequest value)
        {
            _telegramService.AddMessage(value);

            var messageNotification = _mapper.Map<MessageNotification>(value);
            await _hubConnection.StartAsync();
            await _hubConnection.SendAsync("SendMessageAsync", messageNotification);
        }
    }
}
