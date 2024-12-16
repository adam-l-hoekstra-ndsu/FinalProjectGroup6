using FinalProjectGroup6.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectGroup6.Data
{
    public class AddressSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new FinalProjectGroup6Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalProjectGroup6Context>>());

            if (context == null || context.Address == null)
            {
                throw new NullReferenceException(
                    "Null Dbset");
            }

            if (context.Address.Any())
            {
                return;
            }

            context.Address.AddRange(
                new Address
                {
                    StreetAddress = "2497 44th Ave S",
                    City = "Grand Forks",
                    State = "North Dakota",
                    ZipCode = 58201,
                },
                new Address
                {
                    StreetAddress = "5678 Oak Rd",
                    City = "Minot",
                    State = "North Dakota",
                    ZipCode = 58701,
                },
                new Address
                {
                    StreetAddress = "9876 Pine Ln",
                    City = "Bismarck",
                    State = "North Dakota",
                    ZipCode = 58501,
                },
                new Address
                {
                    StreetAddress = "1357 Birch Blvd",
                    City = "West Fargo",
                    State = "North Dakota",
                    ZipCode = 58103,
                },
                new Address
                {
                    StreetAddress = "2468 Cedar Dr",
                    City = "Grand Forks",
                    State = "North Dakota",
                    ZipCode = 58202,
                },
                new Address
                {
                    StreetAddress = "7531 Elm St",
                    City = "Williston",
                    State = "North Dakota",
                    ZipCode = 58801,
                });

            context.SaveChanges();
        }
    }
}
