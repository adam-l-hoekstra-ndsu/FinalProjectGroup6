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
                    IsActive = true,
                },
                new AnimalShelter
                {
                    Picture = "/Images/Shelters/defaultshelter2.jpg",
                    Name = "King of Shelter",
                    AddressId = addresses[1].Id,
                    OpeningHour = 7,
                    ClosingHour = 17,
                    IsActive = true,
                },
                new AnimalShelter
                {
                    Picture = "/Images/Shelters/defaultshelter3.jpg",
                    Name = "Doggone Shelter",
                    AddressId = addresses[2].Id,
                    OpeningHour = 9,
                    ClosingHour = 19,
                    IsActive = true,
                });

            context.SaveChanges();
        }
    }

}
