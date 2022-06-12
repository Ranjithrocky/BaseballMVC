using BaseballMVC.DataService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaseballMVC.UI.Repositories
{
    public class VenueRepository
    {
        public BaseballEntities dbEntities;
        public VenueRepository()
        {
            dbEntities = new BaseballEntities();
        }
        public void AddTeams(Venue  venue)
        {
            dbEntities.Venues.Add(venue);
            dbEntities.SaveChanges();
        }
        public void EditTeam(Venue venue)
        {
            dbEntities.Entry(venue).State = EntityState.Modified;
            dbEntities.SaveChanges();

        }
        public void DeleteVenue(Venue venue)
        {
            dbEntities.Venues.Remove(venue);
            dbEntities.SaveChanges();
        }


        ///  Jus did this for a practice not necessary in this prjct

        /* public IEnumerable<Team> GetTeams(int id)
         {
             var team = dbEntities.Teams.Where(teams => teams.teamId == id);
             return team;
         }*/
        public Refree GetVenue(int id)
        {
            var venue = dbEntities.Venues.Where(venues => venues.refreeId == id).FirstOrDefault();
            return venue;
        }
    }
}