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
    public class PegawaiDAL : IPegawai
    {
        private string connStr = string.Empty;
        public PegawaiDAL(IConfiguration config)
        {
            connStr = config.GetConnectionString("DefaultConnection");

        }

        public void Create(Pegawai obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pegawai> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql = @"select * from Kategori order by NamaKategori asc";
                var results = conn.Query<Pegawai>(strSql);
                return results;
                //SqlCommand cmd

            }
        }

        public Pegawai GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Pegawai obj)
        {
            throw new NotImplementedException();
        }
    }
}
