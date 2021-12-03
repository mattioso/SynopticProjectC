using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApprenticeTips.App.Models.Internal
{
    public class InternalSearchViewModel
    {
        [Display(Name = "Route:")]
        public List<RouteViewModel> Routes { get; set; }
        public int? RouteId { get; set; }

        [Display(Name = "Status:")]
        public List<StatusViewModel> Status { get; set; }
        public int? StatusId { get; set; }

        [Display(Name = "Level:")]
        public List<LevelViewModel> Levels { get; set; }
        public int? LevelId { get; set; }

        [Display(Name = "Duration:")]
        public List<DurationViewModel> Durations { get; set; }
        public int? DurationId { get; set; }
    }
}
