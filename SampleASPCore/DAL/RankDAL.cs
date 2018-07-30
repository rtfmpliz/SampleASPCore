using Dapper;
using Microsoft.Extensions.Configuration;
using SampleASPCore.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPCore.DAL
{
    public class RankDAL:IRank
    {
        private string connStr = string.Empty;
        public RankDAL(IConfiguration config)
        {
            connStr = config.GetConnectionString("DefaultConnection");

        }

        public void Create(Rank rank)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string strSql = @"insert into Rank(RankName) values(@RankName)";
                    //jangan lupa pakai parameterize query supaya tidak bisa diinject dengan @
                    var param = new { RankName = rank.RankName };
                    conn.Execute(strSql, param);
                }

            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rank> GetAll()
        {
            IEnumerable<Rank> results;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql = @"select * from Rank";
                results = conn.Query<Rank>(strSql);
                return results;
                //SqlCommand cmd

            }
        }

        public Rank GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Rank obj)
        {
            throw new NotImplementedException();
        }
    }
}
