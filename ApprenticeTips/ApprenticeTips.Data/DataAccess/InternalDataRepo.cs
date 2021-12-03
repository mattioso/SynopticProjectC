using ApprenticeTips.Data.Models;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public List<SearchModel> GetSearchModels(SearchParamterModel searchParamters)
        {
            var connectionString = _db.Database.GetDbConnection()?.ConnectionString;

            var models = new List<SearchModel>();

            using var con = new MySqlConnection(connectionString);
            using (var cmd = con.CreateCommand())
            {
                var parameters = new List<String>();

                if (searchParamters.RouteName != "")
                {
                    parameters.Add($"route = @route");
                }
                if (searchParamters.StatusName != "")
                {
                    parameters.Add($"status = @status");
                }
                if (searchParamters.Level != -1)
                {
                    parameters.Add($"level = @level");
                }
                if (searchParamters.Duration != -1)
                {
                    parameters.Add($"duration = @duration");
                }

                var sql = $@"SELECT name, link FROM webform.Apprenticeships
                             WHERE {parameters[0]}";

                parameters.RemoveAt(0);
                foreach (var p in parameters)
                {
                    sql += $" AND {p}";
                }

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                if (searchParamters.RouteName != "")
                {
                    cmd.Parameters.AddWithValue("route", searchParamters.RouteName);
                }
                if (searchParamters.StatusName != "")
                {
                    cmd.Parameters.AddWithValue("status", searchParamters.StatusName);
                }
                if (searchParamters.Level != -1)
                {
                    cmd.Parameters.AddWithValue("level", searchParamters.Level);
                }
                if (searchParamters.Duration != -1)
                {
                    cmd.Parameters.AddWithValue("duration", searchParamters.Duration);
                }

                try
                {
                    con.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            models.Add(new SearchModel
                            {
                                Name = Convert.ToString(dr["name"]),
                                Link = Convert.ToString(dr["link"])
                            });
                        }
                    }
                }
                catch
                {

                }
            }

            return models;
        }
    }
}
