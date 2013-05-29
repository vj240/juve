using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Juve.Model
{
    public class Team : BaseEntity
    {
        [Required(ErrorMessageResourceName = "TeamNameErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "TeamName", ResourceType = typeof(Resources.ModelResources))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "YearOfFoundationErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "YearOfFoundation", ResourceType = typeof(Resources.ModelResources))]
        public int YearOfFoundation { get; set; }

        [Required(ErrorMessageResourceName = "CountryNameErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "CountryName", ResourceType = typeof(Resources.ModelResources))]
        public virtual Country Country { get; set; }

        public virtual ICollection<TeamReward> Rewards { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
