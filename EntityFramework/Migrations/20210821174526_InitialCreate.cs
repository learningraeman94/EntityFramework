using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dicti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentIdId = table.Column<int>(type: "INTEGER", nullable: true),
                    Fullname = table.Column<string>(type: "TEXT", nullable: true),
                    Constname = table.Column<string>(type: "TEXT", nullable: true),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dicti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dicti_Dicti_ParentIdId",
                        column: x => x.ParentIdId,
                        principalTable: "Dicti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fullname = table.Column<string>(type: "TEXT", nullable: true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: true),
                    Secondname = table.Column<string>(type: "TEXT", nullable: true),
                    Parentname = table.Column<string>(type: "TEXT", nullable: true),
                    ClassTypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Dicti_ClassTypeId",
                        column: x => x.ClassTypeId,
                        principalTable: "Dicti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_Subjects_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dicti_ParentIdId",
                table: "Dicti",
                column: "ParentIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ClassTypeId",
                table: "Subjects",
                column: "ClassTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_UpdatedById",
                table: "Subjects",
                column: "UpdatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Dicti");
        }
    }
}
