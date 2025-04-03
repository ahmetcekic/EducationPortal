using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TotalHour = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HireDate = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerManagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HireDate = table.Column<DateTime>(type: "date", nullable: false),
                    CourseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    TeacherId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classrooms_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Exam1 = table.Column<double>(type: "double precision", nullable: true),
                    Exam2 = table.Column<double>(type: "double precision", nullable: true),
                    ProjectExam = table.Column<double>(type: "double precision", nullable: true),
                    ProjectPath = table.Column<string>(type: "text", nullable: true),
                    ProjectName = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    ClassroomId = table.Column<Guid>(type: "uuid", nullable: false),
                    RegisterPrice = table.Column<double>(type: "double precision", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "TotalHour", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2b3f0a6f-3888-4f2f-b091-2e6d48bfdfda"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(8279), null, "Siber Güvenlik Programı", 1, null, null },
                    { new Guid("5302c91d-6e2e-4596-956f-c673a83c462f"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(8247), null, ".NET Eğitim Programı", 1, null, null },
                    { new Guid("70d1e658-6578-435d-98f3-db2b60e31bb9"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(8277), null, "Sistem ve Ağ Uzmanlığı Programı", 1, null, null },
                    { new Guid("8e38ae94-455a-4269-8157-ac276238814a"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(8273), null, "Java Eğitim Programı", 1, null, null },
                    { new Guid("b213772c-2986-4204-afa3-7d68adf070bc"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(8276), null, "Python Eğitim Programı", 1, null, null },
                    { new Guid("d711fea2-e7bf-4d40-8598-e4a1174f9d91"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(8282), null, "Mobil Programlama Programı", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "CustomerManagers",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "Email", "FirstName", "HireDate", "LastName", "Status", "UpdatedDate" },
                values: new object[] { new Guid("1ab0efab-65f6-4006-ba57-cb4278626936"), new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(8653), null, "ahmet.cekic@edu.com", "Ahmet", new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çekiç", 1, null });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "BirthDate", "CourseId", "CreatedDate", "DeletedDate", "Email", "FirstName", "HireDate", "LastName", "Status", "UpdatedDate" },
                values: new object[] { new Guid("d6b125d9-7a07-4c84-b194-20da87df3bde"), new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5302c91d-6e2e-4596-956f-c673a83c462f"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(8808), null, "sinaemre.bekar@edu.com", "Sina Emre", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bekar", 1, null });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "EndDate", "Name", "StartDate", "Status", "TeacherId", "UpdatedDate" },
                values: new object[] { new Guid("fbb187bf-ec28-4524-a710-fae4f59c6d71"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(8961), null, "Teknoloji Sınıfı", null, "TEK-2024", null, 1, new Guid("d6b125d9-7a07-4c84-b194-20da87df3bde"), null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "ClassroomId", "CreatedDate", "DeletedDate", "Email", "Exam1", "Exam2", "FirstName", "ImagePath", "LastName", "ProjectExam", "ProjectName", "ProjectPath", "RegisterPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("43c10399-6734-42d1-91c5-838b551a066e"), new DateTime(2014, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fbb187bf-ec28-4524-a710-fae4f59c6d71"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(9106), null, "miray.cekic@edu.com", null, null, "Miray", null, "Çekiç", null, null, null, null, 1, null },
                    { new Guid("8b12fe04-e7d8-4fe6-ba17-1283ac7abaa9"), new DateTime(1975, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fbb187bf-ec28-4524-a710-fae4f59c6d71"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(9109), null, "danilo.zanna@edu.com", null, null, "Danilo", null, "Zanna", null, null, null, null, 1, null },
                    { new Guid("d3a95b67-ce52-4c1d-835a-14df01e3501f"), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fbb187bf-ec28-4524-a710-fae4f59c6d71"), new DateTime(2025, 4, 4, 1, 37, 54, 557, DateTimeKind.Local).AddTicks(9100), null, "murat.yeler@edu.com", null, null, "Murat", null, "Yeler", null, null, null, null, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_TeacherId",
                table: "Classrooms",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassroomId",
                table: "Students",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CourseId",
                table: "Teachers",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerManagers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
