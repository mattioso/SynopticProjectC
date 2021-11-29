using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprenticeTips.App.Models.Internal;
using Microsoft.AspNetCore.Mvc;

namespace ApprenticeTips.App.Controllers
{
    public class InternalController : Controller
    {
        public IActionResult Index()
        {
            var vm = new InternalSearchViewModel
            {
                Routes = new List<RouteViewModel> {
                    new RouteViewModel { Id = 1, Name = "Route 1" },
                    new RouteViewModel { Id = 2, Name = "Route 2" },
                    new RouteViewModel { Id = 3, Name = "Route 3" },
                    new RouteViewModel { Id = 4, Name = "Route 4" }
                },
                Status = new List<StatusViewModel> { 
                    new StatusViewModel { Id = 1, Name = "Status 1" },
                    new StatusViewModel { Id = 2, Name = "Status 2" },
                    new StatusViewModel { Id = 3, Name = "Status 3" },
                    new StatusViewModel { Id = 4, Name = "Status 4" },
                },
                Levels = new List<LevelViewModel>
                {
                    new LevelViewModel{ Id = 1, Name = "Level 1" },
                    new LevelViewModel{ Id = 2, Name = "Level 2" },
                    new LevelViewModel{ Id = 3, Name = "Level 3" },
                    new LevelViewModel{ Id = 4, Name = "Level 4" }
                },
                Durations = new List<DurationViewModel>
                {
                    new DurationViewModel{ Id = 1, Name = "Duration 1"},
                    new DurationViewModel{ Id = 2, Name = "Duration 2"},
                    new DurationViewModel{ Id = 3, Name = "Duration 3"},
                    new DurationViewModel{ Id = 4, Name = "Duration 4"},
                }
            };

            return View(vm);
        }
    }
}
