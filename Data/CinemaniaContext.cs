using System;
using CineMania.Models;
using Microsoft.EntityFrameworkCore;

namespace CineMania.Data
{
    public class CinemaniaContext : DbContext
    {
        public CinemaniaContext(DbContextOptions<CinemaniaContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             var movies = new Movie[]
            {
                new Movie
                {
                    Id = 1,
                    Title = "FLINT",
                    Description = "Common tropes of the genre include explosions, car chases, fistfights and shootouts. " +
                                  "This genre is closely associated with the thriller and adventure genres and may also " +
                                  "contain elements of drama and spy fiction.[2] Screenwriter and scholar Eric R. Williams " +
                                  "identifies Action Film as one of eleven super-genres struggling against incredible odds, " +
                                  "which include life-threatening situations struggling against incredible odds, which " +
                                  "include life-threatening situations",
                    ImageName = "8.jpg",
                    Genre = "FOREVER MORE",
                    ReleaseDate = DateTime.Parse("1980-11-19")
                }, 
                new Movie
                {
                    Id = 2,
                    Title = "No Country for old men",
                    Description = "It’s largely a matter of opinion, but some titles are remembered long after the movie" +
                                  " leaves theaters thanks to the way they roll off the tongue and stand out among all " +
                                  "the other titles",
                    ImageName = "no country.jpg",
                    Genre = "Patrik's movies",
                    ReleaseDate = DateTime.Parse("2017-11-14")
                },  
                new Movie
                {
                    Id = 3,
                    Title = "SCARFACE SERIES",
                    Description = "Action film is a film genre in which the protagonist or protagonists are thrust into " +
                                  "a series of events that typically include violence, extended fighting, physical feats," +
                                  " rescues and frantic chases. and scholar Eric R. Williams " +
                                  "identifies Action Film as one of eleven super-genres",
                    ImageName = "scaarface.jpg",
                    Genre = "HEY-YOU",
                    ReleaseDate = DateTime.Parse("1980-09-01")
                },
                new Movie
                {
                    Id = 4,
                    Title = "DIE HARD",
                    Description = "rescues and frantic chases. Action films tend to feature a mostly resourceful hero " +
                                  "struggling against incredible odds, which include life-threatening situations," +
                                  "a dangerous villain, or a pursuit which usually concludes in victory for the hero. " +
                                  "Advancements in computer-generated imagery (CGI) have made it cheaper and easier to " +
                                  "create",
                    ImageName = "die hard.jpg",
                    Genre = "HOLLY WOOD",
                    ReleaseDate = DateTime.Parse("2002-12-01")
                },
               
                new Movie
                {
                    Id = 5,
                    Title = "BRIDAL MASK",
                    Description = "framed him as the archetypal hero of the urban action film. In many countries," +
                                  " restrictions on language, adult content, and violence had loosened up, and these" +
                                  " elements became more widespread. In the 1970s, martial arts films",
                    ImageName = "6.jpg",
                    Genre =  "BRIDAL SERIES",
                    ReleaseDate = DateTime.Parse("2002-06-20")
                },
                new Movie
                {
                    Id = 6,
                    Title = "OLD GUARD",
                    Description = "Hollywood co-production, Bruce Lee's Enter the Dragon (1973). Lee's death the same " +
                                  "year led to a wave of Bruceploitation films in Asian cinema, a trend that "+
                    "eventually came to an end with the success of several kung fu action-comedy films released in 1978:"
                    +" Jackie Chan's Snake in the Eagle's Shadow and Drunken Master, and Sammo Hung's Enter the Fat Dragon",
                    ImageName = "OLD G.jpg",
                    Genre =  "HEY-YOU",
                    ReleaseDate = DateTime.Parse("2011-06-29")
                }, 
                new Movie
                {
                    Id = 7,
                    Title = "NO BODY IN THIS WORLD",
                    Description = "Like the Western genre, spy-movies, as well as urban-action films, were starting to " +
                                  "parody themselves, and with the growing revolution in CGI (computer generated imagery)" +
                                  ", the real-world settings began to give way to increasingly fantastic environments." +
                                  "This new era of action films often had budgets unlike any in the history of motion" +
                                  " pictures.[24] The success of the many Dirty Harry and James Bond sequels had proven" +
                                  " that a single successful action film could lead to a continuing action franchise. " +
                                  "Thus, the 1980s and 1990s saw a rise in both budgets and the number of sequels a film " +
                                  "could generally have.[25] This led to an increasing number of filmmakers to create new " +
                                  "technologies that would allow them to beat the",
                    ImageName = "4.jpg",
                    Genre =  "WOW FILMS",
                    ReleaseDate = DateTime.Parse("2010-06-30")
                },
           
                
            };
          
            modelBuilder.Entity<Movie>().HasData(movies);
            base.OnModelCreating(modelBuilder);
        }
    }
}