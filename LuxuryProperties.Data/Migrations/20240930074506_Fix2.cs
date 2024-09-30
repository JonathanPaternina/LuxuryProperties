using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryProperties.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Owner_OwnerId",
                table: "Property");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Property",
                newName: "IdOwner");

            migrationBuilder.RenameIndex(
                name: "IX_Property_OwnerId",
                table: "Property",
                newName: "IX_Property_IdOwner");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Owner",
                newName: "IdOwner");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Owner_IdOwner",
                table: "Property",
                column: "IdOwner",
                principalTable: "Owner",
                principalColumn: "IdOwner",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Owner_IdOwner",
                table: "Property");

            migrationBuilder.RenameColumn(
                name: "IdOwner",
                table: "Property",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_IdOwner",
                table: "Property",
                newName: "IX_Property_OwnerId");

            migrationBuilder.RenameColumn(
                name: "IdOwner",
                table: "Owner",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Owner_OwnerId",
                table: "Property",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
