using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past activity 1",
                    Date =  DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                },
                    new Activity
                {
                    Title = "Past activity 2",
                    Date =  DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                    new Activity
                {
                    Title = "Future activity 1",
                    Date =  DateTime.UtcNow.AddMonths(1),
                    Description = "Activity 1 months in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum"
                },
                    new Activity
                {
                    Title = "Future activity 2",
                    Date =  DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "02 Arena"
                },
                   new Activity
                {
                    Title = "Future activity 3",
                    Date =  DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub"
                },
                   new Activity
                {
                    Title = "Future activity 4",
                    Date =  DateTime.UtcNow.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet Another Pub"
                },
                   new Activity
                {
                    Title = "Future activity 5",
                    Date =  DateTime.UtcNow.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub"
                },
                    new Activity
                {
                    Title = "Future activity 6",
                    Date =  DateTime.UtcNow.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden"
                },


            };
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}