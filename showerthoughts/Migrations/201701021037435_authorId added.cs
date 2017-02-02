namespace showerthoughts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authorIdadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.thoughts", "authorId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.thoughts", "authorId");
        }
    }
}
