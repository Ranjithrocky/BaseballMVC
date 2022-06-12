using BaseballMVC.DataService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaseballMVC.UI.Repositories
{
    public class RefreeRepository
    {
        public BaseballEntities dbEntities;
        public RefreeRepository()
        {
            dbEntities = new BaseballEntities();
        }
        public void AddRefree(Refree refree)
        {
            dbEntities.Refrees.Add(refree);
            dbEntities.SaveChanges();
        }
        public void EditRefree(Refree refree)
        {
            dbEntities.Entry(refree).State = EntityState.Modified;
            dbEntities.SaveChanges();

        }
        public void DeleteRefree(Refree refree)
        {
            dbEntities.Refrees.Remove(refree);
            dbEntities.SaveChanges();
        }


        ///  Jus did this for a practice not necessary in this prjct

        /* public IEnumerable<Team> GetTeams(int id)
         {
             var team = dbEntities.Teams.Where(teams => teams.teamId == id);
             return team;
         }*/
        public Refree GetRefree(int id)
        {
            var refree = dbEntities.Refrees.Where(refrees => refrees.refreeId == id).FirstOrDefault();
            return refree;
        }

    }
}