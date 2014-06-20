namespace CMS.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sa1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Company", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Address1", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Address2", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Title", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Contacts", "Title", c => c.String());
            AlterColumn("dbo.Contacts", "City", c => c.String());
            AlterColumn("dbo.Contacts", "State", c => c.String());
            AlterColumn("dbo.Contacts", "Address2", c => c.String());
            AlterColumn("dbo.Contacts", "Address1", c => c.String());
            AlterColumn("dbo.Contacts", "Company", c => c.String());
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
        }
    }
}
