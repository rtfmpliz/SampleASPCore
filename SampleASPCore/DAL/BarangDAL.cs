using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleASPCore.Models;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace SampleASPCore.DAL
{

    public class BarangDAL : IBarang  
    {
        private string connStr = string.Empty;
        public BarangDAL(IConfiguration config)
        {
            connStr = config.GetConnectionString("DefaultConnection");

        }
        public void Create(Barang obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Barang> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql = @"select * from Barang b left join Kategori k on b.KategoriID=k.KategoriID";
                var results = conn.Query<Barang, Kategori, Barang>(strSql, (b, k) =>
                {
                    b.Kategori = k;
                    return b;
                }, splitOn: "KategoriID"); // select barang beserta kategori, karena ada relasinya
                return results;
            }
        }

        public Barang GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Barang obj)
        {
            throw new NotImplementedException();
        }
    }
}
