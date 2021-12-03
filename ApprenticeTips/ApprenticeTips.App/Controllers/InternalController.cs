using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprenticeTips.App.Models.Internal;
using ApprenticeTips.Data.DataAccess;
using ApprenticeTips.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApprenticeTips.App.Controllers
{
    public class InternalController : BaseController<InternalController>
    {

        private List<RouteViewModel> Routes { get; set; }
        private List<StatusViewModel> Status { get; set; }
        private List<LevelViewModel> Levels { get; set; }
        private List<DurationViewModel> Durations { get; set; }

        public InternalController()
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

                };

            Status = new List<StatusViewModel> {
                new StatusViewModel { Id = -1, Name = "Any Status" },
                new StatusViewModel { Id = 1, Name = "Approved for delivery" },
                new StatusViewModel { Id = 2, Name = "In development" },
                new StatusViewModel { Id = 3, Name = "Retired" },
                new StatusViewModel { Id = 4, Name = "Withdrawn" },
                new StatusViewModel { Id = 4, Name = "Proposal in development" }
            };

            Levels = new List<LevelViewModel>
            {
                new LevelViewModel{ Id = -1, Value = "Any Level" },
                new LevelViewModel{ Id = 1, Value = "2" },
                new LevelViewModel{ Id = 2, Value = "3" },
                new LevelViewModel{ Id = 3, Value = "4" },
                new LevelViewModel{ Id = 4, Value = "5" },
                new LevelViewModel{ Id = 4, Value = "6" },
                new LevelViewModel{ Id = 4, Value = "7" }
            };

            Durations = new List<DurationViewModel>
            {
                new DurationViewModel{ Id = -1, Value = "Any Duration"},
                new DurationViewModel{ Id = 1, Value = "0"},
                new DurationViewModel{ Id = 2, Value = "12"},
                new DurationViewModel{ Id = 3, Value = "13"},
                new DurationViewModel{ Id = 4, Value = "14"},
                new DurationViewModel{ Id = 5, Value = "15"},
                new DurationViewModel{ Id = 6, Value = "16"},
                new DurationViewModel{ Id = 7, Value = "18"},
                new DurationViewModel{ Id = 8, Value = "21"},
                new DurationViewModel{ Id = 9, Value = "22"},
                new DurationViewModel{ Id = 10, Value = "24"},
                new DurationViewModel{ Id = 11, Value = "26"},
                new DurationViewModel{ Id = 12, Value = "27"},
                new DurationViewModel{ Id = 13, Value = "30"},
                new DurationViewModel{ Id = 14, Value = "33"},
                new DurationViewModel{ Id = 15, Value = "34"},
                new DurationViewModel{ Id = 16, Value = "36"},
                new DurationViewModel{ Id = 17, Value = "38"},
                new DurationViewModel{ Id = 18, Value = "42"},
                new DurationViewModel{ Id = 19, Value = "48"},
                new DurationViewModel{ Id = 20, Value = "54"},
                new DurationViewModel{ Id = 21, Value = "60"},
                new DurationViewModel{ Id = 22, Value = "66"}
            };
        }

        public IActionResult Index()
        {
            var vm = new InternalSearchViewModel
            {
                Routes = Routes,
                Status = Status,
                Levels = Levels,
                Durations = Durations
            };

            return View("Index", vm);
        }
        
        [HttpPost]
        public string GetTableData(SearchViewModel data)
        {
            var repo = new InternalDataRepo(DbContext);

            var searchParameters = new SearchParamterModel
            {
                RouteName = data.RouteId == -1 ? "" : Routes.FirstOrDefault(x => x.Id == data.RouteId).Name,
                StatusName = data.StatusId == -1 ? "" : Status.FirstOrDefault(x => x.Id == data.StatusId).Name,
                Level = data.LevelId == -1 ? -1 : Convert.ToInt32(Levels.FirstOrDefault(x => x.Id == data.LevelId).Value),
                Duration = data.DurationId == -1 ? -1 : Convert.ToInt32(Durations.FirstOrDefault(x => x.Id == data.DurationId).Value)
            };

            var searchResults = repo.GetSearchModels(searchParameters);

            var returnModel = new InternalSearchReturnViewModel()
            {
                Success = searchResults.Count != 0,
                Error = searchResults.Count == 0 ? "There was an issue connecting to the database, please try again later" : "",
                TableRows = searchResults.ConvertAll(x => new TableRowViewModel 
                { 
                    Name = x.Name,
                    Link = x.Link
                })
            };

            var rowsJson = JsonConvert.SerializeObject(returnModel, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });

            return rowsJson;
        }
    }
}
