namespace ScoreboardVB15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ScoreboardVBModels", "HomeScore", c => c.Int());
            AlterColumn("dbo.ScoreboardVBModels", "GuestScore", c => c.Int());
            AlterColumn("dbo.ScoreboardVBModels", "SetNumber", c => c.Int());
            AlterColumn("dbo.ScoreboardVBModels", "MatchCreated", c => c.DateTime());
            AlterColumn("dbo.ScoreboardVBModels", "MatchUpdated", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ScoreboardVBModels", "MatchUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ScoreboardVBModels", "MatchCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ScoreboardVBModels", "SetNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.ScoreboardVBModels", "GuestScore", c => c.Int(nullable: false));
            AlterColumn("dbo.ScoreboardVBModels", "HomeScore", c => c.Int(nullable: false));
        }
    }
}
