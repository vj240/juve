using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Juve.Model
{
    public class PlayerType : BaseEntity
    {
        [Required(ErrorMessageResourceName = "PlayerTypeNameErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "PlayerTypeName", ResourceType = typeof(Resources.ModelResources))]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
