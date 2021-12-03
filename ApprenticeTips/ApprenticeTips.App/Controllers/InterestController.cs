using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprenticeTips.App.Models.Interest;
using Microsoft.AspNetCore.Mvc;
using ApprenticeTips.Data;
using ApprenticeTips.Data.Models;
using ApprenticeTips.Data.DataAccess;

namespace ApprenticeTips.App.Controllers
{
    public class InterestController : BaseController<InternalController>
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

            };

            return View("Index", vm);
        }

        public IActionResult Thanks()
        {
            return View("Thanks");
        }

        [HttpPost]
        public InterestReturnViewModel GetInterestData(IndexViewModel vm)
        {
            var repo = new InterestDataRepo(DbContext);
            var returnVm = new InterestReturnViewModel();

            var dataModel = new ContactModel
            {
                FirstName = vm.FirstName,
                Surname = vm.Surname,
                Email = vm.Email,
                Phone = vm.PhoneNumber,
                PreviousLevel = (int) vm.PreviousQualificationsLevel,
                Agriculture = Convert.ToInt32(vm.Agriculture),
                Business = Convert.ToInt32(vm.Business),
                Care = Convert.ToInt32(vm.Care),
                Catering = Convert.ToInt32(vm.Catering),
                Construction = Convert.ToInt32(vm.Construction),
                Creative = Convert.ToInt32(vm.Creative),
                Digital = Convert.ToInt32(vm.Digital),
                Education = Convert.ToInt32(vm.Education),
                Engineering = Convert.ToInt32(vm.Engineering),
                Hair = Convert.ToInt32(vm.Hair),
                Health = Convert.ToInt32(vm.Health),
                Legal = Convert.ToInt32(vm.Legal),
                Protective = Convert.ToInt32(vm.Protective),
                Sales = Convert.ToInt32(vm.Sales),
                Transport = Convert.ToInt32(vm.Transport),
                Comments = vm.Comments,
                SubmitDate = DateTime.Now
            };

            var suceeded = repo.RegisterInterest(dataModel);
            if(suceeded)
            {
                return new InterestReturnViewModel
                {
                    Success = true,
                    Error = ""
                };
            }
            else
            {
                return new InterestReturnViewModel
                {
                    Success = false,
                    Error = "There was an issue connecting to the database, please try again later"
                };
            }
        }
    }
}
