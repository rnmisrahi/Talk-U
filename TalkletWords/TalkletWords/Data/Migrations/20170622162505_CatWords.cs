using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TalkletWords.Data.Migrations
{
    public partial class CatWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryWordsId",
                table: "Word",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryWordsId",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryWords",
                columns: table => new
                {
                    CategoryWordsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryWords", x => x.CategoryWordsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WordData_WordId",
                table: "WordData",
                column: "WordId");

            migrationBuilder.CreateIndex(
                name: "IX_Word_CategoryWordsId",
                table: "Word",
                column: "CategoryWordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryWordsId",
                table: "Category",
                column: "CategoryWordsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_CategoryWords_CategoryWordsId",
                table: "Category",
                column: "CategoryWordsId",
                principalTable: "CategoryWords",
                principalColumn: "CategoryWordsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Word_CategoryWords_CategoryWordsId",
                table: "Word",
                column: "CategoryWordsId",
                principalTable: "CategoryWords",
                principalColumn: "CategoryWordsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WordData_Word_WordId",
                table: "WordData",
                column: "WordId",
                principalTable: "Word",
                principalColumn: "WordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
