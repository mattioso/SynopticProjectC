using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprenticeTips.App.Models.Interest;
using Microsoft.AspNetCore.Mvc;
using ApprenticeTips.Data;
using ApprenticeTips.Data.DataAccess;

namespace ApprenticeTips.App.Controllers
{
    public class InterestController : BaseController<InternalController>
    {
        public IActionResult Index()
        {
            var repo = new InternalDataRepo(DbContext);

            var vm = new IndexViewModel
            {
                PreviousQualificationLevels = new List<PreviousQualLevelViewModel> {
                    new PreviousQualLevelViewModel{ Level = 0, Name = "Not Applicable" },
                    new PreviousQualLevelViewModel{ Level = 1, Name = "Level 1" },
                    new PreviousQualLevelViewModel{ Level = 2, Name = "Level 2" },
                    new PreviousQualLevelViewModel{ Level = 3, Name = "Level 3" },
                    new PreviousQualLevelViewModel{ Level = 4, Name = "Level 4" },
                    new PreviousQualLevelViewModel{ Level = 5, Name = "Level 5" },
                    new PreviousQualLevelViewModel{ Level = 6, Name = "Level 6" },
                    new PreviousQualLevelViewModel{ Level = 7, Name = "Level 7" }
                },

            };

            return View(vm);
        }
    }
}
