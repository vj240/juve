using System.Collections.Generic;

namespace Juve.Model
{
    public class Tournament : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Season> Seasons { get; set; }
    }
}
