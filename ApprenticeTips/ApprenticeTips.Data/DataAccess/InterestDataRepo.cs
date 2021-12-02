using ApprenticeTips.Data.Models;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ApprenticeTips.Data.DataAccess
{
    public class InterestDataRepo
    {
        private ApprenticeTipsDbContext _db;

        public InterestDataRepo(ApprenticeTipsDbContext db)
        {
            _db = db;
        }

        public bool RegisterInterest(ContactModel model)
        {
            var connectionString = _db.Database.GetDbConnection()?.ConnectionString;

            using var con = new MySqlConnection(connectionString);
            using (var cmd = con.CreateCommand())
            {
                var sql = $@"INSERT INTO webform.Contact(firstname, 
                                                         surname, 
                                                         email, 
                                                         phone, 
                                                         previous_level, 
                                                         agriculture, 
                                                         business, 
                                                         care, 
                                                         catering, 
                                                         construction, 
                                                         creative, 
                                                         digital, 
                                                         education, 
                                                         engineering, 
                                                         hair, 
                                                         health, 
                                                         legal, 
                                                         protective, 
                                                         sales, 
                                                         transport, 
                                                         comments, 
                                                         submit_date)
                            VALUES(@firstname,
                                   @surname, 
                                   @email, 
                                   @phone, 
                                   {model.PreviousLevel}, 
                                   {model.Agriculture}, 
                                   {model.Business}, 
                                   {model.Care}, 
                                   {model.Catering}, 
                                   {model.Construction}, 
                                   {model.Creative}, 
                                   {model.Digital}, 
                                   {model.Education}, 
                                   {model.Engineering}, 
                                   {model.Hair}, 
                                   {model.Health}, 
                                   {model.Legal}, 
                                   {model.Protective}, 
                                   {model.Sales}, 
                                   {model.Sales}, 
                                   @comments,
                                   @submit_date)";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("firstname", model.FirstName);
                cmd.Parameters.AddWithValue("surname", model.Surname);
                cmd.Parameters.AddWithValue("email", model.Email);
                cmd.Parameters.AddWithValue("phone", model.Phone);
                cmd.Parameters.AddWithValue("submit_date", model.SubmitDate);
                cmd.Parameters.AddWithValue("comments", model.Comments);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

    }
}
