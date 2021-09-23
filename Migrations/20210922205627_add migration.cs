using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class addmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    Message = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 1, "Common tropes of the genre include explosions, car chases, fistfights and shootouts. This genre is closely associated with the thriller and adventure genres and may also contain elements of drama and spy fiction.[2] Screenwriter and scholar Eric R. Williams identifies Action Film as one of eleven super-genres struggling against incredible odds, which include life-threatening situations struggling against incredible odds, which include life-threatening situations", "FOREVER MORE", "8.jpg", new DateTime(1980, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "FLINT" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 2, "It’s largely a matter of opinion, but some titles are remembered long after the movie leaves theaters thanks to the way they roll off the tongue and stand out among all the other titles", "Patrik's movies", "no country.jpg", new DateTime(2017, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Country for old men" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 3, "Action film is a film genre in which the protagonist or protagonists are thrust into a series of events that typically include violence, extended fighting, physical feats, rescues and frantic chases. and scholar Eric R. Williams identifies Action Film as one of eleven super-genres", "HEY-YOU", "scaarface.jpg", new DateTime(1980, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SCARFACE SERIES" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 4, "rescues and frantic chases. Action films tend to feature a mostly resourceful hero struggling against incredible odds, which include life-threatening situations,a dangerous villain, or a pursuit which usually concludes in victory for the hero. Advancements in computer-generated imagery (CGI) have made it cheaper and easier to create", "HOLLY WOOD", "die hard.jpg", new DateTime(2002, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DIE HARD" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 5, "framed him as the archetypal hero of the urban action film. In many countries, restrictions on language, adult content, and violence had loosened up, and these elements became more widespread. In the 1970s, martial arts films", "BRIDAL SERIES", "6.jpg", new DateTime(2002, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRIDAL MASK" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 6, "Hollywood co-production, Bruce Lee's Enter the Dragon (1973). Lee's death the same year led to a wave of Bruceploitation films in Asian cinema, a trend that eventually came to an end with the success of several kung fu action-comedy films released in 1978: Jackie Chan's Snake in the Eagle's Shadow and Drunken Master, and Sammo Hung's Enter the Fat Dragon", "HEY-YOU", "OLD G.jpg", new DateTime(2011, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OLD GUARD" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 7, "Like the Western genre, spy-movies, as well as urban-action films, were starting to parody themselves, and with the growing revolution in CGI (computer generated imagery), the real-world settings began to give way to increasingly fantastic environments.This new era of action films often had budgets unlike any in the history of motion pictures.[24] The success of the many Dirty Harry and James Bond sequels had proven that a single successful action film could lead to a continuing action franchise. Thus, the 1980s and 1990s saw a rise in both budgets and the number of sequels a film could generally have.[25] This led to an increasing number of filmmakers to create new technologies that would allow them to beat the", "WOW FILMS", "4.jpg", new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "NO BODY IN THIS WORLD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
