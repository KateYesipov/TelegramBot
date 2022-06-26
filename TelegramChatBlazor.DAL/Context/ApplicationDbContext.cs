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
        public DbSet<Bot> Bots { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Message> Message { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Chat>().HasIndex(u => u.Id).IsUnique();

            builder.Entity<Chat>()
           .HasMany<Message>(g => g.Messages)
           .WithOne(s => s.Chat).HasForeignKey(s => s.ChatId);

            builder.Entity<Bot>()
           .HasMany<Chat>(g => g.Chats)
           .WithOne(s => s.Bot).HasForeignKey(s => s.BotId);

            base.OnModelCreating(builder);
        }
    }
}

