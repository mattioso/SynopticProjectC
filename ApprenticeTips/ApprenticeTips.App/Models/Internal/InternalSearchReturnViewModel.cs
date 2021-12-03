using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApprenticeTips.App.Models.Internal
{
    public class InternalSearchReturnViewModel
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public List<TableRowViewModel> TableRows { get; set; }
    }
}
