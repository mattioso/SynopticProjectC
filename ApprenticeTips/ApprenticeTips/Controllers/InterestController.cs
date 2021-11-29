using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprenticeTips.App.Models.Interest;
using Microsoft.AspNetCore.Mvc;

namespace ApprenticeTips.App.Controllers
{
    public class InterestController : Controller
    {
        public IActionResult Index()
        {
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

                ApprentishipCatagories = new List<ApprentishipCatagoryViewModel> { 
                    new ApprentishipCatagoryViewModel{ Id = 1, Name = "Test 1", Selected = false },
                    new ApprentishipCatagoryViewModel{ Id = 2, Name = "Test 2", Selected = false },
                    new ApprentishipCatagoryViewModel{ Id = 3, Name = "Test 3", Selected = false },
                    new ApprentishipCatagoryViewModel{ Id = 4, Name = "Test 4", Selected = false },
                    new ApprentishipCatagoryViewModel{ Id = 5, Name = "Test 5", Selected = false },
                    new ApprentishipCatagoryViewModel{ Id = 6, Name = "Test 6", Selected = false },
                    new ApprentishipCatagoryViewModel{ Id = 7, Name = "Test 7", Selected = false },
                    new ApprentishipCatagoryViewModel{ Id = 8, Name = "Test 8", Selected = false },
                    new ApprentishipCatagoryViewModel{ Id = 9, Name = "Test 9", Selected = false },
                    new ApprentishipCatagoryViewModel{ Id = 10, Name = "Test 10", Selected = false }
                },
            };

            return View(vm);
        }
    }
}
