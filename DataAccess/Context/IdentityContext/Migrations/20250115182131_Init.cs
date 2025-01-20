using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.IdentityContext.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    HasPasswordChanged = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Name", "NormalizedName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("499a3674-2aae-469a-8940-41893b636c00"), null, new DateTime(2025, 1, 15, 18, 21, 30, 450, DateTimeKind.Utc).AddTicks(8662), null, "student", "STUDENT", 1, null },
                    { new Guid("7131d431-27c8-4b46-b7db-305cdbac3bef"), null, new DateTime(2025, 1, 15, 18, 21, 30, 450, DateTimeKind.Utc).AddTicks(8660), null, "teacher", "TEACHER", 1, null },
                    { new Guid("d56b0610-7157-4fca-b989-bfdabac1f4f5"), null, new DateTime(2025, 1, 15, 18, 21, 30, 450, DateTimeKind.Utc).AddTicks(7481), null, "admin", "ADMIN", 1, null },
                    { new Guid("fb230ada-67a9-40f3-96b2-c9c602ed7fee"), null, new DateTime(2025, 1, 15, 18, 21, 30, 450, DateTimeKind.Utc).AddTicks(8652), null, "customerManager", "CUSTOMERMANAGER", 1, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "FirstName", "HasPasswordChanged", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { new Guid("43c10399-6734-42d1-91c5-838b551a066e"), 0, new DateTime(2014, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "a7025b15-2196-49cf-82db-c20513e1f146", new DateTime(2025, 1, 15, 18, 21, 30, 196, DateTimeKind.Utc).AddTicks(9208), null, "miray.cekic@edu.com", false, "Miray", true, "Çekiç", false, null, "MIRAY.CEKIC@EDU.COM", "MIRAY.CEKIC", "AQAAAAIAAYagAAAAEC8W5vIDLlQ63q4UUpLa7j8AHIeBGEtgCOs4t0Ymc9uqrhOEvTg0boqMsCgiWH1AIg==", null, false, "c9136208-150d-476e-b75a-0166b69ebd46", 1, false, null, "miray.cekic" },
                    { new Guid("89db9ff5-9f40-4c5e-a17d-1c1ec45636c0"), 0, new DateTime(1985, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "b3d820b6-56be-4710-ba57-480c20831648", new DateTime(2025, 1, 15, 18, 21, 29, 808, DateTimeKind.Utc).AddTicks(5747), null, "ahmet.cekic@edu.com", false, "Ahmet", true, "Çekiç", false, null, "AHMET.CEKIC@EDU.COM", "AHMET.CEKIC", "AQAAAAIAAYagAAAAEJYRNbiJJErv7BeWbmikEdB0pj3PXgP8v3dZ+Ct4CN0wyA7MXag9RCItI3HnjF1NRQ==", null, false, "58324521-705c-433c-a1b2-02aefe7db987", 1, false, null, "ahmet.cekic" },
                    { new Guid("8b12fe04-e7d8-4fe6-ba17-1283ac7abaa9"), 0, new DateTime(1975, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "3f14dffc-340a-4876-a76a-7474cadd9949", new DateTime(2025, 1, 15, 18, 21, 30, 310, DateTimeKind.Utc).AddTicks(9608), null, "danilo.zanna@edu.com", false, "Danilo", true, "Zanna", false, null, "DANILO.ZANNA@EDU.COM", "DANILO.ZANNA", "AQAAAAIAAYagAAAAEHJdQUcQ7i9vTyuqezhsiFDDWTEGucNFxOQAI9Sc9nE70LyS3mOXQycaaF1h25k3sA==", null, false, "170a1347-3113-4257-ab67-a6d0bf1a8661", 1, false, null, "danilo.zanna" },
                    { new Guid("976e4111-519f-485f-a21b-186e30f07371"), 0, new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "affd2238-ce37-4a33-a809-23bcbddbf4d4", new DateTime(2025, 1, 15, 18, 21, 29, 939, DateTimeKind.Utc).AddTicks(6183), null, "sinaemre.bekar@edu.com", false, "Sina Emre", true, "Bekar", false, null, "SINAEMRE.BEKAR@EDU.COM", "SINAEMRE.BEKAR", "AQAAAAIAAYagAAAAEDgo6g2Ncpt3+iGSEWvG3WdEPaUA65elY7P08QxwuB/K6BoPn09RdjHeKfBKtbtOdg==", null, false, "5388fb2d-03d6-4b04-ad39-611e2eda8ff8", 1, false, null, "sinaemre.bekar" },
                    { new Guid("c2b28166-5def-49e5-bb0b-741a16f886d4"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "105cc1bc-c600-48fd-bddf-10fd443a034e", new DateTime(2025, 1, 15, 18, 21, 29, 665, DateTimeKind.Utc).AddTicks(3673), null, "admin@edu.com", false, "Administrator", true, "Admin", false, null, "ADMIN@EDU.COM", "ADMIN", "AQAAAAIAAYagAAAAELLFovMKWX9CiydrMwQQAC4A1fr2rD+y85xRokwAzGy8Fe7z+X156YNiZCka9vjwVA==", null, false, "103468de-0e3e-4aaa-a769-e037284cd035", 1, false, null, "admin" },
                    { new Guid("d3a95b67-ce52-4c1d-835a-14df01e3501f"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3aec526e-0102-4810-bdb0-0c9b4ee16295", new DateTime(2025, 1, 15, 18, 21, 30, 72, DateTimeKind.Utc).AddTicks(4115), null, "murat.yeler@edu.com", false, "Murat", true, "Yeler", false, null, "MURAT.YELER@EDU.COM", "MURAT.YELER", "AQAAAAIAAYagAAAAEDeTNg+f9lGPZC+2uhzg5ANCwn1lUpSAEmlPYwlqOrJ9UZ2aRzr1wr+JmkR6VHjxvQ==", null, false, "77c2f2ef-2a4c-4b20-9ec3-41cb6adfa8e4", 1, false, null, "murat.yeler" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("499a3674-2aae-469a-8940-41893b636c00"), new Guid("43c10399-6734-42d1-91c5-838b551a066e") },
                    { new Guid("fb230ada-67a9-40f3-96b2-c9c602ed7fee"), new Guid("89db9ff5-9f40-4c5e-a17d-1c1ec45636c0") },
                    { new Guid("499a3674-2aae-469a-8940-41893b636c00"), new Guid("8b12fe04-e7d8-4fe6-ba17-1283ac7abaa9") },
                    { new Guid("7131d431-27c8-4b46-b7db-305cdbac3bef"), new Guid("976e4111-519f-485f-a21b-186e30f07371") },
                    { new Guid("d56b0610-7157-4fca-b989-bfdabac1f4f5"), new Guid("c2b28166-5def-49e5-bb0b-741a16f886d4") },
                    { new Guid("499a3674-2aae-469a-8940-41893b636c00"), new Guid("d3a95b67-ce52-4c1d-835a-14df01e3501f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
