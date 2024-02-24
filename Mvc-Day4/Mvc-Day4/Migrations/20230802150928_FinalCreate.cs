using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mvc_Day4.Migrations
{
    /// <inheritdoc />
    public partial class FinalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "874c34bd-ed21-43da-8880-40fdfbd146d9", "226f9379-7a36-4df6-a98d-260651b353d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9555489f-04b3-4aa8-b33e-d603c5f3b93c", "54f08fb7-34c9-4c56-af7b-8895b76c16d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94a4da16-d0cd-47e2-86f3-2e500fd55e4e", "ba9e9743-a482-4ee0-8997-e4dfe0765f94" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6079f57f-a875-4257-81e0-d3540518482c", "bccdb075-ea49-45d2-8b21-13c8172fe1cf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6079f57f-a875-4257-81e0-d3540518482c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "874c34bd-ed21-43da-8880-40fdfbd146d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a4da16-d0cd-47e2-86f3-2e500fd55e4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9555489f-04b3-4aa8-b33e-d603c5f3b93c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "226f9379-7a36-4df6-a98d-260651b353d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54f08fb7-34c9-4c56-af7b-8895b76c16d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba9e9743-a482-4ee0-8997-e4dfe0765f94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bccdb075-ea49-45d2-8b21-13c8172fe1cf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "248619e4-e233-437e-ace7-a8a700284b3c", null, "IdentityRole", "Manager", "MANAGER" },
                    { "8469d2da-3154-4585-ac24-16ae3f0bb915", null, "IdentityRole", "Adminstration", "ADMINSTRATION" },
                    { "8ab6a84e-5b7c-4ac0-ba62-8994269eea92", null, "IdentityRole", "User", "USER" },
                    { "c630e5e8-ded0-4b93-9903-b4b05a644287", null, "IdentityRole", "Med-Manager", "MED-MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a9ca5b6-727b-4b78-be3c-5e852cf1e08e", 0, 20, "451422ad-2ce0-45ed-8828-ba537477f514", "Mona.Mohamed@gmail.com", true, "Mona", "Mohamed", false, null, "MONA.MOHAMED@GMAIL.COM", "MONA.MOHAMED@GMAIL.COM", "AQAAAAIAAYagAAAAEHK1P98hMifpQk5ZVyNP4YWIQmn5Hhyu6I4HAUXJg5/pD4KBpxiayZMwuHizd1FbSg==", "01095556724", true, "848ee81a-e6ec-4a47-b757-daaf6f95cbda", true, "Mona.Mohamed@gmail.com" },
                    { "42b40f47-a696-4ef8-829e-1a24159d6b1c", 0, 22, "b523be64-bc2a-4f07-8666-706b6b4d4205", "Mohamed.Ahmed@gmail.com", true, "Mohamed", "Ahmed", false, null, "MOHAMED.AHMED@GMAIL.COM", "MOHAMED.AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAEDhvhq+HSlQxHuYzmRo7SkDJ580klU3AhPp4S+k/qJFKOV39119Q4YHbupRPijzTUA==", "01094456724", true, "d81b0f03-a733-4305-87bc-408a24a6e439", true, "Mohamed.Ahmed@gmail.com" },
                    { "b87885d8-1a74-4a82-806c-4e7befcd576d", 0, 20, "b4016cba-75ba-4a5d-8b1c-1f8a84a642a1", "Ali.Ahmed@gmail.com", true, "Ali", "Ahmed", false, null, "ALI.AHMED@GMAIL.COM", "ALI.AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAEHup6uwEYSaYVmYFo73NntLlRymlruN8gOCO/Q1LjI5EIaWEvwWq4f0aBMefojBqTQ==", "01194456724", true, "f3e647e1-9957-4a8e-ac1d-c1c8db4df54d", true, "Ali.Ahmed@gmail.com" },
                    { "cb9f8cf3-f12f-410a-a39c-d75c34cdb103", 0, 21, "02b90775-554f-40b2-9796-baa9c59eb164", "Alaa.Mohamed@gmail.com", true, "Alaa", "Mohamed", false, null, "ALAA.MOHAMED@GMAIL.COM", "ALAA.MOHAMED@GMAIL.COM", "AQAAAAIAAYagAAAAEDDP1y914e/Nb+M8Dk976pd3OxFUrwXN+eo0gKxmIlKPVzPWScBz0SodQrSFiYcOJA==", "01294456724", true, "6e6294e6-21d0-4ced-b9e4-fa1680c28eef", true, "Alaa.Mohamed@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c630e5e8-ded0-4b93-9903-b4b05a644287", "0a9ca5b6-727b-4b78-be3c-5e852cf1e08e" },
                    { "248619e4-e233-437e-ace7-a8a700284b3c", "42b40f47-a696-4ef8-829e-1a24159d6b1c" },
                    { "8469d2da-3154-4585-ac24-16ae3f0bb915", "42b40f47-a696-4ef8-829e-1a24159d6b1c" },
                    { "8ab6a84e-5b7c-4ac0-ba62-8994269eea92", "42b40f47-a696-4ef8-829e-1a24159d6b1c" },
                    { "c630e5e8-ded0-4b93-9903-b4b05a644287", "42b40f47-a696-4ef8-829e-1a24159d6b1c" },
                    { "248619e4-e233-437e-ace7-a8a700284b3c", "b87885d8-1a74-4a82-806c-4e7befcd576d" },
                    { "8ab6a84e-5b7c-4ac0-ba62-8994269eea92", "cb9f8cf3-f12f-410a-a39c-d75c34cdb103" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c630e5e8-ded0-4b93-9903-b4b05a644287", "0a9ca5b6-727b-4b78-be3c-5e852cf1e08e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "248619e4-e233-437e-ace7-a8a700284b3c", "42b40f47-a696-4ef8-829e-1a24159d6b1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8469d2da-3154-4585-ac24-16ae3f0bb915", "42b40f47-a696-4ef8-829e-1a24159d6b1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ab6a84e-5b7c-4ac0-ba62-8994269eea92", "42b40f47-a696-4ef8-829e-1a24159d6b1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c630e5e8-ded0-4b93-9903-b4b05a644287", "42b40f47-a696-4ef8-829e-1a24159d6b1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "248619e4-e233-437e-ace7-a8a700284b3c", "b87885d8-1a74-4a82-806c-4e7befcd576d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ab6a84e-5b7c-4ac0-ba62-8994269eea92", "cb9f8cf3-f12f-410a-a39c-d75c34cdb103" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "248619e4-e233-437e-ace7-a8a700284b3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8469d2da-3154-4585-ac24-16ae3f0bb915");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ab6a84e-5b7c-4ac0-ba62-8994269eea92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c630e5e8-ded0-4b93-9903-b4b05a644287");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9ca5b6-727b-4b78-be3c-5e852cf1e08e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42b40f47-a696-4ef8-829e-1a24159d6b1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b87885d8-1a74-4a82-806c-4e7befcd576d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb9f8cf3-f12f-410a-a39c-d75c34cdb103");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6079f57f-a875-4257-81e0-d3540518482c", null, "IdentityRole", "Manager", "MANAGER" },
                    { "874c34bd-ed21-43da-8880-40fdfbd146d9", null, "IdentityRole", "Adminstration", "ADMINSTRATION" },
                    { "94a4da16-d0cd-47e2-86f3-2e500fd55e4e", null, "IdentityRole", "User", "USER" },
                    { "9555489f-04b3-4aa8-b33e-d603c5f3b93c", null, "IdentityRole", "Med-Manager", "MED-MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "226f9379-7a36-4df6-a98d-260651b353d2", 0, 22, "82cd0cff-9303-4b94-905f-bc6f411fa684", "Mohamed.Ahmed@gmail.com", true, "Mohamed", "Ahmed", false, null, "MOHAMED.AHMED@GMAIL.COM", "MOHAMED.AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAEDDC741w3u09jKhnHrk+eoBNDlaluYyHXEziWXeRoAhFEJCI4e79tvhvwsbe6jS3Jg==", "01094456724", true, "ee64906a-eabe-4e6c-a73c-840c300ba18b", true, "Mohamed.Ahmed@gmail.com" },
                    { "54f08fb7-34c9-4c56-af7b-8895b76c16d9", 0, 20, "35a5641a-c996-4aca-a0a9-2eee1603d1c5", "Mona.Mohamed@gmail.com", true, "Mona", "Mohamed", false, null, "MONA.MOHAMED@GMAIL.COM", "MONA.MOHAMED@GMAIL.COM", "AQAAAAIAAYagAAAAEBq5HwvAVKXCUUW8IaqyORP3BVlUEhK2FNoSs0nshdBQYEtVNZjKA+8V829gHAjgPg==", "01095556724", true, "410308ef-f7b0-46c4-a05e-c3e2bdfbd87b", true, "Mona.Mohamed@gmail.com" },
                    { "ba9e9743-a482-4ee0-8997-e4dfe0765f94", 0, 21, "849e883e-f236-485c-8201-14ad342dda5a", "Alaa.Mohamed@gmail.com", true, "Alaa", "Mohamed", false, null, "ALAA.MOHAMED@GMAIL.COM", "ALAA.MOHAMED@GMAIL.COM", "AQAAAAIAAYagAAAAEE0ZGOMx8ZsIIIRT0tRplEs+KVYvIQggAiLrRbSPZb7L+Dtp4Qb9EnHefixmMlKlhA==", "01294456724", true, "e8fc5c6c-2f21-4d8a-ae0a-f8dfb4b59ae1", true, "Alaa.Mohamed@gmail.com" },
                    { "bccdb075-ea49-45d2-8b21-13c8172fe1cf", 0, 20, "25dab51b-60e2-42ab-b47e-59a835372ef8", "Ali.Ahmed@gmail.com", true, "Ali", "Ahmed", false, null, "ALI.AHMED@GMAIL.COM", "ALI.AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAEHnf77f26On8+inu5oSKET8G3ggRcP/oN8Olp0z/pECA45jHZ62Ej6RIXtFPWS6ImQ==", "01194456724", true, "13519ddb-2a1c-479e-b7c6-1fa1a706c342", true, "Ali.Ahmed@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "874c34bd-ed21-43da-8880-40fdfbd146d9", "226f9379-7a36-4df6-a98d-260651b353d2" },
                    { "9555489f-04b3-4aa8-b33e-d603c5f3b93c", "54f08fb7-34c9-4c56-af7b-8895b76c16d9" },
                    { "94a4da16-d0cd-47e2-86f3-2e500fd55e4e", "ba9e9743-a482-4ee0-8997-e4dfe0765f94" },
                    { "6079f57f-a875-4257-81e0-d3540518482c", "bccdb075-ea49-45d2-8b21-13c8172fe1cf" }
                });
        }
    }
}
