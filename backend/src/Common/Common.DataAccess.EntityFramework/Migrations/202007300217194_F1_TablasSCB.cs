namespace Common.DataAccess.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class F1_TablasSCB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "starter.ElementoPrecio",
                c => new
                    {
                        IdElementoPrecio = c.Int(nullable: false, identity: true),
                        FechaInicial = c.DateTime(nullable: false),
                        FechaFinal = c.DateTime(nullable: false),
                        Valor = c.Int(nullable: false),
                        DistanciaKm = c.String(),
                        CostoKmXm3 = c.String(),
                        FechaIngMod = c.DateTime(nullable: false),
                        ElementoId = c.Int(nullable: false),
                        GeneralCabId = c.Int(nullable: false),
                        GeneralCab_IdListaCab = c.Int(),
                    })
                .PrimaryKey(t => t.IdElementoPrecio)
                .ForeignKey("starter.Elemento", t => t.ElementoId, cascadeDelete: true)
                .ForeignKey("starter.GeneralCab", t => t.GeneralCab_IdListaCab)
                .Index(t => t.ElementoId)
                .Index(t => t.GeneralCab_IdListaCab);
            
            CreateTable(
                "starter.Elemento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        TipoElemento = c.Int(nullable: false),
                        Unidad = c.String(),
                        TipoGrupo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "starter.GeneralCab",
                c => new
                    {
                        IdListaCab = c.Int(nullable: false, identity: true),
                        IdItemCab = c.Int(nullable: false),
                        IdTipo = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Observacion = c.String(),
                        IdEstado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdListaCab);
            
            CreateTable(
                "starter.General",
                c => new
                    {
                        IdLista = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Observacion = c.String(),
                        Auxiliar = c.String(),
                        GeneraCablId = c.Int(nullable: false),
                        GeneralCab_IdListaCab = c.Int(),
                    })
                .PrimaryKey(t => t.IdLista)
                .ForeignKey("starter.GeneralCab", t => t.GeneralCab_IdListaCab)
                .Index(t => t.GeneralCab_IdListaCab);
            
            CreateTable(
                "starter.ObraProyecto",
                c => new
                    {
                        IdObraProyecto = c.Int(nullable: false, identity: true),
                        Observacion = c.String(),
                        Moneda = c.Decimal(nullable: false, storeType: "money"),
                        FechaCreacionProyecto = c.DateTime(nullable: false),
                        ProyectoId = c.Int(nullable: false),
                        ObraId = c.Int(nullable: false),
                        Obra_IdObra = c.Int(),
                    })
                .PrimaryKey(t => t.IdObraProyecto)
                .ForeignKey("starter.Obra", t => t.Obra_IdObra)
                .Index(t => t.Obra_IdObra);
            
            CreateTable(
                "starter.Obra",
                c => new
                    {
                        IdObra = c.Int(nullable: false, identity: true),
                        CodigoObra = c.String(),
                        NombreObra = c.String(),
                        FechaCreacion = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        NombreCliente = c.String(),
                        IdPersonalCliente = c.String(),
                        NombreOferente = c.String(),
                        IdPersonalOferente = c.String(),
                        RegistroProfesional = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.IdObra);
            
            CreateTable(
                "starter.Proyecto",
                c => new
                    {
                        IdProyecto = c.Int(nullable: false),
                        NombreProyecto = c.String(),
                        NumeroVivienda = c.Int(nullable: false),
                        CodigoObra = c.String(),
                    })
                .PrimaryKey(t => t.IdProyecto)
                .ForeignKey("starter.ObraProyecto", t => t.IdProyecto)
                .Index(t => t.IdProyecto);
            
            CreateTable(
                "starter.Persona",
                c => new
                    {
                        IdPersona = c.Int(nullable: false, identity: true),
                        Identificacion = c.String(),
                        RegistroProfesional = c.String(),
                        NombreCompleto = c.String(),
                        Direccion = c.String(),
                        Telefono1 = c.String(),
                        Telefono2 = c.String(),
                        Email = c.String(),
                        Estado = c.Boolean(nullable: false),
                        GeneralCabId = c.Int(nullable: false),
                        GeneralCab_IdListaCab = c.Int(),
                    })
                .PrimaryKey(t => t.IdPersona)
                .ForeignKey("starter.GeneralCab", t => t.GeneralCab_IdListaCab)
                .Index(t => t.GeneralCab_IdListaCab);
            
            CreateTable(
                "starter.ProyectoRubro",
                c => new
                    {
                        IdProyectosRubros = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Unidad = c.String(),
                        Cantidad = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, storeType: "money"),
                        PrecioTotal = c.Decimal(nullable: false, storeType: "money"),
                        Porcentaje = c.Int(nullable: false),
                        RubroId = c.Int(nullable: false),
                        ProyectoId = c.Int(nullable: false),
                        Proyecto_IdProyecto = c.Int(),
                        Rubro_IdRubro = c.Int(),
                    })
                .PrimaryKey(t => t.IdProyectosRubros)
                .ForeignKey("starter.Proyecto", t => t.Proyecto_IdProyecto)
                .ForeignKey("starter.Rubro", t => t.Rubro_IdRubro)
                .Index(t => t.Proyecto_IdProyecto)
                .Index(t => t.Rubro_IdRubro);
            
            CreateTable(
                "starter.Rubro",
                c => new
                    {
                        IdRubro = c.Int(nullable: false, identity: true),
                        TipoRubro = c.Int(nullable: false),
                        NombreRubro = c.String(),
                        Observacion = c.String(),
                        Unidad = c.String(),
                        Estado = c.Boolean(nullable: false),
                        PorcentajeTransporte = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.IdRubro);
            
            CreateTable(
                "starter.RobroElemento",
                c => new
                    {
                        IdRubroElemento = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Unidad = c.String(),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CostoHora = c.Decimal(nullable: false, storeType: "money"),
                        Rendimiento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Costo = c.Decimal(nullable: false, storeType: "money"),
                        TipoElemento = c.String(),
                        Dias = c.Int(nullable: false),
                        RubroId = c.Int(nullable: false),
                        ElementoId = c.Int(nullable: false),
                        Rubro_IdRubro = c.Int(),
                    })
                .PrimaryKey(t => t.IdRubroElemento)
                .ForeignKey("starter.Elemento", t => t.ElementoId, cascadeDelete: true)
                .ForeignKey("starter.Rubro", t => t.Rubro_IdRubro)
                .Index(t => t.ElementoId)
                .Index(t => t.Rubro_IdRubro);
            
        }
        
        public override void Down()
        {
            DropForeignKey("starter.RobroElemento", "Rubro_IdRubro", "starter.Rubro");
            DropForeignKey("starter.RobroElemento", "ElementoId", "starter.Elemento");
            DropForeignKey("starter.ProyectoRubro", "Rubro_IdRubro", "starter.Rubro");
            DropForeignKey("starter.ProyectoRubro", "Proyecto_IdProyecto", "starter.Proyecto");
            DropForeignKey("starter.Persona", "GeneralCab_IdListaCab", "starter.GeneralCab");
            DropForeignKey("starter.Proyecto", "IdProyecto", "starter.ObraProyecto");
            DropForeignKey("starter.ObraProyecto", "Obra_IdObra", "starter.Obra");
            DropForeignKey("starter.General", "GeneralCab_IdListaCab", "starter.GeneralCab");
            DropForeignKey("starter.ElementoPrecio", "GeneralCab_IdListaCab", "starter.GeneralCab");
            DropForeignKey("starter.ElementoPrecio", "ElementoId", "starter.Elemento");
            DropIndex("starter.RobroElemento", new[] { "Rubro_IdRubro" });
            DropIndex("starter.RobroElemento", new[] { "ElementoId" });
            DropIndex("starter.ProyectoRubro", new[] { "Rubro_IdRubro" });
            DropIndex("starter.ProyectoRubro", new[] { "Proyecto_IdProyecto" });
            DropIndex("starter.Persona", new[] { "GeneralCab_IdListaCab" });
            DropIndex("starter.Proyecto", new[] { "IdProyecto" });
            DropIndex("starter.ObraProyecto", new[] { "Obra_IdObra" });
            DropIndex("starter.General", new[] { "GeneralCab_IdListaCab" });
            DropIndex("starter.ElementoPrecio", new[] { "GeneralCab_IdListaCab" });
            DropIndex("starter.ElementoPrecio", new[] { "ElementoId" });
            DropTable("starter.RobroElemento");
            DropTable("starter.Rubro");
            DropTable("starter.ProyectoRubro");
            DropTable("starter.Persona");
            DropTable("starter.Proyecto");
            DropTable("starter.Obra");
            DropTable("starter.ObraProyecto");
            DropTable("starter.General");
            DropTable("starter.GeneralCab");
            DropTable("starter.Elemento");
            DropTable("starter.ElementoPrecio");
        }
    }
}
