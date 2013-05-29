namespace Juve.Model
{
    public class PlayerReward : BaseEntity
    {
        public int Year { get; set; }

        public virtual Player Player { get; set; }
        public virtual RewardType RewardType { get; set; }
    }
}
