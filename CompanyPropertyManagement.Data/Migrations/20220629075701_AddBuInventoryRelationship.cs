using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyPropertyManagement.Data.Migrations
{
    public partial class AddBuInventoryRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BuId",
                table: "Inventories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_BuId",
                table: "Inventories",
                column: "BuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_BUs_BuId",
                table: "Inventories",
                column: "BuId",
                principalTable: "BUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_BUs_BuId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_BuId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "BuId",
                table: "Inventories");
        }
    }
}
