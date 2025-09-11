﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolioUdemy.Migrations
{
    /// <inheritdoc />
    public partial class AboutTablosuGuncelleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Abouts");
        }
    }
}
