namespace ScoreboardVB15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMatchEnded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScoreboardVBModels", "MatchEnded", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScoreboardVBModels", "MatchEnded");
        }
    }
}
