
using BaseballMVC.DataService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaseballMVC.UI.Repositories
{
    public class TeamsRepository
    {
        public BaseballEntities dbEntities ;
        public TeamsRepository()
        {
            dbEntities = new BaseballEntities();
        }
        public void AddTeams(Team team)
        {
            dbEntities.Teams.Add(team);
            dbEntities.SaveChanges();
        }
        public void EditTeam(Team team)
        {
            dbEntities.Entry(team).State = EntityState.Modified;
            dbEntities.SaveChanges();

        }
        public void DeleteTeam(Team team)
        {
            dbEntities.Teams.Remove(team);
            dbEntities.SaveChanges();
        }
       /* public IEnumerable<Team> GetTeams(int id)
        {
            var team = dbEntities.Teams.Where(teams => teams.teamId == id);
            return team;
        }*/
        public Team GetReview(int id)
        {
            var planReviews = dbEntities.Teams.Where(teams => teams.teamId == id).FirstOrDefault();
            return team;
        }

    }
}