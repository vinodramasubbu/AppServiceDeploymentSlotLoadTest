using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviesMVC.Models;

namespace moviesMVC.Data
{
    public class moviesMVCContext : DbContext
    {
        public moviesMVCContext (DbContextOptions<moviesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<moviesMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
