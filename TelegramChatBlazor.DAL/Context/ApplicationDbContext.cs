using Microsoft.EntityFrameworkCore;
using TelegramChatBlazor.DAL.Entities;

namespace TelegramChatBlazor.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Bot> Bots { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Chat>().HasIndex(u => u.Id).IsUnique();

            builder.Entity<Category>().HasMany(x => x.Answers)
           .WithOne(x => x.Category).HasForeignKey(x => x.CategoryId)
           .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Chat>()
           .HasMany<Message>(g => g.Messages)
           .WithOne(s => s.Chat).HasForeignKey(s => s.ChatId);

            builder.Entity<Bot>()
           .HasMany<Chat>(g => g.Chats)
           .WithOne(s => s.Bot).HasForeignKey(s => s.BotId);

            builder.Entity<Message>()
           .HasMany<Attachment>(g => g.Attachments)
           .WithOne(s => s.Message).HasForeignKey(s => s.MessageId);

            builder.Entity<Bot>().HasData(new Bot { Id = 1, Token = "5536982597:AAHGE_tYhVLViVvUzlnFpelX7aSv0H4kbp8", Name = "Jironimo", UserName = "JironimoBot", CreateAt = DateTime.Now, Chats = new List<Chat> { } });
            builder.Entity<Bot>().HasData(new Bot { Id = 2, Token = "5493821109:AAGpCZCpURP2dn1yM_wEdAQCdA21avI5ggM", Name = "TelegramBotBlazor", UserName = "TelegramBotBlazorBot", CreateAt = DateTime.Now, Chats = new List<Chat> { } });

            builder.Entity<Color>().HasData(new Color { Id = 1, ColorHex = "#FFFFFF" });
            builder.Entity<Color>().HasData(new Color { Id = 2, ColorHex = "#3C95FF" });
            builder.Entity<Color>().HasData(new Color { Id = 3, ColorHex = "#FFCE31" });
            builder.Entity<Color>().HasData(new Color { Id = 4, ColorHex = "#25CC62" });
            builder.Entity<Color>().HasData(new Color { Id = 5, ColorHex = "#ED4C5C" });
            builder.Entity<Color>().HasData(new Color { Id = 6, ColorHex = "#9C4CED" });
            builder.Entity<Color>().HasData(new Color { Id = 7, ColorHex = "#4CEDED" });
            builder.Entity<Color>().HasData(new Color { Id = 8, ColorHex = "#ED4CB6" });

