using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreCore.Models
{
    public class MovieStoreCoreContext : DbContext
    {
        public MovieStoreCoreContext (DbContextOptions<MovieStoreCoreContext> options)
            : base(options)
        {
        }

        public DbSet<MovieStoreCore.Models.Movie> Movie { get; set; }
    }
}
