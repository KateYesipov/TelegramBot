using Newtonsoft.Json;
using System.Net;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using TelegramChatBlazor.Domain.Abstract.Services;
using TelegramChatBlazor.Domain.Models.Api;

namespace TelegramChatBlazor.BLL.Services
{
    public class BackgroundTelegramService : IBackgroundTelegramService
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
            
        }

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {

                var bot = botClient.GetMeAsync().Result;
                var message = update.Message;

                var chat = await botClient.GetChatAsync(message.Chat.Id);
                var avatarPartnerId = chat.Photo.BigFileId;
                          

                var newMessage = new MessageRequest(message.Chat.Id,
                    message.Text, true, avatarPartnerId, message.Chat.Username,
                    message.Chat.FirstName, message.Chat.LastName,
                    bot.FirstName, "");



                var url = "https://localhost:7142/api/apimessage";
                var parametrs = new StringContent(JsonConvert.SerializeObject(newMessage), Encoding.UTF8, "application/json");

                var response = await _httpclient.PostAsync(url, parametrs).ConfigureAwait(false);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Do something with response. Example get content:
                    // var responseContent = await response.Content.ReadAsStringAsync ().ConfigureAwait (false);
                }


                //if (message.Text.ToLower() == "/start")
                //{
                //    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать на борт, добрый путник!");


                //    return;
                //}
                //await botClient.SendTextMessageAsync(message.Chat, "Привет-привет!!");

                //var newMessageBot = new MessageRequest(message.Chat.Id,
                //   "Lorem Ipsum - это, часто используемый в печати и вэб-дизайне. Lorem Ipsum является стандартной для текстов на латинице с начала XVI века. В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum для распечатки образцов. Lorem Ipsum не только успешно пережил без заметных изменений пять веков, но и перешагнул в электронный дизайн. Его популяризации в новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum.", false, "", message.Chat.Username ?? "Username",
                //   message.Chat.FirstName, message.Chat.LastName ?? "LastName",
                //    bot.FirstName, "");

                //var urlBot = "https://localhost:7142/api/apimessage";
                //var parametrsBot = new StringContent(JsonConvert.SerializeObject(newMessageBot), Encoding.UTF8, "application/json");

                //var responseBot = await _httpclient.PostAsync(urlBot, parametrsBot).ConfigureAwait(false);
                //if (responseBot.StatusCode == HttpStatusCode.OK)
                //{
                //    // Do something with response. Example get content:
                //    // var responseContent = await response.Content.ReadAsStringAsync ().ConfigureAwait (false);
                //}

            }
        }

        private async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }
    }
}
