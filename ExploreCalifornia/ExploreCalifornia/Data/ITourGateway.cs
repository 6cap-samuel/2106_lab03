using ExploreCalifornia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Data
{
    public class DataGateway
    {
        internal ExploreCaliforniaContext db = new ExploreCaliforniaContext();

        public Tour Delete(int? id)
        {
            Tour tour = db.Tour.Find(id);
            db.Tour.Remove(tour);
            db.SaveChanges();
            return tour;
        }

        public void Insert(Tour tour)
        {
            db.Tour.Add(tour);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Tour> SelectAll()
        {
            return db.Tour.ToArray();
        }

        public Tour SelectById(int? id)
        {
            return db.Tour.Find(id);
        }

        public void Update(Tour tour)
        {
            db.Tour.Update(tour);
            db.SaveChanges();
        }
    }

    public class TourGateway : DataGateway
    {
        public IEnumerable<Tour> findWithinRange(int id)
        {
            IEnumerable<Tour> tourList;

            if (id == 1)
           {
                return SelectAll();
           } else if (id == 2)
           {

           }

            return tourList;
        }
    }
}
