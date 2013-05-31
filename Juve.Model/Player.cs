using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Juve.Model
{
    public class Player : BaseEntity
    {
        public Player()
        {
            Rewards = new Collection<PlayerReward>();
        }

        [Required(ErrorMessageResourceName = "PlayerNameErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "PlayerName", ResourceType = typeof(Resources.ModelResources))]
        public string Name { get; set; }


        [Required(ErrorMessageResourceName = "BirthDateErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "BirthDate", ResourceType = typeof(Resources.ModelResources))]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessageResourceName = "TeamNumberErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "TeamNumber", ResourceType = typeof(Resources.ModelResources))]
        public int TeamNumber { get; set; }

        [Required(ErrorMessageResourceName = "StartDateErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "StartDate", ResourceType = typeof(Resources.ModelResources))]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Display(Name = "EndDate", ResourceType = typeof(Resources.ModelResources))]
        [DataType(DataType.DateTime)]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Photo", ResourceType = typeof(Resources.ModelResources))]
        public byte[] Photo { get; set; }

        [Display(Name = "Height", ResourceType = typeof(Resources.ModelResources))]
        public int Height { get; set; }

        [Display(Name = "Note", ResourceType = typeof(Resources.ModelResources))]
        public string Note { get; set; }

        [Required(ErrorMessageResourceName = "PlayerNameErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "PlayerName", ResourceType = typeof(Resources.ModelResources))]
        public int PlayerTypeId { get; set; }

        [Required(ErrorMessageResourceName = "TeamNameErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "TeamName", ResourceType = typeof(Resources.ModelResources))]
        public int TeamId { get; set; }

        [Required(ErrorMessageResourceName = "CountryNameErrorMessage", ErrorMessageResourceType = typeof(Resources.ModelResources))]
        [Display(Name = "CountryName", ResourceType = typeof(Resources.ModelResources))]
        public int CountryId { get; set; }

        [ForeignKey("PlayerTypeId")]
        public virtual PlayerType PlayerType { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        [NotMapped]
        public virtual ICollection<PlayerReward> Rewards { get; set; }
    }
}
