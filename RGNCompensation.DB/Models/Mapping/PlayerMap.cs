using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using RGNCompensation.Models;

namespace RGNCompensation.DB.Models.Mapping
{
    public class PlayerMap : EntityTypeConfiguration<Player>
    {
        public PlayerMap()
        {
            // Primary Key
            this.HasKey(t => t.uid);

            // Properties
            // Table & Column Mappings
            this.ToTable("Players");
            this.Property(t => t.uid).HasColumnName("uid");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.playerid).HasColumnName("playerid");
            this.Property(t => t.cash).HasColumnName("cash");
            this.Property(t => t.bankacc).HasColumnName("bankacc");
            this.Property(t => t.coplevel).HasColumnName("coplevel");
            this.Property(t => t.cop_licenses).HasColumnName("cop_licenses");
            this.Property(t => t.civ_licenses).HasColumnName("civ_licenses");
            this.Property(t => t.med_licenses).HasColumnName("med_licenses");
            this.Property(t => t.cop_gear).HasColumnName("cop_gear");
            this.Property(t => t.med_gear).HasColumnName("med_gear");
            this.Property(t => t.mediclevel).HasColumnName("mediclevel");
            this.Property(t => t.arrested).HasColumnName("arrested");
            this.Property(t => t.aliases).HasColumnName("aliases");
            this.Property(t => t.adminlevel).HasColumnName("adminlevel");
            this.Property(t => t.donatorlvl).HasColumnName("donatorlvl");
            this.Property(t => t.civ_gear).HasColumnName("civ_gear");
            this.Property(t => t.blacklist).HasColumnName("blacklist");
            //this.Property(t => t.last_connected).HasColumnName("last_connected");

        }
    }
}