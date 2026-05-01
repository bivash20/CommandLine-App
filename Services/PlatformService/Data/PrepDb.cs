using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using PlatformService.Models;
using Microsoft.EntityFrameworkCore;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app,bool isProd)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            SeedData(context,isProd);
        }

        private static void SeedData(AppDbContext? context,bool isProd)
        {

            if(isProd)
            {
                Console.WriteLine("--> Attempting to apply migrations...");
                try
                {
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"--> Could not run migrations: {ex.Message}");   
                }
            }
            else
            {
                Console.WriteLine("--> Using In-Memory Database");
            }
            if (context == null)
                return;

            if (!context.Platforms.Any())
            {
                Console.WriteLine("Seeding data...");
                context.Platforms.AddRange(
                    new Platform { Name = "DotNet", Publisher = "Microsoft", Cost = "Free" },
                    new Platform { Name = "SQL Server", Publisher = "Microsoft", Cost = "Paid" },
                    new Platform { Name = "Postgres", Publisher = "PostgreSQL Global", Cost = "Free" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We already have data");
            }
        }
    }
}
