using Microsoft.EntityFrameworkCore;
using FinalProjectGroup6.Models;
namespace FinalProjectGroup6.Data;

public class ApplicationSeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new FinalProjectGroup6Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<FinalProjectGroup6Context>>());

        if (context == null || context.Application == null)
        {
            throw new NullReferenceException(
                "Null FinalProjectGroup6Context or Student DbSet");
        }

        if (context.Application.Any())
        {
            return;
        }

        context.Application.AddRange(
            new Application
            {
                DogID = 2,
                CustomerID = 3,
                Status = "Approved",
                SubmitDate = DateOnly.FromDateTime(DateTime.Now),
                ReviewDate = DateOnly.FromDateTime(DateTime.Now),
                WhyHaveDog = "I need a furry friend to keep me company.",
                Experience = "My family had a dog when I was younger.",
                NumPetsOwned = 0,
                Activities = "Daily walks, a large yard to play in, and lots of cuddles!",
                Inside = true,
                HrsLeftAlone = 20,
                CanProvideCare = true,
            },
            new Application
            {
                DogID = 1,
                CustomerID = 6,
                Status = "Rejected",
                SubmitDate = DateOnly.FromDateTime(DateTime.Now),
                ReviewDate = DateOnly.FromDateTime(DateTime.Now),
                WhyHaveDog = "My friends and I want to get a dog together in our dorm.",
                Experience = "My parents had a dog when I was a baby, and my friends had dogs as kids.",
                NumPetsOwned = 0,
                Activities = "Playing with toys, going to the dog park.",
                Inside = true,
                HrsLeftAlone = 27,
                CanProvideCare = false,
                RejectReason = "In order to adopt a dog, you must be able to provide consistent veterinary care."
            },
            new Application
            {
                DogID = 4,
                CustomerID = 4,
                Status = "Not Reviewed",
                SubmitDate = DateOnly.FromDateTime(DateTime.Now),
                WhyHaveDog = "I want another dog who I can come home to after work.",
                Experience = "I have one dog already.",
                NumPetsOwned = 1,
                Activities = "I go on walks often and have lots of space to run and play even.",
                Inside = true,
                HrsLeftAlone = 30,
                CanProvideCare = true,
            },
            new Application
            {
                DogID = 6,
                CustomerID = 1,
                Status = "Approved",
                SubmitDate = DateOnly.FromDateTime(DateTime.Now),
                ReviewDate = DateOnly.FromDateTime(DateTime.Now),
                WhyHaveDog = "My husband and I want to get our pets another friend to play with.",
                Experience = "We already have 3 dogs and a cat who we love very much.",
                NumPetsOwned = 2,
                Activities = "A large farm to run around, trips to the dog park, hunting",
                Inside = false,
                HrsLeftAlone = 15,
                CanProvideCare = true,
            });

        context.SaveChanges();
    }
}

