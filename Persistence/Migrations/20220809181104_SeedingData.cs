using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "CZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "DE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "ES" });

            migrationBuilder.InsertData(
                table: "LineOfBusinesses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Retail" });

            migrationBuilder.InsertData(
                table: "LineOfBusinesses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Insurance" });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 1, 1, new DateTime(2008, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 2, 1, new DateTime(2010, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 120.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 3, 1, new DateTime(2012, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 110.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 4, 1, new DateTime(2008, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 5, 1, new DateTime(2010, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 20.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 6, 1, new DateTime(2012, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 7, 2, new DateTime(2008, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 150.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 8, 2, new DateTime(2010, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 220.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 9, 2, new DateTime(2012, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 210.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 10, 2, new DateTime(2008, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 11, 2, new DateTime(2010, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 22.5 });

            migrationBuilder.InsertData(
                table: "GrossWrittenPremia",
                columns: new[] { "Id", "CountryId", "DateTime", "LineOfBusinessId", "Value" },
                values: new object[] { 12, 2, new DateTime(2012, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 21.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GrossWrittenPremia",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LineOfBusinesses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LineOfBusinesses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
