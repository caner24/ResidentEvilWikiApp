using Racoon.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.DataAccess.Concrate.EntityFramework
{
    public class RacoonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
    }
}
