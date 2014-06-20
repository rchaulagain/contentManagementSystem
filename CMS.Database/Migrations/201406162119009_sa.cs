namespace CMS.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
