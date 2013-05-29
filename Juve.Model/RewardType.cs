using System.Collections.Generic;

namespace Juve.Model
{
    public class RewardType : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<PlayerReward> PlayerRewards { get; set; }
        public ICollection<TeamReward> TeamRewards { get; set; }
    }
}
