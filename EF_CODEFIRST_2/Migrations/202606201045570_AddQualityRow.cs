namespace EF_CODEFIRST_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQualityRow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quality", c => c.Long());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Quality");
        }
    }
}
