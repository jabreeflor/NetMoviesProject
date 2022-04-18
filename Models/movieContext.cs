using Microsoft.EntityFrameworkCore;

namespace MoviesListed.Models
{
    public class movieContext : DbContext
    {

        public movieContext(DbContextOptions<movieContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Lists> Lists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(

                new Movie
                {
                    MovieId = 1,
                    Title = " The Shawshank Redemption",
                    Rating = 9.2,
                    Year = 1994,
                    ListsID = "D",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Runtime = 3.22,
                    Actors = "Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler, Clancy Brown, etc"

                },
                new Movie
                {
                    MovieId = 5,
                    Title = "Saving Private Ryan",
                    Rating = 8.6,
                    Year = 1998,
                    ListsID = "D",
                    Description = "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.",
                    Runtime = 2.49,
                    Actors = "Tom Hanks, Tom Sizemore, Edward Burns, Barry Pepper, Adam Goldberg, etc"

                },
                    new Movie
                    {
                        MovieId = 4,
                        Title = "To Kill a Mockingbird",
                        Rating = 8.2,
                        Year = 1962,
                        ListsID = "D",
                        Description = "Atticus Finch, a lawyer in the Depression-era South, defends a black man against an undeserved rape charge, and his children against prejudice.",
                        Runtime = 2.09,
                        Actors = "Gregory Peck, John Megna, Frank Overton, Rosemary Murphy, Ruth White, etc"

                    },
                new Movie
                {
                    MovieId = 2,
                    Title = "Toy Story 4",
                    Rating = 4.5,
                    Year = 2019,
                    ListsID = "C",
                    Description = "Woody, Buzz Lightyear and the rest of the gang embark on a road trip with Bonnie and a new toy named Forky. The adventurous journey turns into an unexpected reunion as Woody's slight detour leads him to his long-lost friend Bo Peep. As Woody and Bo discuss the old days, they soon start to realize that they're worlds apart when it comes to what they want from life as a toy.",
                    Runtime = 1.40,
                    Actors = "Tom Hanks, Tim Allen, Annie Potts, Tony Hale, Keegan-Michael Key, etc"
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "The Lord of the Rings: The Two Towers",
                    Rating = 13,
                    Year = 2002,
                    ListsID = "A",
                    Description = "Frodo and Sam (Sean Astin) discover they are being followed by the mysterious Gollum. Aragorn (Viggo Mortensen), the Elf archer Legolas and Gimli the Dwarf encounter the besieged Rohan kingdom, whose once great King Theoden has fallen under Saruman's deadly spell.",
                    Runtime = 3.43,
                    Actors = "Bruce Allpress, Sean Astin, John Bach, Sala Baker, Cate Blanchett, etc"

                }
            );

            modelBuilder.Entity<Lists>().HasData(

                      new Lists
                      {
                          ListsID = "A",
                          mTitle = "Action"

                      },
                      new Lists
                      {
                          ListsID = "C",
                          mTitle = "Crime"

                      },

                      new Lists
                      {
                          ListsID = "D",
                          mTitle = "Drama"

                      },

                      new Lists
                      {
                          ListsID = "H",
                          mTitle = "Horror"

                      },
                        new Lists
                        {
                            ListsID = "CO",
                            mTitle = "Comedy"

                        }

                      );

        }
    }
}