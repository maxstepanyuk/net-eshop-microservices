using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>()); //D.E.
            }

        }

        private static void SeedData(AppDbContext context) // for seeding and migrations
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("PrepDb --> Seeding data...");
                context.Platforms.AddRange(
                    new Platform() { Name = "Dot net", Pubihser = "Microdoft", Cost = "free" },
                    new Platform() { Name = "SQL SErver", Pubihser = "Microdoft", Cost = "free*" },
                    new Platform() { Name = "Kubernetes", Pubihser = "CNCF", Cost = "free" }
                );

                Console.WriteLine("PrepDb --> ...Saving changes...");
                
                context.SaveChanges();

                Console.WriteLine("PrepDb --> ...done");

            }
            else
            {
                Console.WriteLine("PrepDb --> we already have data");
            }
        }
    }
}