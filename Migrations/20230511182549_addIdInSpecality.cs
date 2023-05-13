using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3rdBackendProject.Migrations
{
    /// <inheritdoc />
    public partial class addIdInSpecality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Specialities_SpecialityID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SpecialityID",
                table: "Users",
                newName: "SpecialitiesID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_SpecialityID",
                table: "Users",
                newName: "IX_Users_SpecialitiesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Specialities_SpecialitiesID",
                table: "Users",
                column: "SpecialitiesID",
                principalTable: "Specialities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Specialities_SpecialitiesID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SpecialitiesID",
                table: "Users",
                newName: "SpecialityID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_SpecialitiesID",
                table: "Users",
                newName: "IX_Users_SpecialityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Specialities_SpecialityID",
                table: "Users",
                column: "SpecialityID",
                principalTable: "Specialities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
