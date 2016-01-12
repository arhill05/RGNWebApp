using RGNCompensation.DB.Models;
using RGNCompensation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RGNCompensation.Repository
{
    public class UsersRepo
    {
        private UserDbContext dbContext = new UserDbContext();

        public IQueryable<User> GetAllUsers()
        {
            return dbContext.Users;
        }
    }
}