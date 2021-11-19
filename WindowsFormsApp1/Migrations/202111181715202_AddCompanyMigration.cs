namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Phones", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Phones", "Price");
        }
    }
}
