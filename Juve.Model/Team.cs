using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Juve.Model
{
    public class Team : BaseEntity
    {
        [Required(ErrorMessageResourceName = "TeamNameErrorMessage", ErrorMessageResourceType = typeof(Juve.Model.Resources.ModelResources))]
        [Display(Name = "TeamName", ResourceType = typeof(Juve.Model.Resources.ModelResources))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "YearOfFoundationErrorMessage", ErrorMessageResourceType = typeof(Juve.Model.Resources.ModelResources))]
        [Display(Name = "YearOfFoundation", ResourceType = typeof(Juve.Model.Resources.ModelResources))]
        public int YearOfFoundation { get; set; }

        [Required(ErrorMessageResourceName = "CountryNameErrorMessage", ErrorMessageResourceType = typeof(Juve.Model.Resources.ModelResources))]
        [Display(Name = "CountryName", ResourceType = typeof(Juve.Model.Resources.ModelResources))]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        public virtual ICollection<TeamReward> Rewards { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
