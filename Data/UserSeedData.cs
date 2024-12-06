using FinalProjectGroup6.Models;
using FinalProjectGroup6.Services;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectGroup6.Data
{
    public class UserSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new FinalProjectGroup6Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalProjectGroup6Context>>());

            if (context == null || context.User == null)
            {
                throw new NullReferenceException(
                    "Null Dbset");
            }

            if (context.User.Any())
            {
                return;
            }

            var addresses = context.Address.ToList();
            var shelters = context.AnimalShelter.ToList();

            context.User.AddRange(
                new User
                {
                    UserName = "admin",
                    Role = "Administrator",
                    Password = PasswordService.HashPassword("AdminPassword#123"),
                    FirstName = "Matthew",
                    LastName = "Evans",
                    AddressId = addresses[3].Id,
                    EmailAddress = "evansmr225@gmail.com",
                    DateOfBirth = new DateTime(2005, 2, 25, 0, 0, 0),
                    PhoneNumber = "9374691852",
                    ShelterId = null,
                    IsActive = true
                },
                new User
                {
                    UserName = "john_doe",
                    Role = "ShelterEmployee",
                    Password = PasswordService.HashPassword("NotSecure#123"),
                    FirstName = "John",
                    LastName = "Doe",
                    AddressId = addresses[4].Id,
                    EmailAddress = "johndoe@example.com",
                    DateOfBirth = new DateTime(1990, 5, 15, 0, 0, 0),
                    PhoneNumber = "1234567890",
                    ShelterId = shelters[0].Id,
                    IsActive = true
                },
                new User
                {
                    UserName = "jane_smith",
                    Role = "Customer",
                    Password = PasswordService.HashPassword("NotSecure#123"),
                    FirstName = "Jane",
                    LastName = "Smith",
                    AddressId = addresses[5].Id,
                    EmailAddress = "janesmith@example.com",
                    DateOfBirth = new DateTime(1988, 8, 22, 0, 0, 0),
                    PhoneNumber = "9876543210",
                    ShelterId = null,
                    IsActive = true
                });
            context.SaveChanges();
        }
    }
}
