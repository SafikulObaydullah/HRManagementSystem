using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice_Crud.Migrations
{
    /// <inheritdoc />
    public partial class branchBankRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBankBranches_tblBanks_IntBankId",
                table: "tblBankBranches");

            migrationBuilder.DropIndex(
                name: "IX_tblBankBranches_IntBankId",
                table: "tblBankBranches");

            migrationBuilder.DropColumn(
                name: "StrBankCode",
                table: "tblBankBranches");

            migrationBuilder.DropColumn(
                name: "StrBankName",
                table: "tblBankBranches");

            migrationBuilder.DropColumn(
                name: "StrBankShortName",
                table: "tblBankBranches");

            migrationBuilder.AlterColumn<string>(
                name: "IntActionBy",
                table: "tblBankBranches",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TblBankIntBankId",
                table: "tblBankBranches",
                type: "bigint",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBankBranches_tblBanks_TblBankIntBankId",
                table: "tblBankBranches");

            migrationBuilder.DropIndex(
                name: "IX_tblBankBranches_TblBankIntBankId",
                table: "tblBankBranches");

            migrationBuilder.DropColumn(
                name: "TblBankIntBankId",
                table: "tblBankBranches");

            migrationBuilder.AlterColumn<long>(
                name: "IntActionBy",
                table: "tblBankBranches",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StrBankCode",
                table: "tblBankBranches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StrBankName",
                table: "tblBankBranches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StrBankShortName",
                table: "tblBankBranches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
