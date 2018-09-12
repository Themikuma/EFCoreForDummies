using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreForDummies.Migrations
{
    public partial class RecipesSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Hops",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Malt",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Water",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Yeast",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Yield",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Brewers",
                columns: new[] { "Id", "FavouriteBeerType", "FirstName", "LastName", "Upkeep" },
                values: new object[,]
                {
                    { 1, 2, "Georgi", "Dimitrov", 8 },
                    { 2, 1, "Velio", "Ivanov", 3 },
                    { 3, 3, "Krasimir", "Kostadinov", 5 },
                    { 4, 2, "Vladislav", "Konovski", 4 },
                    { 5, 1, "Ivan", "Stefanov", 2 },
                    { 6, 1, "Boris", "Penev", 6 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Hops", "Malt", "Name", "Type", "Water", "Yeast", "Yield" },
                values: new object[,]
                {
                    { 1, 180, 12, "Big Amber", 3, 82, 40, 60 },
                    { 2, 140, 8, "Medium Amber", 3, 56, 25, 40 },
                    { 3, 80, 6, "Small Weiss", 2, 50, 20, 34 },
                    { 4, 160, 12, "Big Weiss", 2, 100, 45, 68 },
                    { 5, 120, 8, "Medium Lager", 1, 56, 30, 36 },
                    { 6, 90, 6, "Small Lager", 1, 42, 20, 26 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brewers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brewers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brewers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brewers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brewers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brewers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Hops",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Malt",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Water",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Yeast",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Yield",
                table: "Recipes");
        }
    }
}
