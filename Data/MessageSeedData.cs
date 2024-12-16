using FinalProjectGroup6.Models;
using FinalProjectGroup6.Services;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectGroup6.Data
{
    public class MessageSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new FinalProjectGroup6Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalProjectGroup6Context>>());

            if (context == null || context.Message == null)
            {
                throw new NullReferenceException(
                    "Null Dbset");
            }

            if (context.Message.Any())
            {
                Console.WriteLine("Messages Found");
                return;
            }

            Console.WriteLine("Begining To Create Messages");
            context.Message.AddRange(
                new Message
                {
                    UserSentFrom = 1,
                    UserSentTo = 2,
                    Subject = "Work to Do",
                    Body = "Did you get my message about all of the work we still need to do?",
                    Timestamp = DateTime.Now

                },
                new Message
                {
                    UserSentFrom = 2,
                    UserSentTo = 1,
                    Subject = "Re: Work to Do",
                    Body = "Yes I did, working on it now",
                    Timestamp = DateTime.Now

                },
                new Message
                {
                    UserSentFrom = 3,
                    UserSentTo = 1,
                    Subject = "Project Completion",
                    Body = "How close are you to completing your project?",
                    Timestamp = DateTime.Now
                });
            context.SaveChanges();
        }
    }
}
