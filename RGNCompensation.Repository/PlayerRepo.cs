using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RGNCompensation.Models;
using RGNCompensation.DB.Models;

namespace RGNCompensation.Repository
{
    public class PlayerRepo
    {
        private PlayerDbContext dbContext = new PlayerDbContext();

        public IQueryable<Player> GetAllPlayers()
        {
            return dbContext.Players;
        }

        public Player Update(Player item)
        {
            dbContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
            
            return item;

        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public Player Update(Player player, CompensationLog compensationLog)
        {
            dbContext.Entry(player).State = System.Data.Entity.EntityState.Modified;
            new CompensationRepo().Add(compensationLog);
            return player;

        }
    }
}
