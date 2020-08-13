using Microsoft.EntityFrameworkCore;
using StrengthFaithHope.Domain.MessageContext;


namespace StrengthFaithHope.Infra.Contexts
{
    public class DataContext : DbContext
    {
     
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().ToTable("Message");
            modelBuilder.Entity<Message>().ToTable("Type");
        }
    }
}
