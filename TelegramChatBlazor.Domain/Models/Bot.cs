namespace TelegramChatBlazor.Domain.Models
{
    public class Bot
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string? ImagePath { get; set; }
        public string Token { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
