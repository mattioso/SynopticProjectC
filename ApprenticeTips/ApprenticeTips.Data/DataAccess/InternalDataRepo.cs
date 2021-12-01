using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApprenticeTips.Data.DataAccess
{
    public class InternalDataRepo
    {
        private ApprenticeTipsDbContext _db;

        public InternalDataRepo(ApprenticeTipsDbContext db)
        {
            _db = db;
        }
    }
}
