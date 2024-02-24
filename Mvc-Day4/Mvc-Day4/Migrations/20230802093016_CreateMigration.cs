using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mvc_Day4.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishDate = table.Column<int>(type: "int", nullable: false),
                    MovieStar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieLength = table.Column<double>(type: "float", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    MovieTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_MovieTypes_MovieTypeId",
                        column: x => x.MovieTypeId,
                        principalTable: "MovieTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "MovieTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Suspense" },
                    { 2, "Dramatic" },
                    { 3, "Sciense Fiction" },
                    { 4, "Action" }
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

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Category", "MovieLength", "MovieStar", "MovieTypeId", "Name", "PublishDate", "Rate" },
                values: new object[,]
                {
                    { 1, "Greater than 15", 2.1500000953674316, "Brad Bit", 1, "Se7en", 1998, 8.5 },
                    { 2, "Greater than 16", 2.2999999523162842, "Leonardo DeCabrio", 2, "ShutterIsland", 2010, 8.0 },
                    { 3, "Public", 2.0, "Tom Cruise", 4, "MissionImpossible", 2012, 8.0 },
                    { 4, "Public", 3.0, "Mathio Makonhy", 3, "Interstellar", 2014, 9.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieTypeId",
                table: "Movies",
                column: "MovieTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MovieTypes");
        }
    }
}
