using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lupu_Cosmina_Lab5.Models;

namespace Lupu_Cosmina_Lab5.Data
{
    public class Lupu_Cosmina_Lab5Context : DbContext
    {
        public Lupu_Cosmina_Lab5Context (DbContextOptions<Lupu_Cosmina_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Lupu_Cosmina_Lab5.Models.Book> Book { get; set; }

        public DbSet<Lupu_Cosmina_Lab5.Models.Category> Category { get; set; }

        public DbSet<Lupu_Cosmina_Lab5.Models.Publisher> Publisher { get; set; }
    }
}
