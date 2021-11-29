using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApprenticeTips.App.Models.Internal
{
    public class InternalSearchViewModel
    {
        public List<RouteViewModel> Routes { get; set; }
        public int RouteId { get; set; }

        public List<StatusViewModel> Status { get; set; }
        public int StatusId { get; set; }

        public List<LevelViewModel> Level { get; set; }
        public int LevelId { get; set; }

        public List<DurationViewModel> Duration { get; set; }
        public int DurationId { get; set; }
    }
}
