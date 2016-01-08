using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RGNCompensation.DB.Models.Mapping;
using RGNCompensation.Models;
using System.Data.Entity;

namespace RGNCompensation.DB.Models
{
    public partial class PlayerDbContext : DbContext
    {
        static PlayerDbContext()
        {
            Database.SetInitializer<PlayerDbContext>(null);
        }

        public PlayerDbContext()
            : base("Name=DefaultConnection")
        {
        }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PlayerMap());
            modelBuilder.Configurations.Add(new CompensationLogMap());
        }

        public DbSet<CompensationLog> CompensationLog { get; set; }
        
    }

}