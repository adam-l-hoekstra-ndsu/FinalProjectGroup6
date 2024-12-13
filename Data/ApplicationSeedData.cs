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
                


            },
            new Application
            {

            },
            new Application
            {

            },
            new Application
            {

            });

        context.SaveChanges();
    }
}

