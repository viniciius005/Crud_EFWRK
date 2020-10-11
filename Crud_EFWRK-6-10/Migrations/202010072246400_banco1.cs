namespace Crud_EFWRK_6_10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agenda", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Agenda", "CPF");
        }
    }
}
