using ExploreCalifornia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Data
{
    interface ITourGateway
    {
        IEnumerable<Tour> SelectAll();

        Tour SelectById(int? id);

        void Insert(Tour tour);

        void update(Tour tour);

        Tour Delete(int? id);

        void Save();
    }

    public class TourGateway : ITourGateway
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

        public void update(Tour tour)
        {
            db.Tour.Update(tour);
            db.SaveChanges();
        }
    }
}
