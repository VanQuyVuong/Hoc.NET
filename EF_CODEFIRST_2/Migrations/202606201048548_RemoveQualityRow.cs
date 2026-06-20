namespace EF_CODEFIRST_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveQualityRow : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Quality");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Quality", c => c.Long());
        }
    }
}
