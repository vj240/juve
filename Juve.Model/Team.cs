using System.Collections.Generic;

namespace Juve.Model
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public int YearOfFoundation { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<TeamReward> Rewards { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
