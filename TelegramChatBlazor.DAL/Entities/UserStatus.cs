namespace TelegramChatBlazor.DAL.Entities
{
    public class UserStatus: Entity<long>
    {
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
