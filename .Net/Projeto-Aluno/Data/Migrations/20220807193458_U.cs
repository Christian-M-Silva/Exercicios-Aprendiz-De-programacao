using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class U : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    YearBirth = table.Column<DateTime>(nullable: false),
                    Serie = table.Column<int>(nullable: false),
                    Responsible = table.Column<string>(maxLength: 255, nullable: false),
                    ResponsibleAlternative = table.Column<string>(maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    PhoneNumberAlternative = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
