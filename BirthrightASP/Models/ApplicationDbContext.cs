using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Dynamic;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BirthrightASP.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Ruler> Rulers { get; set; }
        public DbSet<Realm> Realms { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Terrain> Terrains { get; set; }
        public DbSet<Holding> Holdings { get; set; }
        public DbSet<HoldingType> HoldingTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Border> Borders { get; set; }
        public DbSet<TradeRoute> TradeRoutes { get; set; }


        
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}