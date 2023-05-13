using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3rdBackendProject.Migrations
{
    /// <inheritdoc />
    public partial class dele : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Specialities_SpecialitiesID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SpecialitiesID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SpecialitiesID",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SpecialityID",
                table: "Users",
                column: "SpecialityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Specialities_SpecialityID",
                table: "Users",
                column: "SpecialityID",
                principalTable: "Specialities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Specialities_SpecialityID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SpecialityID",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "SpecialitiesID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SpecialitiesID",
                table: "Users",
                column: "SpecialitiesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Specialities_SpecialitiesID",
                table: "Users",
                column: "SpecialitiesID",
                principalTable: "Specialities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
