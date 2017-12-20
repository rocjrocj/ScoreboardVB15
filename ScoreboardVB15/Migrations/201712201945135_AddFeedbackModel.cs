namespace ScoreboardVB15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFeedbackModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeedbackModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        Feedback = c.String(nullable: false),
                        FeedbackCreated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FeedbackModels");
        }
    }
}
