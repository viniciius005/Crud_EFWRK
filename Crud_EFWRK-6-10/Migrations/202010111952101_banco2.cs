namespace Crud_EFWRK_6_10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalaAulas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Professor = c.String(),
                        Sala = c.String(),
                        Curso = c.String(),
                        Data = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SalaAulas");
        }
    }
}
