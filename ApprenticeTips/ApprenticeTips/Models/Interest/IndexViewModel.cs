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
        public string FirstName { get; set; }

        [Display(Name = "Surname:")]
        public string Surname { get; set; }

        [Display(Name = "Email:")]
        public string Email { get; set; }

        [Display(Name = "Contact Number:")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Level of Previous qualification:")]
        public List<int> PreviousQualifications { get; set; }

        [Display(Name = "Please select the routes that interest you:")]
        public List<string> ApprentishipInterests { get; set; }
    }
}
