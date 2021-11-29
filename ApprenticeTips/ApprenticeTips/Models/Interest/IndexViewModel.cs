using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApprenticeTips.App.Models.Interest
{
    public class IndexViewModel
    {
        [Display(Name = "Firstname:")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Display(Name = "Surname:")]
        [StringLength(30)]
        public string Surname { get; set; }

        [Display(Name = "Email:")]
        [StringLength(50)]
        public string Email { get; set; }
        
        [Display(Name = "Contact Number:")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(800)]
        public string Comments { get; set; }

        [Display(Name = "Level of Previous qualification:")]
        public List<PreviousQualLevelViewModel> PreviousQualificationLevels { get; set; }

        [Display(Name = "Please select the routes that interest you:")]
        public List<ApprentishipCatagoryViewModel> ApprentishipCatagories { get; set; }

        public int? PreviousQualificationsLevel { get; set; }
        public List<int> ApprentishipCatagoriesId { get; set; }
    }
}
