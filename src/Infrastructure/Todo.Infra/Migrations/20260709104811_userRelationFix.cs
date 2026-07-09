using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.Infra.Migrations
{
    /// <inheritdoc />
    public partial class userRelationFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoLists_Users_UserId1",
                table: "TodoLists");

            migrationBuilder.DropIndex(
                name: "IX_TodoLists_UserId1",
                table: "TodoLists");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "TodoLists");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "TodoLists",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoLists_UserId1",
                table: "TodoLists",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoLists_Users_UserId1",
                table: "TodoLists",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
