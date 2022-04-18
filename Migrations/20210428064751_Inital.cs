using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesListed.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    ListsID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    mTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.ListsID);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Runtime = table.Column<double>(type: "float", nullable: false),
                    ListsID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movie_Lists_ListsID",
                        column: x => x.ListsID,
                        principalTable: "Lists",
                        principalColumn: "ListsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lists",
                columns: new[] { "ListsID", "mTitle" },
                values: new object[,]
                {
                    { "A", "Action" },
                    { "C", "Crime" },
                    { "D", "Drama" },
                    { "H", "Horror" },
                    { "CO", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieId", "Actors", "Description", "ListsID", "Rating", "Runtime", "Title", "Year" },
                values: new object[,]
                {
                    { 3, "Bruce Allpress, Sean Astin, John Bach, Sala Baker, Cate Blanchett, etc", "Frodo and Sam (Sean Astin) discover they are being followed by the mysterious Gollum. Aragorn (Viggo Mortensen), the Elf archer Legolas and Gimli the Dwarf encounter the besieged Rohan kingdom, whose once great King Theoden has fallen under Saruman's deadly spell.", "A", 13.0, 3.4300000000000002, "The Lord of the Rings: The Two Towers", 2002 },
                    { 2, "Tom Hanks, Tim Allen, Annie Potts, Tony Hale, Keegan-Michael Key, etc", "Woody, Buzz Lightyear and the rest of the gang embark on a road trip with Bonnie and a new toy named Forky. The adventurous journey turns into an unexpected reunion as Woody's slight detour leads him to his long-lost friend Bo Peep. As Woody and Bo discuss the old days, they soon start to realize that they're worlds apart when it comes to what they want from life as a toy.", "C", 4.5, 1.3999999999999999, "Toy Story 4", 2019 },
                    { 1, "Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler, Clancy Brown, etc", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "D", 9.1999999999999993, 3.2200000000000002, " The Shawshank Redemption", 1994 },
                    { 5, "Tom Hanks, Tom Sizemore, Edward Burns, Barry Pepper, Adam Goldberg, etc", "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.", "D", 8.5999999999999996, 2.4900000000000002, "Saving Private Ryan", 1998 },
                    { 4, "Gregory Peck, John Megna, Frank Overton, Rosemary Murphy, Ruth White, etc", "Atticus Finch, a lawyer in the Depression-era South, defends a black man against an undeserved rape charge, and his children against prejudice.", "D", 8.1999999999999993, 2.0899999999999999, "To Kill a Mockingbird", 1962 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ListsID",
                table: "Movie",
                column: "ListsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Lists");
        }
    }
}
