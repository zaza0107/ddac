using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ddac.Models;

namespace ddac.Models
{
    public class ddacContext : DbContext
    {
        public ddacContext (DbContextOptions<ddacContext> options)
            : base(options)
        {
        }

        public DbSet<ddac.Models.Hotel> Hotel { get; set; }

        public DbSet<ddac.Models.Restaurant> Restaurant { get; set; }

        public DbSet<ddac.Models.BeautynSpa> BeautynSpa { get; set; }

        public DbSet<ddac.Models.Activity> Activity { get; set; }
    }
}
