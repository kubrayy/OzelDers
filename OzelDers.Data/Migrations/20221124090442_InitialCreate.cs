using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OzelDers.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    OneHourPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmailAdres = table.Column<string>(type: "TEXT", nullable: true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructorAndStudents",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    InstructorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorAndStudents", x => new { x.InstructorId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_InstructorAndStudents_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorAndStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "ImageUrl", "Name", "Url" },
                values: new object[] { 1, "english.jpeg", "English", "learnenglish" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "ImageUrl", "Name", "Url" },
                values: new object[] { 2, "germany.jpeg", "Germany", "learngermany" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "ImageUrl", "Name", "Url" },
                values: new object[] { 3, "italy.jpeg", "Italian", "learnitalian" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "ImageUrl", "Name", "Url" },
                values: new object[] { 4, "korean.jpeg", "Korean", "learnkorean" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "LastName", "Name" },
                values: new object[] { 1, 17, "Purple", "Joseph" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "LastName", "Name" },
                values: new object[] { 2, 16, "Black", "Yusuf" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "LastName", "Name" },
                values: new object[] { 3, 26, "Pink", "Merve" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "LastName", "Name" },
                values: new object[] { 4, 37, "Maslı", "Aslı" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 1, 77, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4930), "Hello, I'm English. Let's make practice!", "roseblack@example.com", "Woman", "1_en.jpeg", 1, "Black", "Rose", 50m, "1" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 2, 65, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4960), "Hello, I'm English. Let's make practice!", "charlesprince@example.com", "Man", "2_en.jpeg", 1, "Prince", "Charles", 70m, "2" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 3, 35, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4960), "Hello, I'm English. Let's make practice!", "elizabethblue@example.com", "Man", "3_en.jpeg", 1, "Blue", "Elizabeth", 50m, "3" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 4, 34, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4960), "Hello, I'm German. Let's make practice!", "blaskoln@example.com", "Man", "4_alm.jpeg", 2, "Köln", "Blas", 90m, "4" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 5, 46, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4960), "Hello, I'm German. Let's make practice!", "odianemodiane@example.com", "Man", "5_alm.jpeg", 2, "Modiane", "Odiane", 120m, "5" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 6, 34, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970), "Hello, I'm German. Let's make practice!", "trudymrudy@example.com", "Man", "6_alm.jpeg", 2, "Mrudy", "Trudy", 150m, "6" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 7, 27, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970), "Hello, I'm Italian. Let's make practice!", "alessamalessa@example.com", "Woman", "7_ital.jpeg", 3, "Malessa", "Alessa", 170m, "7" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 8, 44, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970), "Hello, I'm Italian. Let's make practice!", "aureliaonomoro@example.com", "Man", "8_ital.jpeg", 3, "Moro", "Aureliano", 150m, "8" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 9, 34, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970), "Hello, I'm Italian. Let's make practice!", "orestemokar@example.com", "Man", "9_ital.jpeg", 3, "Mokar", "Oreste", 180m, "9" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 10, 25, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970), "Hello, I'm Korean. Let's make practice!", "iseosiwoo@example.com", "Woman", "10_kor.jpg", 4, "Si-woo", "I-seo", 190m, "10" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 11, 21, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4980), "Hello, I'm Korean. Let's make practice!", "yejunpoju@example.com", "Woman", "11_kor.jpg", 4, "Po-ju", "Ye-jun", 120m, "11" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "EmailAdres", "Gender", "ImageUrl", "LanguageId", "LastName", "Name", "OneHourPrice", "Url" },
                values: new object[] { 12, 19, new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4980), "Hello, I'm Korean. Let's make practice!", "eunseoseoyun@example.com", "Woman", "12_kor.jpg", 4, "Seoyun", "Eunseo", 150m, "12" });

            migrationBuilder.CreateIndex(
                name: "IX_InstructorAndStudents_StudentId",
                table: "InstructorAndStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_LanguageId",
                table: "Instructors",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstructorAndStudents");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
