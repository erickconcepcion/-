namespace Common.DataAccess.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "starter.Personas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Gustos = c.String(),
                        Comentarios = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("starter.Personas");
        }
    }
}
