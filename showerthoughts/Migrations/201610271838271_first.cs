namespace showerthoughts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.thoughts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        bdText = c.String(),
                        date = c.DateTime(nullable: false),
                        rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.thoughts");
        }
    }
}
