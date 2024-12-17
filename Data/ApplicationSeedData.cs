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
        
        var dogs = context.Dog.ToList();
        var users = context.User.ToList();

        context.Application.AddRange(
            new Application
            {
                DogID = dogs[1].Id,
                CustomerID = users[1].Id,
                Status = "Rejected",
                SubmitDate = DateOnly.FromDateTime(DateTime.Now),
                ReviewDate = DateOnly.FromDateTime(DateTime.Now),
                WhyHaveDog = "I need a furry friend to keep me company.",
                Experience = "I've never had any pets before.",
                NumPetsOwned = 0,
                Activities = "Daily walks, a large yard to play in, and lots of cuddles!",
                Inside = true,
                HrsLeftAlone = 20,
                CanProvideCare = true,
                RejectReason = "No previous experience with pets."
            },
            new Application
            {
                DogID = dogs[0].Id,
                CustomerID = users[2].Id,
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
                DogID = dogs[3].Id,
                CustomerID = users[2].Id,
                Status = "Rejected",
                SubmitDate = DateOnly.FromDateTime(DateTime.Now),
                ReviewDate = DateOnly.FromDateTime(DateTime.Now),
                WhyHaveDog = "I want another dog who I can come home to after work.",
                Experience = "I have 3 dogs already.",
                NumPetsOwned = 3,
                Activities = "I go on walks often and have lots of space to run and play even.",
                Inside = true,
                HrsLeftAlone = 30,
                CanProvideCare = true,
                RejectReason = "This dog does not get along well with other animals."
            });

        context.SaveChanges();
    }
}

