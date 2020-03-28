﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WordsAWeb.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WordsA",
                columns: table => new
                {
                    WordsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordEng = table.Column<string>(nullable: true),
                    WordPol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordsA", x => x.WordsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordsA");
        }
    }
}
