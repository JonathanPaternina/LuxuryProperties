﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryProperties.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionFix7 : Migration
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
