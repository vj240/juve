using System;

namespace Juve.Model
{
    public class Season : BaseEntity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Tournament Tournament { get; set; }
    }
}
