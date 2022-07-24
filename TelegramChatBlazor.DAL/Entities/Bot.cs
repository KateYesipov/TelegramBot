namespace TelegramChatBlazor.DAL.Entities
{
    public class Bot : Entity<long>
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string? ImagePath { get; set; }
        public string Token { get; set; }
        public DateTime CreateAt { get; set; }
        public List<Chat> Chats { get; set; }
        public Bot()
        {
            Chats = new List<Chat>();
        }
    }
}
