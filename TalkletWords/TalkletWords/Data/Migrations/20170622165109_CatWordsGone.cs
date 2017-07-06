using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalkletWords.Data.Migrations
{
    public partial class CatWordsGone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_CategoryWords_CategoryWordsId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Word_CategoryWords_CategoryWordsId",
                table: "Word");

            migrationBuilder.DropForeignKey(
                name: "FK_WordData_Word_WordId",
                table: "WordData");

            migrationBuilder.DropTable(
                name: "CategoryWords");

            migrationBuilder.DropIndex(
                name: "IX_WordData_WordId",
                table: "WordData");

            migrationBuilder.DropIndex(
                name: "IX_Word_CategoryWordsId",
                table: "Word");

            migrationBuilder.DropIndex(
                name: "IX_Category_CategoryWordsId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CategoryWordsId",
                table: "Word");

            migrationBuilder.DropColumn(
                name: "CategoryWordsId",
                table: "Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
