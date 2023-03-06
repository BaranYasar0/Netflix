using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netflix.Infrastructure.Persistance.Migrations
{
    public partial class Try_Bogus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieComment_Movie_MovieId",
                table: "MovieComment");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCommentVote_MovieComment_MovieCommentId",
                table: "MovieCommentVote");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieFavourite_Movie_MovieId",
                table: "MovieFavourite");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieVote_Movie_MovieId",
                table: "MovieVote");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "E-ContactNumber", "CreatedDate", "E-mail", "E-FirstName", "E-LastName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "+90-702-210-4-186", new DateTime(2022, 11, 28, 8, 6, 22, 436, DateTimeKind.Local).AddTicks(242), "Barkan_Avan@yahoo.com", "Amelya", "Arıcan", null },
                    { 2, "+90-440-015-65-75", new DateTime(2023, 2, 21, 12, 36, 49, 821, DateTimeKind.Local).AddTicks(5682), "Bukak0@yahoo.com", "Okan", "Yıldırım ", null },
                    { 3, "+90-227-944-24-78", new DateTime(2022, 11, 30, 0, 33, 6, 370, DateTimeKind.Local).AddTicks(1887), "Akkun88@gmail.com", "Gazanfer", "Bademci", null },
                    { 4, "+90-182-015-2-303", new DateTime(2023, 1, 19, 21, 44, 3, 495, DateTimeKind.Local).AddTicks(7334), "Bugduz_Kuzucu@hotmail.com", "Hayat", "Kuzucu", null },
                    { 5, "+90-275-546-3-635", new DateTime(2023, 2, 21, 4, 18, 8, 271, DateTimeKind.Local).AddTicks(4571), "Isig27@gmail.com", "Aykut", "Demirel", null },
                    { 6, "+90-268-485-3-013", new DateTime(2022, 12, 17, 21, 49, 38, 717, DateTimeKind.Local).AddTicks(9046), "Cilenti49@yahoo.com", "Barış", "Denkel", null },
                    { 7, "+90-773-373-9-468", new DateTime(2023, 1, 12, 17, 45, 35, 896, DateTimeKind.Local).AddTicks(4638), "Arpat21@hotmail.com", "Gaffar", "Alyanak", null },
                    { 8, "+90-777-999-5-191", new DateTime(2022, 12, 23, 10, 5, 53, 138, DateTimeKind.Local).AddTicks(430), "Adaldi.Cetin12@gmail.com", "Hazan", "Koç", null },
                    { 9, "+90-773-019-73-39", new DateTime(2023, 2, 13, 3, 36, 45, 368, DateTimeKind.Local).AddTicks(2560), "Alpilig_Daglaroglu@gmail.com", "Demirhan", "Nebioğlu", null },
                    { 10, "+90-682-807-4-838", new DateTime(2022, 11, 28, 2, 57, 50, 670, DateTimeKind.Local).AddTicks(968), "Bastugrul.Yalcin26@yahoo.com", "Selen", "Tokgöz", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieComment_Movie_MovieId",
                table: "MovieComment",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCommentVote_MovieComment_MovieCommentId",
                table: "MovieCommentVote",
                column: "MovieCommentId",
                principalTable: "MovieComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieFavourite_Movie_MovieId",
                table: "MovieFavourite",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieVote_Movie_MovieId",
                table: "MovieVote",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieComment_Movie_MovieId",
                table: "MovieComment");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCommentVote_MovieComment_MovieCommentId",
                table: "MovieCommentVote");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieFavourite_Movie_MovieId",
                table: "MovieFavourite");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieVote_Movie_MovieId",
                table: "MovieVote");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieComment_Movie_MovieId",
                table: "MovieComment",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCommentVote_MovieComment_MovieCommentId",
                table: "MovieCommentVote",
                column: "MovieCommentId",
                principalTable: "MovieComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieFavourite_Movie_MovieId",
                table: "MovieFavourite",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieVote_Movie_MovieId",
                table: "MovieVote",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
