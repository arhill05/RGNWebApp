using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using RGNCompensation.Models;


namespace RGNCompensation.DB.Models.Mapping
{
    public class CompensationLogMap : EntityTypeConfiguration<CompensationLog>
    {
        public CompensationLogMap()
        {
            // Primary Key
            this.HasKey(t => t.reimburse_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("reimbursement_log");
            this.Property(t => t.reimburse_id).HasColumnName("reimburse_id");
            this.Property(t => t.reimburse_amount).HasColumnName("reimburse_amount");
            this.Property(t => t.reimburse_player_id).HasColumnName("reimburse_player_id");
            this.Property(t => t.reimburse_justification).HasColumnName("reimburse_justification");
            this.Property(t => t.reimburse_admin).HasColumnName("reimburse_admin");
            //this.Property(t => t.reimburse_timestamp).HasColumnName("reimburse_timestamp");
        }
    }
}