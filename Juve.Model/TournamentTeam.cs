namespace Juve.Model
{
    public class TournamentTeam : BaseEntity
    {
        public int Games { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int Scored { get; set; }
        public int Missed { get; set; }

        public virtual Team Team { get; set; }
        public virtual Tournament Tournament { get; set; }
        public virtual Season Season { get; set; }
    }
}
