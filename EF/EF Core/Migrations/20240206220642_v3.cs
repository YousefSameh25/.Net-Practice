using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "branchID",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Department_branchID",
                table: "Department",
                column: "branchID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Branches_branchID",
                table: "Department",
                column: "branchID",
                principalTable: "Branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Branches_branchID",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_branchID",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "branchID",
                table: "Department");
        }
    }
}
