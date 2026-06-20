namespace EF_CODEFIRST_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQualityNotNull : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quality", c => c.Long(nullable: false, defaultValue: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Quality");
        }
    }
}
