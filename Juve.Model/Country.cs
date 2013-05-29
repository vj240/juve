using System.Collections.Generic;

namespace Juve.Model
{
    public class Country : BaseEntity
    {
        public int Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
