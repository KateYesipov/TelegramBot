using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using TelegramChatBlazor.Domain.Abstract.Services;

namespace TelegramChatBlazor.BLL.Services
{
    public class BackgroundTelegramService: IBackgroundTelegramService
    {
        private static readonly TelegramBotClient botClient = new TelegramBotClient("5536982597:AAHGE_tYhVLViVvUzlnFpelX7aSv0H4kbp8");
        private readonly HttpClient _httpclient;

        public BackgroundTelegramService(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task Start()
        {

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            var chat = botClient.GetChatAsync(251526192).Result;
        }

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {

                var message = update.Message;


                var newMessage = new Domain.Models.Message(message.Chat.Id, message.Text, "", message.From.Username??"Username", message.From.FirstName, false);

                var url = "https://localhost:7142/api/apimessage";
                var parametrs = new StringContent(JsonConvert.SerializeObject(newMessage), Encoding.UTF8, "application/json");

                var response = await _httpclient.PostAsync(url, parametrs).ConfigureAwait(false);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Do something with response. Example get content:
                    // var responseContent = await response.Content.ReadAsStringAsync ().ConfigureAwait (false);
                }


                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать на борт, добрый путник!");

                    var newMessage1 = new Domain.Models.Message(message.Chat.Id, "Добро пожаловать на борт, добрый путник!", "", "bot", "bot", true);


                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat, "Привет-привет!!");
                var newMessage2 = new Domain.Models.Message(message.Chat.Id, "Привет-привет!!", "", "bot", "bot", true);


            }
        }

        private async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }
    }
}
