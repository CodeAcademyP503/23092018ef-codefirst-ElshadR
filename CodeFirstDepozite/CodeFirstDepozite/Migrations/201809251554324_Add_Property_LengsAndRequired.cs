namespace CodeFirstDepozite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Property_LengsAndRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("depozite.People", "Name", c => c.String(nullable: false, maxLength: 90));
            AlterColumn("depozite.People", "Surname", c => c.String(nullable: false, maxLength: 90));
            AlterColumn("depozite.People", "PasportNumber", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("depozite.People", "PasportNumber", c => c.String());
            AlterColumn("depozite.People", "Surname", c => c.String());
            AlterColumn("depozite.People", "Name", c => c.String());
        }
    }
}
