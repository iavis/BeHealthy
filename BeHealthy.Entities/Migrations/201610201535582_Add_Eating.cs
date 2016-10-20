namespace BeHealthy.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Eating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "Protein", c => c.Double(nullable: false));
            AddColumn("dbo.Foods", "Carbohydrate", c => c.Double(nullable: false));
            AddColumn("dbo.Foods", "Fat", c => c.Double(nullable: false));
            AddColumn("dbo.Foods", "Caloric", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "Caloric");
            DropColumn("dbo.Foods", "Fat");
            DropColumn("dbo.Foods", "Carbohydrate");
            DropColumn("dbo.Foods", "Protein");
        }
    }
}
