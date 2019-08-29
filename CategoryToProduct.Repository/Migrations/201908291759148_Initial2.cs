namespace CategoryToProduct.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "DelitingDate", c => c.DateTime());
            AddColumn("dbo.Products", "DelitingDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DelitingDate");
            DropColumn("dbo.Categories", "DelitingDate");
        }
    }
}
