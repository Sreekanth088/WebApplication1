using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Data;
using System;
using System.Linq;

namespace WebApplication1.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebApplication1Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebApplication1Context>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Fast The Furious",
                    ReleaseDate = DateTime.Parse("2000-6-18"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 38M
                },
                new Movie
                {
                    Title = "Forrest Gump ",
                    ReleaseDate = DateTime.Parse("1994-6-23"),
                    Genre = "Comedy-Drama",
                    Rating = "C",
                    Price = 55M
                },
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-09-10"),
                    Genre = "Drama",
                    Rating = "A",
                    Price = 25M
                },
                new Movie
                {
                    Title = "Django Unchained",
                    ReleaseDate = DateTime.Parse("2012-12-11"),
                    Genre = " Revisionist Western",
                    Rating = "B",
                    Price = 100M
                }
            );
            context.SaveChanges();
        }
    }
}
