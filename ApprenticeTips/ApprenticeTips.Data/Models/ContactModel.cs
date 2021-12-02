using System;
using System.Collections.Generic;
using System.Text;

namespace ApprenticeTips.Data.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PreviousLevel { get; set; }
        public int Agriculture { get; set; }
        public int Business { get; set; }
        public int Care { get; set; }
        public int Catering { get; set; }
        public int Construction { get; set; }
        public int Creative { get; set; }
        public int Digital { get; set; }
        public int Education { get; set; }
        public int Engineering { get; set; }
        public int Hair { get; set; }
        public int Health { get; set; }
        public int Legal { get; set; }
        public int Protective { get; set; }
        public int Sales { get; set; }
        public int Transport { get; set; }
        public string Comments { get; set; }
        public DateTime SubmitDate { get; set; }
        public string AsignedTo { get; set; }

    }
}
