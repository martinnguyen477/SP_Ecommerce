using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team27_BookshopWeb.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CartItems");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "CartItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Banner",
                table: "BannerSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "BannerSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Coupon",
                table: "BannerSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "BannerSettings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BannerSettings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "BannerSettings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A001",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A002",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A003",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A004",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A005",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A006",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A007",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A008",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A009",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A010",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A011",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A012",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A013",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A014",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A015",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A016",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A017",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A018",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A019",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A020",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A021",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A022",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A023",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A024",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A025",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A026",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A027",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A028",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A029",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A030",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A031",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A032",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A033",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A034",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A035",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A036",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A037",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A038",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A039",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A040",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A041",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A042",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A043",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A044",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A045",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A046",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A047",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A048",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A049",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A050",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S001",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S004",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S006",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S010",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S016",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S022",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S028",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S038",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S040",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S043",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S054",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 1,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 2,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 3,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 4,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 5,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 6,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 7,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 8,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 9,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 10,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 11,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 12,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 13,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 14,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 15,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 16,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 17,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 18,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 19,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 20,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 21,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 22,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 23,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 24,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 25,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 26,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 27,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 28,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 29,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 30,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 31,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 32,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 33,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 34,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 35,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 36,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 37,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 38,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 39,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 40,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 41,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 42,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 43,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 44,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 45,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 46,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 47,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 48,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 49,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 50,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 51,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 52,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 53,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 54,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 55,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 56,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 57,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "SGK-GT",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "VHNN",
                column: "DeletedAt",
                value: new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "BookId", "Content", "CreatedAt", "CustomerId", "Email", "Name", "UpdatedAt", "Vote" },
                values: new object[] { 2, "S040", "Sách có nội dung gây cảm hứng.", new DateTime(2020, 6, 19, 17, 35, 57, 0, DateTimeKind.Unspecified), null, "thuleanh@gmail.com", "Lê Anh Tthư", new DateTime(2020, 6, 19, 17, 35, 57, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MaxUses", "MaxUsesUser" },
                values: new object[] { 100, 1 });

            migrationBuilder.UpdateData(
                table: "EmployeeAuthorization",
                keyColumn: "EmployeeId",
                keyValue: "NV001",
                columns: new[] { "Delete", "Insert", "Update", "View" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "EmployeeAuthorization",
                keyColumn: "EmployeeId",
                keyValue: "NV002",
                column: "View",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EmployeeAuthorization",
                keyColumn: "EmployeeId",
                keyValue: "NV004",
                column: "View",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH001",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 712000.0, 712000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH002",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 152000.0, 152000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH003",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 206000.0, 206000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH004",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 598000.0, 598000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH005",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 607000.0, 607000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH006",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 821000.0, 821000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH007",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 127000.0, 127000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH008",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 111000.0, 111000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH009",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 268000.0, 268000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH010",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 90000.0, 90000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH011",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 90000.0, 90000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH012",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 136000.0, 136000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH013",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 186000.0, 186000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH014",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 354000.0, 354000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH015",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 265000.0, 265000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH016",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 138000.0, 138000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH017",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 59000.0, 59000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH018",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 338000.0, 338000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH019",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 134000.0, 134000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH020",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 150000.0, 150000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH021",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 242000.0, 242000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH022",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 216000.0, 216000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH023",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 219000.0, 219000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH024",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 94000.0, 94000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH025",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 115000.0, 115000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH026",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 60000.0, 60000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH027",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 124000.0, 124000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH028",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 200000.0, 200000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH029",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 119000.0, 119000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH030",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 337000.0, 337000.0 });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsSupported",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "Banner",
                table: "BannerSettings");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "BannerSettings");

            migrationBuilder.DropColumn(
                name: "Coupon",
                table: "BannerSettings");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "BannerSettings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BannerSettings");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "BannerSettings");

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A001",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A002",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A003",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A004",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A005",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A006",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A007",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A008",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A009",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A010",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A011",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A012",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A013",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A014",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A015",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A016",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A017",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A018",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A019",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A020",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A021",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A022",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A023",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A024",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A025",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A026",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A027",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A028",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A029",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A030",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A031",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A032",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A033",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A034",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A035",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A036",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A037",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A038",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A039",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A040",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A041",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A042",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A043",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A044",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A045",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A046",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A047",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A048",
                column: "Author",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A049",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuthorTranslator",
                keyColumn: "Id",
                keyValue: "A050",
                column: "Translator",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S001",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S004",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S006",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S010",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S016",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S022",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S028",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S038",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S040",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S043",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: "S054",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 1,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 2,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 3,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 4,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 5,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 6,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 7,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 8,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 9,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 10,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 11,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 12,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 13,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 14,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 15,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 16,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 17,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 18,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 19,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 20,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 21,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 22,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 23,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 24,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 25,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 26,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 27,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 28,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 29,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 30,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 31,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 32,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 33,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 34,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 35,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 36,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 37,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 38,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 39,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 40,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 41,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 42,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 43,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 44,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 45,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 46,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 47,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 48,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 49,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 50,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 51,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 52,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 53,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 54,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 55,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 56,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: 57,
                column: "Primary",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "SGK-GT",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "VHNN",
                column: "DeletedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MaxUses", "MaxUsesUser" },
                values: new object[] { 100, 1 });

            migrationBuilder.UpdateData(
                table: "EmployeeAuthorization",
                keyColumn: "EmployeeId",
                keyValue: "NV001",
                columns: new[] { "Delete", "Insert", "Update", "View" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "EmployeeAuthorization",
                keyColumn: "EmployeeId",
                keyValue: "NV002",
                column: "View",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EmployeeAuthorization",
                keyColumn: "EmployeeId",
                keyValue: "NV004",
                column: "View",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH001",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 712000.0, 712000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH002",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 152000.0, 152000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH003",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 206000.0, 206000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH004",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 598000.0, 598000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH005",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 607000.0, 607000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH006",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 821000.0, 821000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH007",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 127000.0, 127000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH008",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 111000.0, 111000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH009",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 268000.0, 268000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH010",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 90000.0, 90000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH011",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 90000.0, 90000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH012",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 136000.0, 136000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH013",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 186000.0, 186000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH014",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 354000.0, 354000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH015",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 265000.0, 265000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH016",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 138000.0, 138000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH017",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 59000.0, 59000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH018",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 338000.0, 338000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH019",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 134000.0, 134000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH020",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 150000.0, 150000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH021",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 242000.0, 242000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH022",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 216000.0, 216000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH023",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 219000.0, 219000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH024",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 94000.0, 94000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH025",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 115000.0, 115000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH026",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 60000.0, 60000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH027",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 124000.0, 124000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH028",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 200000.0, 200000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH029",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 119000.0, 119000.0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: "DH030",
                columns: new[] { "PaymentMethodId", "SubTotal", "Total" },
                values: new object[] { 1, 337000.0, 337000.0 });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsSupported",
                value: 1);
        }
    }
}
