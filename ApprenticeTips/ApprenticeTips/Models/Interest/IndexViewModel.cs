using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApprenticeTips.App.Models.Interest
{
    public class IndexViewModel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> PreviousQualifications { get; set; }
        public List<string> ApprentishipInterests { get; set; }
    }
}
