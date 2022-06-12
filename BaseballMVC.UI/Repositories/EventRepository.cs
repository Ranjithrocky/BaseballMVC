using BaseballMVC.DataService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaseballMVC.UI.Repositories
{
    public class EventRepository
    {
        public BaseballEntities dbEntities;
        public EventRepository()
        {
            dbEntities = new BaseballEntities();
        }
        public void AddEvent(Event events)
        {
            dbEntities.Events.Add(events);
            dbEntities.SaveChanges();
        }
        public void EditEvent(Event events)
        {
            dbEntities.Entry(events).State = EntityState.Modified;
            dbEntities.SaveChanges();

        }
        public void DeleteEvent(Event events)
        {
            dbEntities.Events.Remove(events);
            dbEntities.SaveChanges();
        }


        ///  Jus did this for a practice not necessary in this prjct

        /* public IEnumerable<Refree> GetRefree(int id)
         {
             var refree = dbEntities.Teams.Where(refree => refrees.refreeid == id);
             return refree;
         }*/
        public Refree GetEvent(int id)
        {
            var events = dbEntities.Refrees.Where(eventi => eventi.refreeId == id).FirstOrDefault();
            return events;
        }


    }
}