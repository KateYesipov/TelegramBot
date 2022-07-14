namespace TelegramChatBlazor.Domain.Models.Filters
{
    public class Filter
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ColorHex { get; set; }
        public bool? Readed { get; set; }
        public bool? Archived { get; set; }
        public bool? Mailing { get; set; }
        public DateTime Created_at { get; set; }
    }
}
