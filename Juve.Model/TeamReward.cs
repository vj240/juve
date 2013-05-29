namespace Juve.Model
{
    public class TeamReward : BaseEntity
    {
        public int Year { get; set; }

        public virtual Team Team { get; set; }
        public virtual RewardType RewardType { get; set; }
    }
}
