using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprenticeTips.App.Models.Internal;
using Microsoft.AspNetCore.Mvc;

namespace ApprenticeTips.App.Controllers
{
    public class InternalController : BaseController<InternalController>
    {
        public IActionResult Index()
        {
            var vm = new InternalSearchViewModel
            {
                Routes = new List<RouteViewModel> {
                    new RouteViewModel { Id = -1, Name = "Any Route"},
                    new RouteViewModel { Id = 1, Name = "Agriculture, environmental and animal care" },
                    new RouteViewModel { Id = 2, Name = "Business and administration" },
                    new RouteViewModel { Id = 3, Name = "Care services" },
                    new RouteViewModel { Id = 4, Name = "Catering and hospitality" },
                    new RouteViewModel { Id = 5, Name = "Construction" },
                    new RouteViewModel { Id = 6, Name = "Creative and design" },
                    new RouteViewModel { Id = 7, Name = "Digital" },
                    new RouteViewModel { Id = 8, Name = "Education and childcare" },
                    new RouteViewModel { Id = 9, Name = "Engineering and manufacturing" },
                    new RouteViewModel { Id = 10, Name = "Hair and beauty" },
                    new RouteViewModel { Id = 11, Name = "Health and science" },
                    new RouteViewModel { Id = 12, Name = "Legal, finance and accounting" },
                    new RouteViewModel { Id = 13, Name = "Protective services" },
                    new RouteViewModel { Id = 14, Name = "Sales, marketing and procurement" },
                    new RouteViewModel { Id = 15, Name = "Transport and logistics" }

                },
                Status = new List<StatusViewModel> {
                    new StatusViewModel { Id = -1, Name = "Any Status" },
                    new StatusViewModel { Id = 1, Name = "Approved for delivery" },
                    new StatusViewModel { Id = 2, Name = "In development" },
                    new StatusViewModel { Id = 3, Name = "Retired" },
                    new StatusViewModel { Id = 4, Name = "Withdrawn" },
                    new StatusViewModel { Id = 4, Name = "Proposal in development" }
                },
                Levels = new List<LevelViewModel>
                {
                    new LevelViewModel{ Id = -1, Name = "Any Level" },
                    new LevelViewModel{ Id = 1, Name = "2" },
                    new LevelViewModel{ Id = 2, Name = "3" },
                    new LevelViewModel{ Id = 3, Name = "4" },
                    new LevelViewModel{ Id = 4, Name = "5" },
                    new LevelViewModel{ Id = 4, Name = "6" },
                    new LevelViewModel{ Id = 4, Name = "7" }
                },
                Durations = new List<DurationViewModel>
                {
                    new DurationViewModel{ Id = -1, Name = "Any Duration"},
                    new DurationViewModel{ Id = 1, Name = "0"},
                    new DurationViewModel{ Id = 2, Name = "12"},
                    new DurationViewModel{ Id = 3, Name = "13"},
                    new DurationViewModel{ Id = 4, Name = "14"},
                    new DurationViewModel{ Id = 5, Name = "15"},
                    new DurationViewModel{ Id = 6, Name = "16"},
                    new DurationViewModel{ Id = 7, Name = "18"},
                    new DurationViewModel{ Id = 8, Name = "21"},
                    new DurationViewModel{ Id = 9, Name = "22"},
                    new DurationViewModel{ Id = 10, Name = "24"},
                    new DurationViewModel{ Id = 11, Name = "26"},
                    new DurationViewModel{ Id = 12, Name = "27"},
                    new DurationViewModel{ Id = 13, Name = "30"},
                    new DurationViewModel{ Id = 14, Name = "33"},
                    new DurationViewModel{ Id = 15, Name = "34"},
                    new DurationViewModel{ Id = 16, Name = "36"},
                    new DurationViewModel{ Id = 17, Name = "38"},
                    new DurationViewModel{ Id = 18, Name = "42"},
                    new DurationViewModel{ Id = 19, Name = "48"},
                    new DurationViewModel{ Id = 20, Name = "54"},
                    new DurationViewModel{ Id = 21, Name = "60"},
                    new DurationViewModel{ Id = 22, Name = "66"}
                }
            };

            return View(vm);
        }
    }
}
