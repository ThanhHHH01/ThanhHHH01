using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiThucHanh2002.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Student_FacultyID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentCode",
                table: "Students",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Students",
                newName: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FacultyID",
                table: "Students",
                column: "FacultyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Facultys_FacultyID",
                table: "Students",
                column: "FacultyID",
                principalTable: "Facultys",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Facultys_FacultyID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_FacultyID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "StudentCode");

            migrationBuilder.RenameColumn(
                name: "FacultyID",
                table: "Students",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
