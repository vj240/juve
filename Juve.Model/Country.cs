using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Juve.Model
{
    public class Country : BaseEntity
    {
        [Required(ErrorMessageResourceName = "CountryNameErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "CountryName", ResourceType = typeof(Resources.ModelResources))]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
