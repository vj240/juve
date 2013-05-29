using System.Data.Entity;
using Juve.Model;

namespace Juve.Data
{
    public class JuveContext : DbContext
    {
        #region DbSets

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<PlayerReward> PlayerRewards { get; set; }

        public DbSet<PlayerType> PlayerTypes { get; set; }

        public DbSet<RewardType> RewardTypes { get; set; }

        public DbSet<Season> Seasons { get; set; }

        public DbSet<TeamReward> TeamRewards { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        public DbSet<TournamentTeam> TournamentTeams { get; set; }

        #endregion


        public JuveContext(string connectionString) : base(connectionString)
        {
            
        }

        public JuveContext() :base()
        {

            //var rep = new PlayerTypesRepository(this);
            //var pt = new PlayerType();

            //rep.AddItem(pt);

        }
    }
}
