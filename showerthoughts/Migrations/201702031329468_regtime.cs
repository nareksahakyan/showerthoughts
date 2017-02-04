namespace showerthoughts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class regtime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "registrationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "registrationDate");
        }
    }
}
