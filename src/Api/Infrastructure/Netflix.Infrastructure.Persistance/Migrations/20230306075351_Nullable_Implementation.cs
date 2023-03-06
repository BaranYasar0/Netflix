using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netflix.Infrastructure.Persistance.Migrations
{
    public partial class Nullable_Implementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "MovieLength",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "MovieLength",
                table: "Movie",
                type: "time",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "CreatedDate", "Description", "MovieLength", "MovieName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 19, 21, 53, 32, 88, DateTimeKind.Local).AddTicks(939), "Kutusu laudantium gitti.\nVoluptas sıla architecto modi.", new TimeSpan(62358785600), "Handcrafted Steel Table", null },
                    { 2, new DateTime(2023, 1, 19, 17, 30, 53, 144, DateTimeKind.Local).AddTicks(4449), "Sıfat non karşıdakine.", new TimeSpan(75345109291), "Small Soft Chips", null },
                    { 3, new DateTime(2023, 1, 15, 15, 24, 46, 352, DateTimeKind.Local).AddTicks(9448), "Autem reprehenderit voluptatum illo ullam.\nPerferendis batarya architecto dolore.\nAçılmadan magnam quia sokaklarda deleniti odit gördüm.\nÖyle kalemi makinesi.", new TimeSpan(55241824700), "Incredible Soft Computer", null },
                    { 4, new DateTime(2023, 1, 30, 14, 22, 14, 667, DateTimeKind.Local).AddTicks(8550), "Patlıcan sandalye gül beatae.\nGülüyorum aliquid veniam.\nAut koyun et açılmadan göze autem reprehenderit corporis mi.\nQuasi qui gidecekmiş koşuyorlar yazın.\nDolores aliquid orta gazete velit labore ratione modi vel değirmeni.\nAnlamsız ducimus corporis molestiae laudantium oldular adresini consequatur teldeki ut.", new TimeSpan(39685700185), "Sleek Granite Soap", null },
                    { 5, new DateTime(2022, 12, 8, 10, 16, 44, 386, DateTimeKind.Local).AddTicks(8195), "Değerli voluptatum ullam quia cezbelendi dolor adipisci ut orta dicta. Adanaya amet çarpan mi oldular gidecekmiş ipsa. Mıknatıslı ex layıkıyla quia yapacakmış quam layıkıyla quia. Mıknatıslı değirmeni lakin bundan ışık öyle eos ötekinden consequuntur quis.", new TimeSpan(25827757828), "Awesome Cotton Shirt", null },
                    { 6, new DateTime(2023, 2, 28, 22, 46, 43, 517, DateTimeKind.Local).AddTicks(184), "Koşuyorlar şafak numquam.\nMakinesi koşuyorlar orta amet enim filmini voluptatem iure dağılımı.\nGördüm quia voluptatem gördüm gül ratione consectetur perferendis sokaklarda.\nMinima labore qui ki teldeki quia.", new TimeSpan(83610452954), "Incredible Metal Shirt", null },
                    { 7, new DateTime(2023, 2, 5, 3, 11, 36, 281, DateTimeKind.Local).AddTicks(8887), "Anlamsız ötekinden yapacakmış velit.", new TimeSpan(59675471519), "Generic Granite Pants", null },
                    { 8, new DateTime(2023, 2, 26, 14, 6, 16, 824, DateTimeKind.Local).AddTicks(330), "Ötekinden umut esse ipsam. Anlamsız nostrum koştum corporis. Nemo çarpan praesentium consequatur lakin gülüyorum explicabo quia. Sevindi ut makinesi değerli sıradanlıktan sarmal voluptatem çorba sokaklarda. Enim layıkıyla laudantium deleniti sunt. Ducimus dolorem çakıl dolores corporis et.", new TimeSpan(95283904170), "Licensed Steel Chips", null },
                    { 9, new DateTime(2023, 1, 9, 2, 47, 34, 279, DateTimeKind.Local).AddTicks(5550), "Yaptı eaque enim ekşili karşıdakine veritatis.", new TimeSpan(42906769589), "Incredible Plastic Car", null },
                    { 10, new DateTime(2023, 1, 7, 9, 35, 55, 237, DateTimeKind.Local).AddTicks(8069), "magnam", new TimeSpan(77929060083), "Rustic Metal Bike", null }
                });
        }
    }
}
