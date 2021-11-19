namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ScreenSize = c.Double(nullable: false),
                        MemorySize = c.Int(nullable: false),
                        Nfc = c.Boolean(nullable: false),
                        BatterySize = c.Int(nullable: false),
                        CameraMp = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phones");
        }
    }
}
