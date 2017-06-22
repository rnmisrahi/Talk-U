using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalkletWords.Data.Migrations
{
    public partial class wordFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Word_Category_CategoryId",
                table: "Word");

            migrationBuilder.DropForeignKey(
                name: "FK_Word_WordType_WordTypeId",
                table: "Word");

            migrationBuilder.AlterColumn<int>(
                name: "WordTypeId",
                table: "Word",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Word",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Word_Category_CategoryId",
                table: "Word",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Word_WordType_WordTypeId",
                table: "Word",
                column: "WordTypeId",
                principalTable: "WordType",
                principalColumn: "WordTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Word_Category_CategoryId",
                table: "Word");

            migrationBuilder.DropForeignKey(
                name: "FK_Word_WordType_WordTypeId",
                table: "Word");

            migrationBuilder.AlterColumn<int>(
                name: "WordTypeId",
                table: "Word",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Word",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Word_Category_CategoryId",
                table: "Word",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Word_WordType_WordTypeId",
                table: "Word",
                column: "WordTypeId",
                principalTable: "WordType",
                principalColumn: "WordTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
