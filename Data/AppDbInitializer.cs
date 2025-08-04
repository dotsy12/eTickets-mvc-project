using eTickets.Data.Enums;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                // Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
            {
                new Cinema()
                {
                    Name = "AMC Empire 25",
                    Logo = "img/Cinemas/images.jpeg",
                    Description = "One of the busiest cinemas in Times Square, New York."
                },
                new Cinema()
                {
                    Name = "Regal Cinemas",
                    Logo = "img/Cinemas/r.png",
                    Description = "A popular American cinema chain."
                },
                new Cinema()
                {
                    Name = "Cineworld",
                    Logo = "img/Cinemas/CINEWORLD_Star.png",
                    Description = "Leading UK cinema brand offering the latest blockbusters."
                }
            });
                    context.SaveChanges();
                }

                // Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
            {
                new Actor()
                {
                    FullName = "Leonardo DiCaprio",
                    Bio = "American actor and producer known for his roles in Titanic, Inception, and The Revenant.",
                    ProfilePictureURL = "img/Actors/Leonardo DiCaprio.jpeg"
                },
                new Actor()
                {
                    FullName = "Tom Hardy",
                    Bio = "English actor known for Inception, Mad Max: Fury Road, and The Dark Knight Rises.",
                    ProfilePictureURL = "img/Actors/tom.jpeg"
                },
                new Actor()
                {
                    FullName = "Kate Winslet",
                    Bio = "British actress known for Titanic, The Reader, and Eternal Sunshine of the Spotless Mind.",
                    ProfilePictureURL = "img/Actors/Kate Winslet.jpeg"
                },
                new Actor()
                {
                    FullName = "Christian Bale",
                    Bio = "English actor known for The Dark Knight trilogy and The Machinist.",
                    ProfilePictureURL = "img/Actors/Christian.jpg"
                },
                new Actor()
                {
                    FullName = "Ellen Page",
                    Bio = "Actor known for Juno, Inception, and The Umbrella Academy.",
                    ProfilePictureURL = "img/Actors/Elliot-Page.jpeg"
                }
            });
                    context.SaveChanges();
                }

                // Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
            {
                new Producer()
                {
                    FullName = "Christopher Nolan",
                    Bio = "Director and producer known for Inception, Interstellar, and The Dark Knight trilogy.",
                    ProfilePictureURL = "img/Producers/Christopher Nolan.jpg"
                },
                new Producer()
                {
                    FullName = "James Cameron",
                    Bio = "Canadian filmmaker known for Titanic, Avatar, and Terminator.",
                    ProfilePictureURL = "img/Producers/James Cameron.jpeg" }
                ,
                new Producer()
                {
                    FullName = "Emma Thomas",
                    Bio = "Film producer and wife of Christopher Nolan; co-produced many of his works.",
                    ProfilePictureURL = "img/Producers/Emma Thomas.jpeg"
                }
            });
                    context.SaveChanges();
                }

                // Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
            {
                new Movie()
                {
                    Name = "Inception",
                    Description = "A thief who steals corporate secrets through dream-sharing technology is given an inverse task: plant an idea.",
                    Price = 49.99,
                    ImgUrl = "img/Movies/Inception.jpeg",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(10),
                    CinemaId = 1,
                    ProducerId = 1,
                    MovieCategory = MovieCategory.Action
                },
                new Movie()
                {
                    Name = "Titanic",
                    Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious Titanic.",
                    Price = 39.99,
                    ImgUrl = "img/Movies/Titanic.jpeg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(5),
                    CinemaId = 2,
                    ProducerId = 2,
                    MovieCategory = MovieCategory.Drama
                },
                new Movie()
                {
                    Name = "The Dark Knight",
                    Description = "When the menace known as the Joker emerges, Batman must accept one of the greatest psychological and physical tests.",
                    Price = 44.99,
                    ImgUrl = "img/Movies/The Dark Knight.jpeg",
                    StartDate = DateTime.Now.AddDays(-5),
                    EndDate = DateTime.Now.AddDays(10),
                    CinemaId = 3,
                    ProducerId = 1,
                    MovieCategory = MovieCategory.Action
                }
            });
                    context.SaveChanges();
                }

                // Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
            {
                new Actor_Movie() { ActorId = 1, MovieId = 1 }, // Leonardo DiCaprio - Inception
                new Actor_Movie() { ActorId = 2, MovieId = 1 }, // Tom Hardy - Inception
                new Actor_Movie() { ActorId = 5, MovieId = 1 }, // Ellen Page - Inception

                new Actor_Movie() { ActorId = 1, MovieId = 2 }, // Leonardo DiCaprio - Titanic
                new Actor_Movie() { ActorId = 3, MovieId = 2 }, // Kate Winslet - Titanic

                new Actor_Movie() { ActorId = 4, MovieId = 3 }, // Christian Bale - The Dark Knight
                new Actor_Movie() { ActorId = 2, MovieId = 3 }, // Tom Hardy - The Dark Knight
            });
                    context.SaveChanges();
                }
            }
        }

    }
}
