using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryProperties.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionFix8 : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "IdProperty",
                table: "PropertyTrace",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProperty",
                table: "PropertyImage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTrace_IdProperty",
                table: "PropertyTrace",
                column: "IdProperty");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImage_IdProperty",
                table: "PropertyImage",
                column: "IdProperty");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImage_Property_IdProperty",
                table: "PropertyImage",
                column: "IdProperty",
                principalTable: "Property",
                principalColumn: "IdProperty",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyTrace_Property_IdProperty",
                table: "PropertyTrace",
                column: "IdProperty",
                principalTable: "Property",
                principalColumn: "IdProperty",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyImage_Property_IdProperty",
                table: "PropertyImage");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyTrace_Property_IdProperty",
                table: "PropertyTrace");

            migrationBuilder.DropIndex(
                name: "IX_PropertyTrace_IdProperty",
                table: "PropertyTrace");

            migrationBuilder.DropIndex(
                name: "IX_PropertyImage_IdProperty",
                table: "PropertyImage");

            migrationBuilder.DropColumn(
                name: "IdProperty",
                table: "PropertyTrace");

            migrationBuilder.DropColumn(
                name: "IdProperty",
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
    }
}
