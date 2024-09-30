using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryProperties.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyImage_Property_PropertyIdProperty",
                table: "PropertyImage");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyTrace_Property_PropertyIdProperty",
                table: "PropertyTrace");

            migrationBuilder.DropIndex(
                name: "IX_PropertyTrace_PropertyIdProperty",
                table: "PropertyTrace");

            migrationBuilder.DropIndex(
                name: "IX_PropertyImage_PropertyIdProperty",
                table: "PropertyImage");

            migrationBuilder.DropColumn(
                name: "PropertyIdProperty",
                table: "PropertyTrace");

            migrationBuilder.DropColumn(
                name: "PropertyIdProperty",
                table: "PropertyImage");

            migrationBuilder.RenameColumn(
                name: "PropertyTraceId",
                table: "PropertyTrace",
                newName: "IdPropertyTrace");

            migrationBuilder.RenameColumn(
                name: "PropertyImageId",
                table: "PropertyImage",
                newName: "IdPropertyImage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPropertyTrace",
                table: "PropertyTrace",
                newName: "PropertyTraceId");

            migrationBuilder.RenameColumn(
                name: "IdPropertyImage",
                table: "PropertyImage",
                newName: "PropertyImageId");

            migrationBuilder.AddColumn<int>(
                name: "PropertyIdProperty",
                table: "PropertyTrace",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyIdProperty",
                table: "PropertyImage",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTrace_PropertyIdProperty",
                table: "PropertyTrace",
                column: "PropertyIdProperty");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyTrace_Property_PropertyIdProperty",
                table: "PropertyTrace",
                column: "PropertyIdProperty",
                principalTable: "Property",
                principalColumn: "IdProperty");
        }
    }
}
