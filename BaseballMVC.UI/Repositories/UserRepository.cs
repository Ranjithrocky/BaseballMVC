using BaseballMVC.DataService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaseballMVC.UI.Repositories
{
    public class UserRepository
    {
        public BaseballEntities dbEntities;
        public UserRepository() { 
            dbEntities = new BaseballEntities();
        }

        public void AddUser(User user)
        {
            dbEntities.Users.Add(user);
            dbEntities.SaveChanges();
        }
        public void EditUser(User user)
        {
            dbEntities.Entry(user).State = EntityState.Modified;
            dbEntities.SaveChanges();
        }
        public void DeleteUser(User user)
        {
            dbEntities.Users.Remove(user);
            dbEntities.SaveChanges();
        }
        public User GetUser(string id)
        {
            var UserData = dbEntities.Users.Where(user => user.UserId == id).FirstOrDefault();
            return UserData;
        }
    }
}