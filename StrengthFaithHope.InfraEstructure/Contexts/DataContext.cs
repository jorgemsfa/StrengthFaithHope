using Microsoft.EntityFrameworkCore;
using StrengthFaithHope.Domain.MessageContext;


namespace StrengthFaithHope.Infra.Contexts
{
    public class DataContext : DbContext
    {
     
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Message> Message { get; set; }

        public DbSet<Type> Type { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Message>().ToTable("Message");

        //}
    }
}
