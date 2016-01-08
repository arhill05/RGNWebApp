using RGNCompensation.DB.Models;
using RGNCompensation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RGNCompensation.Repository
{
    public class CompensationRepo
    {
        private PlayerDbContext dbContext = new PlayerDbContext();

        public IQueryable<CompensationLog> GetAllCompensationLogs()
        {
            return dbContext.CompensationLog;
        }

        public CompensationLog Update(CompensationLog item)
        {
            dbContext.Entry(item).State = System.Data.Entity.EntityState.Modified;

            return item;

        }

        public CompensationLog Add(CompensationLog item)
        {
            dbContext.CompensationLog.Add(item);
            SaveChanges();
            return item;
        }


        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
    }
}