using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context) {
            if (context.Activities.Any()) return;
            var activities = new List<Activity> {
                new Activity {
                    Title = "Past Activity 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                },
                new Activity {
                    Title = "Past Activity 2",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 1 months ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity {
                    Title = "Future Activity 1",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Natural History Museum"
                },
                new Activity {
                    Title = "Future Activity 2",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 2 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Natural History Museum"
                },
            };
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}