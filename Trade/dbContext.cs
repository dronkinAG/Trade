namespace TradeApplication
{
    using System.Data.Entity;
    using TradeApplication.Models;

    public class dbContext : DbContext
    {
        public dbContext() : base("name=TradeContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
    }
}