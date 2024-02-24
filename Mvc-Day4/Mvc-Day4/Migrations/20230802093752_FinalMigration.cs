using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mvc_Day4.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "beea5574-8be4-43af-92ec-33349b81dd17", "4ec3b723-51f5-4b77-a6f5-8408602bf676" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "857a2334-1e35-420e-a54e-27efdee389c5", "96e8e766-933d-43c7-9ee1-50061f782aad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "30fe2baa-1820-4aad-bb7b-5a7f7d8a51d0", "cf75b59d-c2ed-4c9f-aad0-355ec8564985" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0d41eed-f5db-4d32-96d5-1968539e9ce4", "ea176324-d236-4792-98b4-280aee1b7668" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30fe2baa-1820-4aad-bb7b-5a7f7d8a51d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "857a2334-1e35-420e-a54e-27efdee389c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "beea5574-8be4-43af-92ec-33349b81dd17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0d41eed-f5db-4d32-96d5-1968539e9ce4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ec3b723-51f5-4b77-a6f5-8408602bf676");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96e8e766-933d-43c7-9ee1-50061f782aad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf75b59d-c2ed-4c9f-aad0-355ec8564985");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea176324-d236-4792-98b4-280aee1b7668");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "30fe2baa-1820-4aad-bb7b-5a7f7d8a51d0", null, "IdentityRole", "Manager", "MANAGER" },
                    { "857a2334-1e35-420e-a54e-27efdee389c5", null, "IdentityRole", "User", "USER" },
                    { "beea5574-8be4-43af-92ec-33349b81dd17", null, "IdentityRole", "Adminstration", "ADMINSTRATION" },
                    { "d0d41eed-f5db-4d32-96d5-1968539e9ce4", null, "IdentityRole", "Med-Manager", "MED-MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4ec3b723-51f5-4b77-a6f5-8408602bf676", 0, 22, "02bf5d7f-ece1-4683-8546-8ed23d5a37c3", "Mohamed.Ahmed@gmail.com", true, "Mohamed", "Ahmed", false, null, "MOHAMED.AHMED@GMAIL.COM", "MOHAMED.AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAEKXtGST3nNel42p3hTmJ4jnjEINkDtbqG039eomopI2bhcMclIWotVsFQ1OlEvefmw==", "01094456724", true, "4d42b056-a972-4085-87c5-436b40747c8e", true, "Mohamed.Ahmed@gmail.com" },
                    { "96e8e766-933d-43c7-9ee1-50061f782aad", 0, 21, "c92f5ae4-fe49-4bcf-896e-f1a85f60139d", "Alaa.Mohamed@gmail.com", true, "Alaa", "Mohamed", false, null, "ALAA.MOHAMED@GMAIL.COM", "ALAA.MOHAMED@GMAIL.COM", "AQAAAAIAAYagAAAAEPNL5nxFcxjlkQnICzk/vtlMeUWApdx1Qm2/OKq0z5spMaxXAjREGxYncsXctVbWYQ==", "01294456724", true, "956f5fff-f9a2-46fa-a4b6-abc7b606b44b", true, "Alaa.Mohamed@gmail.com" },
                    { "cf75b59d-c2ed-4c9f-aad0-355ec8564985", 0, 20, "dbb9271c-6b2d-4b53-a2db-7bdbe4812e78", "Ali.Ahmed@gmail.com", true, "Ali", "Ahmed", false, null, "ALI.AHMED@GMAIL.COM", "ALI.AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAEH3XtUxnXcZjLLPOWD1NrfR5RoF/rjq6XNLIKMxSWeFy2nh5zZsaBf3lg6weHSow1Q==", "01194456724", true, "77dfa41e-c59c-4079-85f0-416b70527471", true, "Ali.Ahmed@gmail.com" },
                    { "ea176324-d236-4792-98b4-280aee1b7668", 0, 20, "17aed9fa-0596-4592-890e-ce4fc31b170a", "Mona.Mohamed@gmail.com", true, "Mona", "Mohamed", false, null, "MONA.MOHAMED@GMAIL.COM", "MONA.MOHAMED@GMAIL.COM", "AQAAAAIAAYagAAAAECkWXsVMfuV1u7KSbZRN2u5t6RegJzlopQcCfhDjd084DDYUNb0X27mxL9mnqVdEdg==", "01095556724", true, "dd92e091-82ce-4db5-af25-5f9564dbfbee", true, "Mona.Mohamed@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "beea5574-8be4-43af-92ec-33349b81dd17", "4ec3b723-51f5-4b77-a6f5-8408602bf676" },
                    { "857a2334-1e35-420e-a54e-27efdee389c5", "96e8e766-933d-43c7-9ee1-50061f782aad" },
                    { "30fe2baa-1820-4aad-bb7b-5a7f7d8a51d0", "cf75b59d-c2ed-4c9f-aad0-355ec8564985" },
                    { "d0d41eed-f5db-4d32-96d5-1968539e9ce4", "ea176324-d236-4792-98b4-280aee1b7668" }
                });
        }
    }
}
