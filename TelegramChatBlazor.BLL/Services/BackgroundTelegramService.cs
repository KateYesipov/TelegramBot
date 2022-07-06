using Newtonsoft.Json;
using System.Net;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.Settings;

namespace TelegramChatBlazor.BLL.Services
{
    public class BackgroundTelegramService : IBackgroundTelegramService
    {
        private readonly TelegramChatBlazorSettings _chatBlazorSettings;
        private TelegramBotClient _botClient;
        private readonly HttpClient _httpclient;
        private string Token;

        public BackgroundTelegramService(HttpClient httpclient,
                                         IAppSettingsService appSettingsService)
        {
            _httpclient = httpclient;
            _chatBlazorSettings = appSettingsService.TelegramChatBlazorSettings;
        }

        public async Task Start(string tokenBot)
        {
            Token = tokenBot;
            _botClient = new TelegramBotClient(tokenBot);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            _botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );

        }

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var bot = botClient.GetMeAsync().Result;

                var message = update.Message;

                string? imageId = null;
                if (message.Photo != null)
                {
                     imageId = (await botClient.GetFileAsync(message.Photo[message.Photo.Count() - 1].FileId)).FileId;
                }

                var chat = await botClient.GetChatAsync(message.Chat.Id);
                var avatarPartnerId = chat.Photo.SmallFileId;

                var newChatId = bot.Id - message.Chat.Id;

                var mediaGroupIdConvert = Convert.ToInt64(message?.MediaGroupId);
                var type = message.Type.ToString();

                var newMessage = new MessageRequest(Token, newChatId, message.Chat.Id,
                    message.Text, true, avatarPartnerId, message.Chat.Username,
                    message.Chat.FirstName, message.Chat.LastName,
                    bot.FirstName, "https://flowxo.com/wp-content/uploads/2021/03/Telegram-Logo-512x512.png",
                    imageId, mediaGroupIdConvert, type);


                var url = _chatBlazorSettings.ApiUrl + "api/apimessage";
                var parametrs = new StringContent(JsonConvert.SerializeObject(newMessage), Encoding.UTF8, "application/json");

                var response = await _httpclient.PostAsync(url, parametrs).ConfigureAwait(false);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                }
            }
        }

        private async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }
    }
}
