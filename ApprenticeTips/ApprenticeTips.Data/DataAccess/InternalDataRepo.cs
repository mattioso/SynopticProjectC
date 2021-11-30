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

        public void Test()
        {
            var connectionString = _db.Database.GetDbConnection()?.ConnectionString;
            
            /*using (var con = new MySqlConnection(connectionString))
            {
                using (var cmd = con.CreateCommand())
                {

                }
            }*/
        }
    }
}
