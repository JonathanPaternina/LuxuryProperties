using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryProperties.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionFix5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "PropertyTrace");

            migrationBuilder.DropColumn(
                name: "IdProperty1",
                table: "PropertyImage");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "IdProperty1",
                table: "PropertyTrace",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
