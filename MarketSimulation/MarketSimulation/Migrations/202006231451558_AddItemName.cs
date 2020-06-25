namespace MarketSimulation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Name", c => c.String());
            AddColumn("dbo.Items", "Value", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Value");
            DropColumn("dbo.Items", "Name");
        }
    }
}
