using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApprenticeTips.App.Models.Interest
{
    public class IndexViewModel
    {
        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "Firstname:")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [Display(Name = "Surname:")]
        [StringLength(30)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [Display(Name = "Email:")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact Number is required")]
        [Display(Name = "Contact Number:")]
        [Phone]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(800)]
        public string Comments { get; set; }

        [Display(Name = "Level of Previous qualification:")]
        public List<PreviousQualLevelViewModel> PreviousQualificationLevels { get; set; }
        
        [Display(Name = "Agriculture, environmental and animal care")]
        public bool Agriculture { get; set; }

        [Display(Name = "Business and administration")]
        public bool Business { get; set; }

        [Display(Name = "Care services")]
        public bool Care { get; set; }

        [Display(Name = "Catering and hospitality")]
        public bool Catering { get; set; }

        [Display(Name = "Construction")]
        public bool Construction { get; set; }

        [Display(Name = "Creative and design")]
        public bool Creative { get; set; }

        [Display(Name = "Digital")]
        public bool Digital { get; set; }

        [Display(Name = "Education and childcare")]
        public bool Education { get; set; }

        [Display(Name = "Engineering and manufacturing")]
        public bool Engineering { get; set; }

        [Display(Name = "Hair and beauty")]
        public bool Hair { get; set; }

        [Display(Name = "Health and science")]
        public bool Health { get; set; }

        [Display(Name = "Legal, finance and accounting")]
        public bool Legal { get; set; }

        [Display(Name = "Protective services")]
        public bool Protective { get; set; }

        [Display(Name = "Sales, marketing and procurement")]
        public bool Sales { get; set; }

        [Display(Name = "Transport and logistics")]
        public bool Transport { get; set; }

        public int? PreviousQualificationsLevel { get; set; }
    }
}
