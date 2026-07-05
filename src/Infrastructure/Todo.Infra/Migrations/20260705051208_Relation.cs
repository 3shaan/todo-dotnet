using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItemTags_TodoLists_TodoListId",
                table: "TodoItemTags");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoLists_Users_UserId",
                table: "TodoLists");

            migrationBuilder.DropIndex(
                name: "IX_TodoItemTags_TodoListId",
                table: "TodoItemTags");

            migrationBuilder.DropColumn(
                name: "TodoListId",
                table: "TodoItemTags");

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
                name: "FK_TodoLists_Users_UserId",
                table: "TodoLists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoLists_Users_UserId1",
                table: "TodoLists",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoLists_Users_UserId",
                table: "TodoLists");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoLists_Users_UserId1",
                table: "TodoLists");

            migrationBuilder.DropIndex(
                name: "IX_TodoLists_UserId1",
                table: "TodoLists");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "TodoLists");

            migrationBuilder.AddColumn<Guid>(
                name: "TodoListId",
                table: "TodoItemTags",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoItemTags_TodoListId",
                table: "TodoItemTags",
                column: "TodoListId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItemTags_TodoLists_TodoListId",
                table: "TodoItemTags",
                column: "TodoListId",
                principalTable: "TodoLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoLists_Users_UserId",
                table: "TodoLists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
