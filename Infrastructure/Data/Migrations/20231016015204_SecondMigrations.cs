using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdFacturaFk",
                table: "movimientoinventario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_movimientoinventario_IdFacturaFk",
                table: "movimientoinventario",
                column: "IdFacturaFk");

            migrationBuilder.AddForeignKey(
                name: "FK_movimientoinventario_factura_IdFacturaFk",
                table: "movimientoinventario",
                column: "IdFacturaFk",
                principalTable: "factura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimientoinventario_factura_IdFacturaFk",
                table: "movimientoinventario");

            migrationBuilder.DropIndex(
                name: "IX_movimientoinventario_IdFacturaFk",
                table: "movimientoinventario");

            migrationBuilder.DropColumn(
                name: "IdFacturaFk",
                table: "movimientoinventario");
        }
    }
}
