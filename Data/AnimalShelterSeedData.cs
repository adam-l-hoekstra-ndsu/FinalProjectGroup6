using Microsoft.EntityFrameworkCore;
using FinalProjectGroup6.Models;

namespace FinalProjectGroup6.Data
{
    public class AnimalShelterSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new FinalProjectGroup6Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalProjectGroup6Context>>());

            if (context == null || context.AnimalShelter == null)
            {
                throw new NullReferenceException(
                    "Null Dbset");
            }

            if (context.AnimalShelter.Any())
            {
                return;
            }

            // Retrieve all Address entries from the database
            var addresses = context.Address.ToList();

            context.AnimalShelter.AddRange(
                new AnimalShelter
                {
                    Picture = "/Images/Shelters/defaultshelter1.jpg",
                    Name = "Happy Happy Shelter",
                    AddressId = addresses[0].Id,
                    OpeningHour = 9,
                    ClosingHour = 18,
                    PhoneNumber = "6122223333",
                    EmailAddress = "email@gmail.com",
                    IsActive = true,
                },
                new AnimalShelter
                {
                    Picture = "/Images/Shelters/defaultshelter2.jpg",
                    Name = "King of Shelter",
                    AddressId = addresses[1].Id,
                    OpeningHour = 7,
                    ClosingHour = 17,
                    PhoneNumber = "6124445555",
                    EmailAddress = "fakeemail@gmail.com",
                    IsActive = true,
                },
                new AnimalShelter
                {
                    Picture = "/Images/Shelters/defaultshelter3.jpg",
                    Name = "Doggone Shelter",
                    AddressId = addresses[2].Id,
                    OpeningHour = 9,
                    ClosingHour = 19,
                    PhoneNumber = "6125556666",
                    EmailAddress = "realemail@gmail.com",
                    IsActive = true,
                });

            context.SaveChanges();
        }
    }

}
