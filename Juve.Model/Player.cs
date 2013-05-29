using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Juve.Model
{
    public class Player : BaseEntity
    {
        public Player()
        {
            Rewards = new Collection<PlayerReward>();
        }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int TeamNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte[] Photo { get; set; }
        public int Height { get; set; }
        public string Note { get; set; }

        public PlayerType PlayerType { get; set; }
        public Team Team { get; set; }
        public Country Country { get; set; }

        public virtual ICollection<PlayerReward> Rewards { get; set; }
    }
}
