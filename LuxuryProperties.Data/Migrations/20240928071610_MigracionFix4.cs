using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryProperties.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionFix4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyImage_PropertyImageIdPropertyImage",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyTrace_PropertyTraceIdPropertyTrace",
                table: "Property");

            migrationBuilder.DropIndex(
                name: "IX_Property_PropertyImageIdPropertyImage",
                table: "Property");

            migrationBuilder.DropIndex(
                name: "IX_Property_PropertyTraceIdPropertyTrace",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "PropertyImageIdPropertyImage",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "PropertyTraceIdPropertyTrace",
                table: "Property");

            migrationBuilder.RenameColumn(
                name: "IdProperty",
                table: "PropertyTrace",
                newName: "IdProperty1");

            migrationBuilder.AddColumn<int>(
                name: "IdProperty1",
                table: "PropertyImage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTrace_IdProperty1",
                table: "PropertyTrace",
                column: "IdProperty1");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImage_IdProperty1",
                table: "PropertyImage",
                column: "IdProperty1");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImage_Property_IdProperty1",
                table: "PropertyImage",
                column: "IdProperty1",
                principalTable: "Property",
                principalColumn: "IdProperty",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyTrace_Property_IdProperty1",
                table: "PropertyTrace",
                column: "IdProperty1",
                principalTable: "Property",
                principalColumn: "IdProperty",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyImage_Property_IdProperty1",
                table: "PropertyImage");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyTrace_Property_IdProperty1",
                table: "PropertyTrace");

            migrationBuilder.DropIndex(
                name: "IX_PropertyTrace_IdProperty1",
                table: "PropertyTrace");

            migrationBuilder.DropIndex(
                name: "IX_PropertyImage_IdProperty1",
                table: "PropertyImage");

            migrationBuilder.DropColumn(
                name: "IdProperty1",
                table: "PropertyImage");

            migrationBuilder.RenameColumn(
                name: "IdProperty",
                table: "PropertyTrace",
                newName: "IdProperty");

            migrationBuilder.AddColumn<int>(
                name: "PropertyImageIdPropertyImage",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropertyTraceIdPropertyTrace",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyImageIdPropertyImage",
                table: "Property",
                column: "PropertyImageIdPropertyImage");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyTraceIdPropertyTrace",
                table: "Property",
                column: "PropertyTraceIdPropertyTrace");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyImage_PropertyImageIdPropertyImage",
                table: "Property",
                column: "PropertyImageIdPropertyImage",
                principalTable: "PropertyImage",
                principalColumn: "IdPropertyImage",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyTrace_PropertyTraceIdPropertyTrace",
                table: "Property",
                column: "PropertyTraceIdPropertyTrace",
                principalTable: "PropertyTrace",
                principalColumn: "IdPropertyTrace",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
