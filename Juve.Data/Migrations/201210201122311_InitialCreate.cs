namespace Juve.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        YearOfFoundation = c.Int(nullable: false),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        TeamNumber = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Photo = c.Binary(),
                        Height = c.Int(nullable: false),
                        Note = c.String(),
                        PlayerType_Id = c.Int(),
                        Team_Id = c.Int(),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerTypes", t => t.PlayerType_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.PlayerType_Id)
                .Index(t => t.Team_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.PlayerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayerRewards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Player_Id = c.Int(),
                        RewardType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .ForeignKey("dbo.RewardTypes", t => t.RewardType_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.RewardType_Id);
            
            CreateTable(
                "dbo.RewardTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamRewards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Team_Id = c.Int(),
                        RewardType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.RewardTypes", t => t.RewardType_Id)
                .Index(t => t.Team_Id)
                .Index(t => t.RewardType_Id);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Tournament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id)
                .Index(t => t.Tournament_Id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TournamentTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Games = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                        Wins = c.Int(nullable: false),
                        Draws = c.Int(nullable: false),
                        Losses = c.Int(nullable: false),
                        Scored = c.Int(nullable: false),
                        Missed = c.Int(nullable: false),
                        Team_Id = c.Int(),
                        Tournament_Id = c.Int(),
                        Season_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id)
                .ForeignKey("dbo.Seasons", t => t.Season_Id)
                .Index(t => t.Team_Id)
                .Index(t => t.Tournament_Id)
                .Index(t => t.Season_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TournamentTeams", new[] { "Season_Id" });
            DropIndex("dbo.TournamentTeams", new[] { "Tournament_Id" });
            DropIndex("dbo.TournamentTeams", new[] { "Team_Id" });
            DropIndex("dbo.Seasons", new[] { "Tournament_Id" });
            DropIndex("dbo.TeamRewards", new[] { "RewardType_Id" });
            DropIndex("dbo.TeamRewards", new[] { "Team_Id" });
            DropIndex("dbo.PlayerRewards", new[] { "RewardType_Id" });
            DropIndex("dbo.PlayerRewards", new[] { "Player_Id" });
            DropIndex("dbo.Players", new[] { "Country_Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Players", new[] { "PlayerType_Id" });
            DropIndex("dbo.Teams", new[] { "Country_Id" });
            DropForeignKey("dbo.TournamentTeams", "Season_Id", "dbo.Seasons");
            DropForeignKey("dbo.TournamentTeams", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.TournamentTeams", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Seasons", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.TeamRewards", "RewardType_Id", "dbo.RewardTypes");
            DropForeignKey("dbo.TeamRewards", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.PlayerRewards", "RewardType_Id", "dbo.RewardTypes");
            DropForeignKey("dbo.PlayerRewards", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Players", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "PlayerType_Id", "dbo.PlayerTypes");
            DropForeignKey("dbo.Teams", "Country_Id", "dbo.Countries");
            DropTable("dbo.TournamentTeams");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Seasons");
            DropTable("dbo.TeamRewards");
            DropTable("dbo.RewardTypes");
            DropTable("dbo.PlayerRewards");
            DropTable("dbo.PlayerTypes");
            DropTable("dbo.Players");
            DropTable("dbo.Countries");
            DropTable("dbo.Teams");
        }
    }
}
