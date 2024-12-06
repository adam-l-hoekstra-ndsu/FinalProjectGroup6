using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup6.Models;

namespace FinalProjectGroup6.Data
{
    public class FinalProjectGroup6Context : DbContext
    {
        public FinalProjectGroup6Context (DbContextOptions<FinalProjectGroup6Context> options)
            : base(options)
        {
        }

        public DbSet<FinalProjectGroup6.Models.AnimalShelter> AnimalShelter { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.Address> Address { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.Dog> Dog { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.User> User { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.Message> Message { get; set; } = default!;
    }
}
