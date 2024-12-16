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

        public DbSet<FinalProjectGroup6.Models.Application> Application { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.AnimalShelter> AnimalShelter { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.Address> Address { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.Dog> Dog { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.User> User { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.PasswordResetToken> PasswordResetToken { get; set; } = default!;
        public DbSet<FinalProjectGroup6.Models.Message> Message { get; set; } = default!;

        // Override OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Map AnimalShelter entity to a specific table
            modelBuilder.Entity<AnimalShelter>(entity =>
            {
                entity.ToTable("AnimalShelter"); // Specify the table name
            });

            // Map Address entity to a specific table
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address"); // Specify the table name
            });

            // Map Dog entity to a specific table
            modelBuilder.Entity<Dog>(entity =>
            {
                entity.ToTable("Dog"); // Specify the table name
            });

            // Map User entity to a specific table
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User"); // Specify the table name
            });

            // Map PasswordResetToken entity to a specific table
            modelBuilder.Entity<PasswordResetToken>(entity =>
            {
                entity.ToTable("PasswordResetToken"); // Specify the table name
            });

            // Map Message entity to a specific table
            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message"); // Specify the table name
            });

            // Map Application entity to a specific table
            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application"); // Specify the table name
            });
        }
    }
}
