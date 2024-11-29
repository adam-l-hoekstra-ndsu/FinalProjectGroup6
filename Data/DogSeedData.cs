using FinalProjectGroup6.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectGroup6.Data
{
    public class DogSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new FinalProjectGroup6Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalProjectGroup6Context>>());

            if (context == null || context.Dog == null)
            {
                throw new NullReferenceException(
                    "Null Dbset");
            }

            if (context.Dog.Any())
            {
                return;
            }

            var shelters = context.AnimalShelter.ToList();

            context.Dog.AddRange(
                new Dog
                {
                    Picture = "/Images/Dogs/defaultdog1.jpg",
                    Status = 0,
                    Name = "Suzanne",
                    Gender = "Female",
                    Breed = "Bulldog",
                    Age = 5,
                    Color = "White",
                    IsNeuteredSpayed = true,
                    ShelterId = shelters[0].Id,
                    IsActive = true,
                },
                new Dog
                {
                    Picture = "/Images/Dogs/defaultdog2.jpg",
                    Status = 0,
                    Name = "Charlie",
                    Gender = "Male",
                    Breed = "Labrador Retriever",
                    Age = 3,
                    Color = "Yellow",
                    IsNeuteredSpayed = true,
                    ShelterId = shelters[0].Id,
                    IsActive = true,
                },
                new Dog
                {
                    Picture = "/Images/Dogs/defaultdog3.jpg",
                    Status = 0,
                    Name = "Max",
                    Gender = "Male",
                    Breed = "German Shepherd",
                    Age = 4,
                    Color = "Black and Tan",
                    IsNeuteredSpayed = true,
                    ShelterId = shelters[1].Id,
                    IsActive = true,
                },
                new Dog
                {
                    Picture = "/Images/Dogs/defaultdog4.jpg",
                    Status = 0,
                    Name = "Bella",
                    Gender = "Female",
                    Breed = "Golden Retriever",
                    Age = 2,
                    Color = "Golden",
                    IsNeuteredSpayed = true,
                    ShelterId = shelters[1].Id,
                    IsActive = true,
                },
                new Dog
                {
                    Picture = "/Images/Dogs/defaultdog5.jpg",
                    Status = 0,
                    Name = "Rocky",
                    Gender = "Male",
                    Breed = "Boxer",
                    Age = 6,
                    Color = "Brindle",
                    IsNeuteredSpayed = false,
                    ShelterId = shelters[2].Id,
                    IsActive = true,
                },
                new Dog
                {
                    Picture = "/Images/Dogs/defaultdog6.jpg",
                    Status = 0,
                    Name = "Lucy",
                    Gender = "Female",
                    Breed = "Beagle",
                    Age = 7,
                    Color = "Tri-color",
                    IsNeuteredSpayed = true,
                    ShelterId = shelters[2].Id,
                    IsActive = true
                });
            context.SaveChanges();
        }
    }
}

