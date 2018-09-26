namespace CodeFirstDepozite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Property_Required : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Credits", newSchema: "depozite");
        }
        
        public override void Down()
        {
            MoveTable(name: "depozite.Credits", newSchema: "dbo");
        }
    }
}
