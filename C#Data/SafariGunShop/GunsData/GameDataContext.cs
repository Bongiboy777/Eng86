using Microsoft.EntityFrameworkCore;

namespace GameData
{
    public partial class GameDataContext : DbContext
    {
        public static GameDataContext Instance { get; } = new GameDataContext();

        public DbSet<PartyMember> PartyMember { get; set; }
        public DbSet<Ammo> Ammos { get; set; }
        public DbSet<Damage> Damages { get; set; }
        public DbSet<Elemental> Elementals { get; set; }
        public DbSet<Gun> Guns { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source =(localdb)\MSSQLLocalDB;Initial Catalog=GameData;");
                base.OnConfiguring(optionsBuilder);
            }
           
        }
    }
}
