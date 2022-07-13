namespace TelegramChatBlazor.Domain.Models.Api
{
    public class MessageRequest
    {
        public MessageRequest(string token, long chatId,long telegramChatId,
            string? text,bool isPartner, string partnerAvatar, string partnerUserName,
            string partnerName, string partnerLastName, string botUserName,
            string botAvatar,string? fileId,long messageGroupId,string type,string languageCode)
        {
            Token = token;
            ChatId = chatId;
            TelegramChatId = telegramChatId;
            Text = text;
            IsPartner = isPartner;
            PartnerAvatar = partnerAvatar;
            PartnerUserName = partnerUserName;
            PartnerName = partnerName;
            PartnerLastName = partnerLastName;
            BotUserName = botUserName;
            BotAvatar = botAvatar;
            FileId = fileId;
            MessageGroupId = messageGroupId;
            Type = type;
            LanguageCode = languageCode;
        }

        public long ChatId { get; set; }
        public long TelegramChatId { get; set; }       
        public string? Text { get; set; }
        public bool IsPartner { get; set; }
        public string? PartnerAvatar { get; set; }
        public string? PartnerUserName { get; set; }
        public string? PartnerName { get; set; }
        public string? PartnerLastName { get; set; }
        public string BotUserName { get; set; }
        public string? BotAvatar { get; set; }
        public string Token { get; set; }
        public string? FileId { get; set; }
        public long MessageGroupId { get; set; }
        public string Type { get; set; }
        public string LanguageCode { get; set; }
    }
}
