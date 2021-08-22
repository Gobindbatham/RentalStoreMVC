using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentalStore.Models;

namespace RentalStore.Data
{
    public class RentalStoreContext : DbContext
    {
        public RentalStoreContext (DbContextOptions<RentalStoreContext> options)
            : base(options)
        {
        }

        public DbSet<RentalStore.Models.TaskLogin> TaskLogin { get; set; }

        public DbSet<RentalStore.Models.Author> Author { get; set; }

        public DbSet<RentalStore.Models.Publisher> Publisher { get; set; }

        public DbSet<RentalStore.Models.book> book { get; set; }

        public DbSet<RentalStore.Models.Rental> Rental { get; set; }
    }
}
