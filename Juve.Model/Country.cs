using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Juve.Model
{
    public class Country : BaseEntity
    {
        [Required(ErrorMessageResourceName = "CountryNameErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "CountryName", ResourceType = typeof(Resources.ModelResources))]
        public string Name { get; set; }

        [NotMapped]
        public ICollection<Player> Players { get; set; }
        [NotMapped]
        public ICollection<Team> Teams { get; set; }
    }
}
