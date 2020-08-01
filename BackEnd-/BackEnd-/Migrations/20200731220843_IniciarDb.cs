using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_.Migrations
{
    public partial class IniciarDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elemento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    TipoElemento = table.Column<int>(type: "int", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    TipoGrupo = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elemento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralCab",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdItemCab = table.Column<int>(type: "int", nullable: false),
                    IdTipo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    IdEstado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralCab", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Obra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoObra = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    NombreObra = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    IdPersonalCliente = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    NombreOferente = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    IdPersonalOferente = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    RegistroProfesional = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    IdProvincia = table.Column<int>(type: "int", nullable: false),
                    IdCiudad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProyecto = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    NumeroVivienda = table.Column<int>(type: "int", nullable: false),
                    CodigoObra = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rubro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoRubro = table.Column<int>(type: "int", nullable: false),
                    NombreRubro = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Unidad = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    PorcentajeTransporte = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElementoPrecio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicial = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    DistanciaKm = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    CostoKmXm3 = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    FechaIngMod = table.Column<DateTime>(type: "datetime", nullable: false),
                    ElementoId = table.Column<int>(nullable: false),
                    GeneralCabId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementoPrecio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementoPrecio_Elemento_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElementoPrecio_GeneralCab_GeneralCabId",
                        column: x => x.GeneralCabId,
                        principalTable: "GeneralCab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "General",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Auxiliar = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    GeneralCabId = table.Column<int>(nullable: true),
                    GeneraCablId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General", x => x.Id);
                    table.ForeignKey(
                        name: "FK_General_GeneralCab_GeneralCabId",
                        column: x => x.GeneralCabId,
                        principalTable: "GeneralCab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    RegistroProfesional = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    NombreCompleto = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Telefono1 = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Telefono2 = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    GeneralCabId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_GeneralCab_GeneralCabId",
                        column: x => x.GeneralCabId,
                        principalTable: "GeneralCab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObraProyecto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Observacion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Moneda = table.Column<decimal>(type: "money", nullable: false),
                    FechaCreacionProyecto = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProyectoId = table.Column<int>(nullable: false),
                    ObraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObraProyecto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObraProyecto_Obra_ObraId",
                        column: x => x.ObraId,
                        principalTable: "Obra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObraProyecto_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyecto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoRubro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Unidad = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "money", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "money", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    RubroId = table.Column<int>(nullable: false),
                    ProyectoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoRubro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProyectoRubro_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyecto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoRubro_Rubro_RubroId",
                        column: x => x.RubroId,
                        principalTable: "Rubro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RubroElemento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Unidad = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    CostoHora = table.Column<decimal>(type: "money", nullable: false),
                    Rendimiento = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Costo = table.Column<decimal>(type: "money", nullable: false),
                    TipoElemento = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Dias = table.Column<int>(type: "int", nullable: false),
                    RubroId = table.Column<int>(nullable: false),
                    ElementoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RubroElemento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RubroElemento_Elemento_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elemento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RubroElemento_Rubro_RubroId",
                        column: x => x.RubroId,
                        principalTable: "Rubro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    NombreUsuario = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Usuarios = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Clave = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementoPrecio_ElementoId",
                table: "ElementoPrecio",
                column: "ElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementoPrecio_GeneralCabId",
                table: "ElementoPrecio",
                column: "GeneralCabId");

            migrationBuilder.CreateIndex(
                name: "IX_General_GeneralCabId",
                table: "General",
                column: "GeneralCabId");

            migrationBuilder.CreateIndex(
                name: "IX_ObraProyecto_ObraId",
                table: "ObraProyecto",
                column: "ObraId");

            migrationBuilder.CreateIndex(
                name: "IX_ObraProyecto_ProyectoId",
                table: "ObraProyecto",
                column: "ProyectoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_GeneralCabId",
                table: "Persona",
                column: "GeneralCabId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoRubro_ProyectoId",
                table: "ProyectoRubro",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoRubro_RubroId",
                table: "ProyectoRubro",
                column: "RubroId");

            migrationBuilder.CreateIndex(
                name: "IX_RubroElemento_ElementoId",
                table: "RubroElemento",
                column: "ElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_RubroElemento_RubroId",
                table: "RubroElemento",
                column: "RubroId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PersonaId",
                table: "Usuario",
                column: "PersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElementoPrecio");

            migrationBuilder.DropTable(
                name: "General");

            migrationBuilder.DropTable(
                name: "ObraProyecto");

            migrationBuilder.DropTable(
                name: "ProyectoRubro");

            migrationBuilder.DropTable(
                name: "RubroElemento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Obra");

            migrationBuilder.DropTable(
                name: "Proyecto");

            migrationBuilder.DropTable(
                name: "Elemento");

            migrationBuilder.DropTable(
                name: "Rubro");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "GeneralCab");
        }
    }
}
