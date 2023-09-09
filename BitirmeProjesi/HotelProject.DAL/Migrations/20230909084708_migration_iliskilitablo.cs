using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtomasyonProject.DAL.Migrations
{
    public partial class migration_iliskilitablo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "Vouchers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_CurrentCardId",
                table: "Vouchers",
                column: "CurrentCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_StockId",
                table: "Vouchers",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherItems_StockID",
                table: "VoucherItems",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherItems_VoucherID",
                table: "VoucherItems",
                column: "VoucherID");

            migrationBuilder.CreateIndex(
                name: "IX_Plates_MarbleBlockId",
                table: "Plates",
                column: "MarbleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_MarbleBlocks_StockId",
                table: "MarbleBlocks",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarbleBlocks_Stocks_StockId",
                table: "MarbleBlocks",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "StockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plates_MarbleBlocks_MarbleBlockId",
                table: "Plates",
                column: "MarbleBlockId",
                principalTable: "MarbleBlocks",
                principalColumn: "MarbleBlockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoucherItems_Stocks_StockID",
                table: "VoucherItems",
                column: "StockID",
                principalTable: "Stocks",
                principalColumn: "StockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoucherItems_Vouchers_VoucherID",
                table: "VoucherItems",
                column: "VoucherID",
                principalTable: "Vouchers",
                principalColumn: "VoucherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_CurrentCards_CurrentCardId",
                table: "Vouchers",
                column: "CurrentCardId",
                principalTable: "CurrentCards",
                principalColumn: "CurrentCardId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_Stocks_StockId",
                table: "Vouchers",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarbleBlocks_Stocks_StockId",
                table: "MarbleBlocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Plates_MarbleBlocks_MarbleBlockId",
                table: "Plates");

            migrationBuilder.DropForeignKey(
                name: "FK_VoucherItems_Stocks_StockID",
                table: "VoucherItems");

            migrationBuilder.DropForeignKey(
                name: "FK_VoucherItems_Vouchers_VoucherID",
                table: "VoucherItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_CurrentCards_CurrentCardId",
                table: "Vouchers");

            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_Stocks_StockId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_Vouchers_CurrentCardId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_Vouchers_StockId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_VoucherItems_StockID",
                table: "VoucherItems");

            migrationBuilder.DropIndex(
                name: "IX_VoucherItems_VoucherID",
                table: "VoucherItems");

            migrationBuilder.DropIndex(
                name: "IX_Plates_MarbleBlockId",
                table: "Plates");

            migrationBuilder.DropIndex(
                name: "IX_MarbleBlocks_StockId",
                table: "MarbleBlocks");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Vouchers");
        }
    }
}
