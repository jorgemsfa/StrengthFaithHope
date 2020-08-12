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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().ToTable("Message");           

        }
    }
}
