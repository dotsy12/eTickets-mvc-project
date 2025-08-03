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
                    Logo = "https://www.google.com/imgres?q=AMC%20Empire%2025%20%20logo&imgurl=https%3A%2F%2Fs3-media0.fl.yelpcdn.com%2Fbphoto%2Fj5Amk5ET-M8rMpgBNuSX_A%2F348s.jpg&imgrefurl=https%3A%2F%2Fm.yelp.com%2Fbiz%2Famc-empire-25-new-york&docid=WZ3BxNv8K5lpPM&tbnid=QpyAiYx72dWWuM&vet=12ahUKEwjA-fvXyu6OAxXG2gIHHZ8PIMQQM3oECB0QAA..i&w=348&h=348&hcb=2&ved=2ahUKEwjA-fvXyu6OAxXG2gIHHZ8PIMQQM3oECB0QAA",
                    Description = "One of the busiest cinemas in Times Square, New York."
                },
                new Cinema()
                {
                    Name = "Regal Cinemas",
                    Logo = "https://www.google.com/imgres?q=Regal%20Cinemas%20logo&imgurl=https%3A%2F%2Flogosandtypes.com%2Fwp-content%2Fuploads%2F2021%2F04%2Fregal.svg&imgrefurl=https%3A%2F%2Flogosandtypes.com%2Falphabet%2Fletter-r%2Fregal%2F&docid=5tIkYittpdVNCM&tbnid=Nsw50LrWv8ULDM&vet=12ahUKEwjG_5fJyu6OAxXr3wIHHfSoJsIQM3oECCAQAA..i&w=800&h=800&hcb=2&ved=2ahUKEwjG_5fJyu6OAxXr3wIHHfSoJsIQM3oECCAQAA",
                    Description = "A popular American cinema chain."
                },
                new Cinema()
                {
                    Name = "Cineworld",
                    Logo = "https://www.google.com/imgres?q=cineworld%20star%20logo&imgurl=https%3A%2F%2Fcdn-ukwest.onetrust.com%2Flogos%2F5922c8a7-c44a-4864-9773-804dd97f3b15%2F59fa7c00-64ff-4d64-9a99-59477159194a%2Fd959167f-1fc9-4b4e-b911-b2192e10c78f%2FCINEWORLD_Star.png&imgrefurl=https%3A%2F%2Fwww.cineworld.ie%2F&docid=awkKQ1bUPjEIrM&tbnid=lFYeoLlfzy79hM&vet=12ahUKEwicvPnuyu6OAxX4-gIHHUhSOMYQM3oECBoQAA..i&w=1210&h=1103&hcb=2&itg=1&ved=2ahUKEwicvPnuyu6OAxX4-gIHHUhSOMYQM3oECBoQAA",
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
                    ProfilePictureURL = "https://www.google.com/imgres?q=leonardo%20dicaprio%20poster&imgurl=https%3A%2F%2Fi5.walmartimages.com%2Fseo%2FLeonardo-Dicaprio-as-Jack-Dawson-in-Titanic-smiling-portrait-24X36-Poster_7fc1661f-c4e8-4b93-b50a-f4ebeb893307.70ebc19a3dd075f8b54284a1d346b9db.jpeg&imgrefurl=https%3A%2F%2Fwww.ubuy.com.eg%2Fen%2Fproduct%2FFE3WNWLS-leonardo-dicaprio-as-jack-dawson-in-titanic-smiling-portrait-24x36-poster%3Fsrsltid%3DAfmBOopnSDizbv-P-LRY8c1GdhSmq7Ceke9XFfQ1EStt5hCMqIHSHiLq&docid=QlN91rSX71VlRM&tbnid=WBMnjVwZ5drHXM&vet=12ahUKEwjwt6rtye6OAxUf7gIHHRHXO8IQM3oECBsQAA..i&w=668&h=1000&hcb=2&ved=2ahUKEwjwt6rtye6OAxUf7gIHHRHXO8IQM3oECBsQAA"
                },
                new Actor()
                {
                    FullName = "Tom Hardy",
                    Bio = "English actor known for Inception, Mad Max: Fury Road, and The Dark Knight Rises.",
                    ProfilePictureURL = "https://www.google.com/imgres?q=Tom%20Hardy&imgurl=https%3A%2F%2Fhips.hearstapps.com%2Fhmg-prod%2Fimages%2F9th-annual-ves-awards---red-carpet.jpg%3Fresize%3D980%3A*&imgrefurl=https%3A%2F%2Fwww.biography.com%2Factors%2Ftom-hardy&docid=9YMo1pHqjG_B0M&tbnid=SU9dqJYenfQeDM&vet=12ahUKEwjK0J6Ay-6OAxVUwQIHHY5UH8QQM3oECBcQAA..i&w=402&h=402&hcb=2&ved=2ahUKEwjK0J6Ay-6OAxVUwQIHHY5UH8QQM3oECBcQAA"
                },
                new Actor()
                {
                    FullName = "Kate Winslet",
                    Bio = "British actress known for Titanic, The Reader, and Eternal Sunshine of the Spotless Mind.",
                    ProfilePictureURL = "https://www.google.com/imgres?q=Kate%20Winslet&imgurl=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BODgzMzM2NTE0Ml5BMl5BanBnXkFtZTcwMTcyMTkyOQ%40%40._V1_FMjpg_UX1000_.jpg&imgrefurl=https%3A%2F%2Fwww.imdb.com%2Fname%2Fnm0000701%2F&docid=byBEKgakMvweUM&tbnid=N7t6aAdx9SW-hM&vet=12ahUKEwjT_cqPy-6OAxXzQEEAHS_LIHkQM3oECBYQAA..i&w=1000&h=1535&hcb=2&ved=2ahUKEwjT_cqPy-6OAxXzQEEAHS_LIHkQM3oECBYQAA"
                },
                new Actor()
                {
                    FullName = "Christian Bale",
                    Bio = "English actor known for The Dark Knight trilogy and The Machinist.",
                    ProfilePictureURL = "https://www.google.com/imgres?q=Christian%20Bale&imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2F0%2F0d%2FChristian_Bale_2009.jpg%2F1200px-Christian_Bale_2009.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FChristian_Bale_filmography&docid=QfLO0_V6l3zsJM&tbnid=t7aZZVTG3cim3M&vet=12ahUKEwjlrKuby-6OAxWLXEEAHYfHGKgQM3oECB0QAA..i&w=1200&h=1664&hcb=2&ved=2ahUKEwjlrKuby-6OAxWLXEEAHYfHGKgQM3oECB0QAA"
                },
                new Actor()
                {
                    FullName = "Ellen Page (Elliot Page)",
                    Bio = "Actor known for Juno, Inception, and The Umbrella Academy.",
                    ProfilePictureURL = "https://www.google.com/imgres?q=Ellen%20Page%20(Elliot%20Page)&imgurl=https%3A%2F%2Fcdn.britannica.com%2F41%2F249341-050-E5F7039C%2FActor-Elliot-Page-2022.jpg&imgrefurl=https%3A%2F%2Fwww.britannica.com%2Fbiography%2FElliot-Page&docid=G-CUlrZPUs1q9M&tbnid=Bp7GqNpLCKkT1M&vet=12ahUKEwicoaGny-6OAxUQwAIHHd6JEsMQM3oECBcQAA..i&w=1320&h=1600&hcb=2&ved=2ahUKEwicoaGny-6OAxUQwAIHHd6JEsMQM3oECBcQAA"
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
                    ProfilePictureURL = "https://www.google.com/imgres?q=Christopher%20Nolan%20&imgurl=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw%40%40._V1_.jpg&imgrefurl=https%3A%2F%2Fwww.imdb.com%2Fname%2Fnm0634240%2F&docid=s4pxzn_FhjQ6tM&tbnid=qT1gyzAUsTxJ3M&vet=12ahUKEwii5da1y-6OAxVrS0EAHXcdCbgQM3oECB0QAA..i&w=289&h=400&hcb=2&ved=2ahUKEwii5da1y-6OAxVrS0EAHXcdCbgQM3oECB0QAA"
                },
                new Producer()
                {
                    FullName = "James Cameron",
                    Bio = "Canadian filmmaker known for Titanic, Avatar, and Terminator.",
                    ProfilePictureURL = "https://www.google.com/imgres?q=James%20Cameron&imgurl=https%3A%2F%2Fcdn.britannica.com%2F84%2F160284-050-695B1DE3%2FJames-Cameron-2012.jpg&imgrefurl=https%3A%2F%2Fwww.britannica.com%2Fbiography%2FJames-Cameron&docid=U0tue32rttz3RM&tbnid=8J6cPOiGr58quM&vet=12ahUKEwj369_Ay-6OAxXH2AIHHZEGJ7gQM3oECBwQAA..i&w=533&h=800&hcb=2&ved=2ahUKEwj369_Ay-6OAxXH2AIHHZEGJ7gQM3oECBwQAA"
                },
                new Producer()
                {
                    FullName = "Emma Thomas",
                    Bio = "Film producer and wife of Christopher Nolan; co-produced many of his works.",
                    ProfilePictureURL = "https://www.google.com/imgres?q=emma%20thomas&imgurl=https%3A%2F%2Fvariety.com%2Fwp-content%2Fuploads%2F2024%2F01%2FEmma-Thomas-Variety-Awards-Season-Extra-Edition.jpg%3Fw%3D1200%26h%3D1500%26crop%3D1&imgrefurl=https%3A%2F%2Fvariety.com%2F2024%2Fawards%2Factors%2Foppenheimer-producer-emma-thomas-misconceptions-about-christopher-nolan-risks-for-film-1235860273%2F&docid=jhmiVhgGqhefXM&tbnid=W61v9VENNcdRkM&vet=12ahUKEwjfwbrMy-6OAxUx3gIHHepwDsIQM3oECCAQAA..i&w=1200&h=1500&hcb=2&ved=2ahUKEwjfwbrMy-6OAxUx3gIHHepwDsIQM3oECCAQAA"
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
                    ImgUrl = "https://www.google.com/imgres?q=inception&imgurl=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw%40%40._V1_.jpg&imgrefurl=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt1375666%2F&docid=xTQ-svvkUc9QrM&tbnid=1TOdeJolztMdvM&vet=12ahUKEwi1odDYy-6OAxXO3QIHHTIlO8MQM3oECBkQAA..i&w=700&h=1037&hcb=2&ved=2ahUKEwi1odDYy-6OAxXO3QIHHTIlO8MQM3oECBkQAA",
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
                    ImgUrl = "https://www.google.com/imgres?q=Titanic%20&imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2F1%2F18%2FTitanic_%25281997_film%2529_poster.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FTitanic_(1997_film)&docid=G7LQO8vzrOGtmM&tbnid=arNKtwHsGVc5vM&vet=12ahUKEwiSnJzjy-6OAxX7TP4FHXquJ9sQM3oECB4QAA..i&w=220&h=326&hcb=2&ved=2ahUKEwiSnJzjy-6OAxX7TP4FHXquJ9sQM3oECB4QAA",
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
                    ImgUrl = "https://www.google.com/imgres?q=the%20dark%20knight&imgurl=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw%40%40._V1_FMjpg_UX1000_.jpg&imgrefurl=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt0468569%2F&docid=0rn7TgyQKdwNuM&tbnid=y0pjr3h928UKXM&vet=12ahUKEwj98Orsy-6OAxV-1gIHHYX6MuQQM3oECBkQAA..i&w=1000&h=1481&hcb=2&ved=2ahUKEwj98Orsy-6OAxV-1gIHHYX6MuQQM3oECBkQAA",
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
