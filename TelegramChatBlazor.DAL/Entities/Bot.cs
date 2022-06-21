namespace TelegramChatBlazor.DAL.Entities
{
    public class Bot : Entity<long>
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
        public string CreateAt { get; set; }
    }
}
