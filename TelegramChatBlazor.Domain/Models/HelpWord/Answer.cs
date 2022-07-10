namespace TelegramChatBlazor.Domain.Models.HelpWord;

public class Answer
{
    public long Id { get; set; }
    public string ShortName { get; set; }
    public string FullAnswer { get; set; }
    public DateTime CreatedAt { get; set; }
    public long CategoryId { get; set; }
    public Category Category { get; set; }
}