            builder.Entity<Manager>().HasData(new Manager { Id = 1, Name = "Alex Yesipov", Email = "testEmail@gmail.com", ImgPath = "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 2, Name = "Alex Ivanov", Email = "testEmail2@gmail.com", ImgPath = "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 3, Name = "Kate Yesipova", Email = "testEmail3@gmail.com", ImgPath = "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 4, Name = "Alex Pupkin", Email = "testEmail4@gmail.com", ImgPath = "https://image.pngaaa.com/345/1582345-middle.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 5, Name = "Alex Yesipov", Email = "testEmail@gmail.com", ImgPath = "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 6, Name = "Alex Ivanov", Email = "testEmail2@gmail.com", ImgPath = "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 7, Name = "Kate Yesipova", Email = "testEmail3@gmail.com", ImgPath = "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 8, Name = "Alex Pupkin", Email = "testEmail4@gmail.com", ImgPath = "https://image.pngaaa.com/345/1582345-middle.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });

            builder.Entity<Category>().HasData(new Category { Id = 1, Name = "Hello-bye", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 2, Name = "Продажа", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 3, Name = "Брокеры", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 4, Name = "Hello-bye", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 5, Name = "Продажа", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 6, Name = "Брокеры", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 7, Name = "Hello-bye", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 8, Name = "Продажа", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 9, Name = "Брокеры", CreatedAt = DateTime.Now });

            builder.Entity<Answer>().HasData(new Answer { Id = 1, ShortName = "Hi", FullAnswer = "Hello-bye", CategoryId = 1, CreatedAt = DateTime.Now });
            builder.Entity<Answer>().HasData(new Answer { Id = 2, ShortName = "Hi how", FullAnswer = "Hello how are you?", CategoryId = 1, CreatedAt = DateTime.Now });
            builder.Entity<Answer>().HasData(new Answer { Id = 3, ShortName = "Чем могу помочь ?", FullAnswer = "Hey!How do you do? I'm ready to talk to you and answer your questions. ", CategoryId = 1, CreatedAt = DateTime.Now });
            builder.Entity<Answer>().HasData(new Answer { Id = 4, ShortName = "Подпишись на канал с результатами", FullAnswer = "How do I get a demo version?https://globalforexforum.com/threads/elon-musk-ea-demo.340/", CategoryId = 1, CreatedAt = DateTime.Now });
            builder.Entity<Answer>().HasData(new Answer { Id = 5, ShortName = "Спасибо за ваш запрос", FullAnswer = "Okay, thanks for the request ! If you have any new questions about ELM_EA, please let me know. I am online and ready to help you 24/5", CategoryId = 1, CreatedAt = DateTime.Now });

            builder.Entity<Language>().HasData(new Language { Id = 1, Name = "Bulgarian", languageCode = "bg" });
            builder.Entity<Language>().HasData(new Language { Id = 2, Name = "Czech", languageCode = "cs" });
            builder.Entity<Language>().HasData(new Language { Id = 3, Name = "Bulgarian", languageCode = "bg" });
            builder.Entity<Language>().HasData(new Language { Id = 4, Name = "Danish", languageCode = "da" });
            builder.Entity<Language>().HasData(new Language { Id = 5, Name = "German", languageCode = "el" });
            builder.Entity<Language>().HasData(new Language { Id = 6, Name = "Greek", languageCode = "cs" });
            builder.Entity<Language>().HasData(new Language { Id = 7, Name = "English", languageCode = "en" });
            builder.Entity<Language>().HasData(new Language { Id = 8, Name = "EnglishBritish", languageCode = "en-GB" });
            builder.Entity<Language>().HasData(new Language { Id = 9, Name = "EnglishAmerican", languageCode = "en-US" });
            builder.Entity<Language>().HasData(new Language { Id = 10, Name = "Spanish", languageCode = "es" });
            builder.Entity<Language>().HasData(new Language { Id = 11, Name = "Estonian", languageCode = "et" });
            builder.Entity<Language>().HasData(new Language { Id = 12, Name = "Finnish", languageCode = "fi" });
            builder.Entity<Language>().HasData(new Language { Id = 13, Name = "French", languageCode = "fr" });
            builder.Entity<Language>().HasData(new Language { Id = 14, Name = "Hungarian", languageCode = "hu" });
            builder.Entity<Language>().HasData(new Language { Id = 15, Name = "Indonesian", languageCode = "id" });
            builder.Entity<Language>().HasData(new Language { Id = 16, Name = "Italian", languageCode = "it" });
            builder.Entity<Language>().HasData(new Language { Id = 17, Name = "Japanese", languageCode = "ja" });
            builder.Entity<Language>().HasData(new Language { Id = 18, Name = "Lithuanian", languageCode = "lt" });
            builder.Entity<Language>().HasData(new Language { Id = 19, Name = "Latvian", languageCode = "lv" });
            builder.Entity<Language>().HasData(new Language { Id = 20, Name = "Dutch", languageCode = "nl" });
            builder.Entity<Language>().HasData(new Language { Id = 21, Name = "Polish", languageCode = "pl" });
            builder.Entity<Language>().HasData(new Language { Id = 22, Name = "Portuguese", languageCode = "pt" });
            builder.Entity<Language>().HasData(new Language { Id = 23, Name = "PortugueseBrazilian", languageCode = "pt-BR" });
            builder.Entity<Language>().HasData(new Language { Id = 24, Name = "Romanian", languageCode = "ro" });
            builder.Entity<Language>().HasData(new Language { Id = 25, Name = "Russian", languageCode = "ru" });
            builder.Entity<Language>().HasData(new Language { Id = 26, Name = "Slovak", languageCode = "sk" });
            builder.Entity<Language>().HasData(new Language { Id = 27, Name = "Slovenian", languageCode = "sl" });
            builder.Entity<Language>().HasData(new Language { Id = 28, Name = "Swedish", languageCode = "sv" });
            builder.Entity<Language>().HasData(new Language { Id = 29, Name = "Turkish", languageCode = "tr" });
            builder.Entity<Language>().HasData(new Language { Id = 30, Name = "Chinese", languageCode = "zh" });

            builder.Entity<Filter>().HasData(new Filter { Id = 1, Name = "Demo", Archived = false, Mailing = false,Readed=true,Created_at= DateTime.Now,ColorHex= "#FFCE31" }); 
            builder.Entity<Filter>().HasData(new Filter { Id = 2, Name = "Will buy soon", Archived = false, Mailing = false, Readed = true, Created_at = DateTime.Now, ColorHex = "#ED4C5C" });
            builder.Entity<Filter>().HasData(new Filter { Id = 3, Name = "Client", Archived = false, Mailing = false, Readed = true, Created_at = DateTime.Now, ColorHex = "#4CEDED" });
            builder.Entity<Filter>().HasData(new Filter { Id = 4, Name = "Test", Archived = false, Mailing = true, Readed = true, Created_at = DateTime.Now, ColorHex = "#FFFFFF" });
            builder.Entity<Filter>().HasData(new Filter { Id = 5, Name = "Readed", Archived = false, Mailing = false, Readed = true, Created_at = DateTime.Now, ColorHex = "#25CC62" });
            builder.Entity<Filter>().HasData(new Filter { Id = 6, Name = "1 Step", Archived = true, Mailing = false, Readed = true, Created_at = DateTime.Now, ColorHex = "#ED4CB6" });

            base.OnModelCreating(builder);
        }
    }
}

