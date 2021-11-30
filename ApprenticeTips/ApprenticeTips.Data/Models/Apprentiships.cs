using System;
using System.Collections.Generic;
using System.Text;

namespace ApprenticeTips.Data.Models
{
    public class Apprentiships
    {
        public int Id { get; set; }
        public string Route { get; set; }
        public string Name { get; set; }
        public string Refernece { get; set; }
        public int Level { get; set; }
        public string Funding { get; set; }
        public int Duration { get; set; }
        public int CoreOptions { get; set; }
        public string Eqa { get; set; }
        public string Link { get; set; }

    }
}
