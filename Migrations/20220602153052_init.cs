using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Author_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Author_ID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Genre_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Genre_Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Genre_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    User_Name = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Book_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Genre_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    Language = table.Column<string>(type: "TEXT", nullable: false),
                    Author_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Format = table.Column<int>(type: "INTEGER", nullable: false),
                    User_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    User_ID1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Book_ID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_Author_ID",
                        column: x => x.Author_ID,
                        principalTable: "Authors",
                        principalColumn: "Author_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_Genre_ID",
                        column: x => x.Genre_ID,
                        principalTable: "Genres",
                        principalColumn: "Genre_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Users_User_ID1",
                        column: x => x.User_ID1,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Review_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddedByUser_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Book_ID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Review_ID);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_Book_ID",
                        column: x => x.Book_ID,
                        principalTable: "Books",
                        principalColumn: "Book_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_AddedByUser_ID",
                        column: x => x.AddedByUser_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Author_ID",
                table: "Books",
                column: "Author_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Genre_ID",
                table: "Books",
                column: "Genre_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_User_ID",
                table: "Books",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_User_ID1",
                table: "Books",
                column: "User_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AddedByUser_ID",
                table: "Reviews",
                column: "AddedByUser_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Book_ID",
                table: "Reviews",
                column: "Book_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
