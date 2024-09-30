using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryProperties.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropertyIdProperty",
                table: "PropertyImage",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImage_PropertyIdProperty",
                table: "PropertyImage",
                column: "PropertyIdProperty");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImage_Property_PropertyIdProperty",
                table: "PropertyImage",
                column: "PropertyIdProperty",
                principalTable: "Property",
                principalColumn: "IdProperty");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyImage_Property_PropertyIdProperty",
                table: "PropertyImage");

            migrationBuilder.DropIndex(
                name: "IX_PropertyImage_PropertyIdProperty",
                table: "PropertyImage");

            migrationBuilder.DropColumn(
                name: "PropertyIdProperty",
                table: "PropertyImage");
        }
    }
}
