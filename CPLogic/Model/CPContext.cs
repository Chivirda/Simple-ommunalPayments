using System.Data.Entity;

namespace CPLogic.Model
{
    public class CPContext : DbContext
    {
        public CPContext() : base("CPConnection") { }

        public DbSet<House> Houses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
