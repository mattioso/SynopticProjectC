using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprenticeTips.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ApprenticeTips.App.Controllers
{
    public abstract class BaseController<T> : Controller
    {
        private ApprenticeTipsDbContext _db;
        protected ApprenticeTipsDbContext DbContext => _db
            ?? (_db = HttpContext?.RequestServices.GetService<ApprenticeTipsDbContext>());
    }
}
