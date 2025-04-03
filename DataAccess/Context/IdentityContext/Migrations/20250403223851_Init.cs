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
                    FirstPassword = table.Column<string>(type: "text", nullable: true),
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
                    { new Guid("499a3674-2aae-469a-8940-41893b636c00"), null, new DateTime(2025, 4, 4, 1, 38, 49, 981, DateTimeKind.Local).AddTicks(9554), null, "student", "STUDENT", 1, null },
                    { new Guid("7131d431-27c8-4b46-b7db-305cdbac3bef"), null, new DateTime(2025, 4, 4, 1, 38, 49, 981, DateTimeKind.Local).AddTicks(9551), null, "teacher", "TEACHER", 1, null },
                    { new Guid("d56b0610-7157-4fca-b989-bfdabac1f4f5"), null, new DateTime(2025, 4, 4, 1, 38, 49, 981, DateTimeKind.Local).AddTicks(9497), null, "admin", "ADMIN", 1, null },
                    { new Guid("fb230ada-67a9-40f3-96b2-c9c602ed7fee"), null, new DateTime(2025, 4, 4, 1, 38, 49, 981, DateTimeKind.Local).AddTicks(9547), null, "customerManager", "CUSTOMERMANAGER", 1, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "FirstName", "FirstPassword", "HasPasswordChanged", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { new Guid("43c10399-6734-42d1-91c5-838b551a066e"), 0, new DateTime(2014, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "b937d670-0c29-4dea-b43d-3e10cf8a278a", new DateTime(2025, 4, 4, 1, 38, 49, 693, DateTimeKind.Local).AddTicks(7050), null, "miray.cekic@edu.com", false, "Miray", null, true, "Çekiç", false, null, "MIRAY.CEKIC@EDU.COM", "MIRAY.CEKIC", "AQAAAAIAAYagAAAAENUOP6J0Hr09z6zuOAJIAtfLMVqu8AQc+IYpF13SFWe0HBsoFOC3tDLnLkmp0A66rw==", null, false, "53c91a29-08f4-4a56-a84d-c1c3caac7ccf", 1, false, null, "miray.cekic" },
                    { new Guid("89db9ff5-9f40-4c5e-a17d-1c1ec45636c0"), 0, new DateTime(1985, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "3601f791-9308-4e4e-a656-943da35402b2", new DateTime(2025, 4, 4, 1, 38, 49, 298, DateTimeKind.Local).AddTicks(9535), null, "ahmet.cekic@edu.com", false, "Ahmet", null, true, "Çekiç", false, null, "AHMET.CEKIC@EDU.COM", "AHMET.CEKIC", "AQAAAAIAAYagAAAAELwO9RnZk2bPSpT4HwdHBv4uzwif2cMJllpR7YRqLjrJKCnJ0gdLSKqiYqZclw1UTg==", null, false, "334c13fe-b117-439b-a53a-b75f184b7f38", 1, false, null, "ahmet.cekic" },
                    { new Guid("8b12fe04-e7d8-4fe6-ba17-1283ac7abaa9"), 0, new DateTime(1975, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "dbe240d6-317f-4daa-ba81-e29e57a7037d", new DateTime(2025, 4, 4, 1, 38, 49, 831, DateTimeKind.Local).AddTicks(1078), null, "danilo.zanna@edu.com", false, "Danilo", null, true, "Zanna", false, null, "DANILO.ZANNA@EDU.COM", "DANILO.ZANNA", "AQAAAAIAAYagAAAAEKRXUYy32DAoJb/oadZIJ3emF98qCQbRmB+VyI0KSGFgOdrS8tj7zhqRz7plyEU17A==", null, false, "7a9f06d9-a621-487f-9682-21a4bb1b5153", 1, false, null, "danilo.zanna" },
                    { new Guid("976e4111-519f-485f-a21b-186e30f07371"), 0, new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "2892d002-0b21-4f94-9c77-bfd243c11cd6", new DateTime(2025, 4, 4, 1, 38, 49, 448, DateTimeKind.Local).AddTicks(9860), null, "sinaemre.bekar@edu.com", false, "Sina Emre", null, true, "Bekar", false, null, "SINAEMRE.BEKAR@EDU.COM", "SINAEMRE.BEKAR", "AQAAAAIAAYagAAAAEPGeZcYwHpk9FliIX/2ZIEDlcq1FDmW+IwhvA7NPInNCwX/dkDMOtBo3C/VN5gec0A==", null, false, "aaf70b06-a9d8-440f-a552-deb552d0309c", 1, false, null, "sinaemre.bekar" },
                    { new Guid("c2b28166-5def-49e5-bb0b-741a16f886d4"), 0, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fde5fd50-da3e-4f0a-87ec-5796c07d85c7", new DateTime(2025, 4, 4, 1, 38, 49, 163, DateTimeKind.Local).AddTicks(5004), null, "admin@edu.com", false, "Administrator", null, true, "Admin", false, null, "ADMIN@EDU.COM", "ADMIN", "AQAAAAIAAYagAAAAEITLwwtPtwwfl0uC16DHYYy+Vp8JKRd7sdaJo+JGDWdFwKNXUanfkFNQ5x8WyEotVg==", null, false, "1aadb8f8-6448-44b2-95bb-971d80a931f4", 1, false, null, "admin" },
                    { new Guid("d3a95b67-ce52-4c1d-835a-14df01e3501f"), 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ab6b678f-aa3b-4756-817f-5e6791fa8cd1", new DateTime(2025, 4, 4, 1, 38, 49, 579, DateTimeKind.Local).AddTicks(879), null, "murat.yeler@edu.com", false, "Murat", null, true, "Yeler", false, null, "MURAT.YELER@EDU.COM", "MURAT.YELER", "AQAAAAIAAYagAAAAEMUhWwrb6/etMfFRGncuTaPCJ3T1DAJnaeclcR9G+k5+iVMZr/9xR6uQBk/nbcupJQ==", null, false, "6a4032c8-8ff9-4001-b93c-b9f2ddb36ada", 1, false, null, "murat.yeler" }
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
