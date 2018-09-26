namespace CodeFirstDepozite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Credits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OpenDatetime = c.DateTime(nullable: false),
                        CloseDatetime = c.DateTime(),
                        Person_Id = c.Int(nullable: false),
                        Person_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("depozite.People", t => t.Person_Id1)
                .Index(t => t.Person_Id1);
            
            CreateTable(
                "depozite.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PasportNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Credits", "Person_Id1", "depozite.People");
            DropIndex("dbo.Credits", new[] { "Person_Id1" });
            DropTable("depozite.People");
            DropTable("dbo.Credits");
        }
    }
}
