using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FacturaInicial = table.Column<int>(type: "int", nullable: false),
                    FacturaFinal = table.Column<int>(type: "int", nullable: false),
                    FacturaActual = table.Column<int>(type: "int", nullable: false),
                    NroResolucion = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factura", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formatopago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreFormaPago = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formatopago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreMarca = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePais = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "presentacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePresentacion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presentacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rolpersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreRolPersona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolpersona", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipocontacto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipoContacto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipocontacto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipodocumento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipoDocumento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipodocumento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipomovinventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipoMovInventario = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipomovinventario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipopersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipoPersona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipopersona", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoProducto = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreProducto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdMarcaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_producto_marca_IdMarcaFk",
                        column: x => x.IdMarcaFk,
                        principalTable: "marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreDepartamento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPaisFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_departamento_pais_IdPaisFk",
                        column: x => x.IdPaisFk,
                        principalTable: "pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPersona = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePersona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateOnly>(type: "date", nullable: false),
                    IdTipoDocumentoFk = table.Column<int>(type: "int", nullable: false),
                    IdRolPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoPersonaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_persona_rolpersona_IdRolPersonaFk",
                        column: x => x.IdRolPersonaFk,
                        principalTable: "rolpersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_persona_tipodocumento_IdTipoDocumentoFk",
                        column: x => x.IdTipoDocumentoFk,
                        principalTable: "tipodocumento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_persona_tipopersona_IdTipoPersonaFk",
                        column: x => x.IdTipoPersonaFk,
                        principalTable: "tipopersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdInventario = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreInventario = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<double>(type: "double", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    StockMin = table.Column<int>(type: "int", nullable: false),
                    StockMax = table.Column<int>(type: "int", nullable: false),
                    IdCodProductoFk = table.Column<int>(type: "int", nullable: false),
                    IdPresentacionFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventario_presentacion_IdPresentacionFk",
                        column: x => x.IdPresentacionFk,
                        principalTable: "presentacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inventario_producto_IdCodProductoFk",
                        column: x => x.IdCodProductoFk,
                        principalTable: "producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCiudad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepartamentoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ciudad_departamento_IdDepartamentoFk",
                        column: x => x.IdDepartamentoFk,
                        principalTable: "departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contactopersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoContactoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactopersona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contactopersona_persona_IdPersonaFk",
                        column: x => x.IdPersonaFk,
                        principalTable: "persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contactopersona_tipocontacto_IdPersonaFk",
                        column: x => x.IdPersonaFk,
                        principalTable: "tipocontacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "movimientoinventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMovimientoInventario = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaMovimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaVencimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    IdFormaPagoFk = table.Column<int>(type: "int", nullable: false),
                    IdResponsableFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoMovInvFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimientoinventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movimientoinventario_formatopago_IdFormaPagoFk",
                        column: x => x.IdFormaPagoFk,
                        principalTable: "formatopago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movimientoinventario_persona_IdResponsableFk",
                        column: x => x.IdResponsableFk,
                        principalTable: "persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movimientoinventario_tipomovinventario_IdTipoMovInvFk",
                        column: x => x.IdTipoMovInvFk,
                        principalTable: "tipomovinventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ubicacionpersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoDeVia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroPri = table.Column<int>(type: "int", nullable: false),
                    Letra = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bis = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LetraSec = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cardinal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroSec = table.Column<int>(type: "int", nullable: false),
                    LetraTer = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroTer = table.Column<int>(type: "int", nullable: false),
                    CardinalSec = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoPostal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdCiudadFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ubicacionpersona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ubicacionpersona_ciudad_IdCiudadFk",
                        column: x => x.IdCiudadFk,
                        principalTable: "ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ubicacionpersona_persona_IdPersonaFk",
                        column: x => x.IdPersonaFk,
                        principalTable: "persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detallemovinventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<double>(type: "double", nullable: false),
                    IdInventarionFk = table.Column<int>(type: "int", nullable: false),
                    IdMovInvFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detallemovinventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detallemovinventario_inventario_IdInventarionFk",
                        column: x => x.IdInventarionFk,
                        principalTable: "inventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detallemovinventario_movimientoinventario_IdMovInvFk",
                        column: x => x.IdMovInvFk,
                        principalTable: "movimientoinventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ciudad_IdDepartamentoFk",
                table: "ciudad",
                column: "IdDepartamentoFk");

            migrationBuilder.CreateIndex(
                name: "IX_contactopersona_IdPersonaFk",
                table: "contactopersona",
                column: "IdPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_departamento_IdPaisFk",
                table: "departamento",
                column: "IdPaisFk");

            migrationBuilder.CreateIndex(
                name: "IX_detallemovinventario_IdInventarionFk",
                table: "detallemovinventario",
                column: "IdInventarionFk");

            migrationBuilder.CreateIndex(
                name: "IX_detallemovinventario_IdMovInvFk",
                table: "detallemovinventario",
                column: "IdMovInvFk");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_IdCodProductoFk",
                table: "inventario",
                column: "IdCodProductoFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_inventario_IdPresentacionFk",
                table: "inventario",
                column: "IdPresentacionFk");

            migrationBuilder.CreateIndex(
                name: "IX_movimientoinventario_IdFormaPagoFk",
                table: "movimientoinventario",
                column: "IdFormaPagoFk");

            migrationBuilder.CreateIndex(
                name: "IX_movimientoinventario_IdResponsableFk",
                table: "movimientoinventario",
                column: "IdResponsableFk");

            migrationBuilder.CreateIndex(
                name: "IX_movimientoinventario_IdTipoMovInvFk",
                table: "movimientoinventario",
                column: "IdTipoMovInvFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_IdRolPersonaFk",
                table: "persona",
                column: "IdRolPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_IdTipoDocumentoFk",
                table: "persona",
                column: "IdTipoDocumentoFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_IdTipoPersonaFk",
                table: "persona",
                column: "IdTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_producto_IdMarcaFk",
                table: "producto",
                column: "IdMarcaFk");

            migrationBuilder.CreateIndex(
                name: "IX_ubicacionpersona_IdCiudadFk",
                table: "ubicacionpersona",
                column: "IdCiudadFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ubicacionpersona_IdPersonaFk",
                table: "ubicacionpersona",
                column: "IdPersonaFk",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contactopersona");

            migrationBuilder.DropTable(
                name: "detallemovinventario");

            migrationBuilder.DropTable(
                name: "factura");

            migrationBuilder.DropTable(
                name: "ubicacionpersona");

            migrationBuilder.DropTable(
                name: "tipocontacto");

            migrationBuilder.DropTable(
                name: "inventario");

            migrationBuilder.DropTable(
                name: "movimientoinventario");

            migrationBuilder.DropTable(
                name: "ciudad");

            migrationBuilder.DropTable(
                name: "presentacion");

            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "formatopago");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "tipomovinventario");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropTable(
                name: "marca");

            migrationBuilder.DropTable(
                name: "rolpersona");

            migrationBuilder.DropTable(
                name: "tipodocumento");

            migrationBuilder.DropTable(
                name: "tipopersona");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
