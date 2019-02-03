using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExploreCalifornia.Models
{
    public class ExploreCaliforniaContext : DbContext
    {
        public ExploreCaliforniaContext()
        {
        }

        public ExploreCaliforniaContext (DbContextOptions<ExploreCaliforniaContext> options)
            : base(options)
        {
        }

        public DbSet<ExploreCalifornia.Models.Tour> Tour { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ExploreCaliforniaContext-fa2ef66e-f0c9-438f-b64b-78bf49c8b6c8;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
    }
}
