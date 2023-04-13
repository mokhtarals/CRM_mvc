
using CRM_mvc.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CRM_mvc.Context
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseMySQL("server=localhost;port=3306;database=asp_api;user=root;password=root");
        // }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Call> Calls { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ChatChannel> ChatChannels { get; set; }
        public DbSet<ReturnAction> ReturnActions { get; set; }
        public DbSet<AnswerReturnAction> AnswerReturnActions { get; set; }
        public DbSet<CustomerVerification> CustomerVerifications { get; set; }
        public DbSet<MessageAttachment> MessageAttachments { get; set; }
        public DbSet<CallChannel> CallChannels { get; set; }
        public DbSet<CallType> CallTypes { get; set; }
        public DbSet<Extention> Extentions { get; set; }
    }
}