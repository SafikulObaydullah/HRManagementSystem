using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRM_API.Migrations
{
    /// <inheritdoc />
    public partial class TblBank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBankBranches_tblBanks_TblBankIntBankId",
                table: "tblBankBranches");

            migrationBuilder.DropIndex(
                name: "IX_tblBankBranches_TblBankIntBankId",
                table: "tblBankBranches");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90a2d937-90b4-4dff-8f89-2a7bede57a08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d548431d-aa88-4ffd-bdb1-2d0cfe8390e0");

            migrationBuilder.DropColumn(
                name: "TblBankIntBankId",
                table: "tblBankBranches");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cefdea51-b6fc-4cb6-9558-6a77be441620", null, "User", "USER" },
                    { "fdd776b7-b97a-49c5-b68d-0c98843f5796", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblBankBranches_IntBankId",
                table: "tblBankBranches",
                column: "IntBankId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblBankBranches_tblBanks_IntBankId",
                table: "tblBankBranches",
                column: "IntBankId",
                principalTable: "tblBanks",
                principalColumn: "IntBankId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBankBranches_tblBanks_IntBankId",
                table: "tblBankBranches");

            migrationBuilder.DropIndex(
                name: "IX_tblBankBranches_IntBankId",
                table: "tblBankBranches");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cefdea51-b6fc-4cb6-9558-6a77be441620");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdd776b7-b97a-49c5-b68d-0c98843f5796");

            migrationBuilder.AddColumn<long>(
                name: "TblBankIntBankId",
                table: "tblBankBranches",
                type: "bigint",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "90a2d937-90b4-4dff-8f89-2a7bede57a08", null, "User", "USER" },
                    { "d548431d-aa88-4ffd-bdb1-2d0cfe8390e0", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblBankBranches_TblBankIntBankId",
                table: "tblBankBranches",
                column: "TblBankIntBankId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblBankBranches_tblBanks_TblBankIntBankId",
                table: "tblBankBranches",
                column: "TblBankIntBankId",
                principalTable: "tblBanks",
                principalColumn: "IntBankId");
        }
    }
}
