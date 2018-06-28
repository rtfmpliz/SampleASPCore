using SampleASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace SampleASPCore.DAL
{
    public class KategoriDAL : IKategori //sebelum dibuat Ikategori public class KategoriDAL : ICrud<Kategori>
    {
        private string connStr = string.Empty;

        public KategoriDAL(IConfiguration config)
        {
            connStr = config.GetConnectionString("DefaultConnection");

        }
        public void Create(Kategori kategori)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string strSql = @"insert into Kategori(NamaKategori) values(@NamaKategori)";
                    //jangan lupa pakai parameterize query supaya tidak bisa diinject dengan @
                    var param = new { NamaKategori = kategori.NamaKategori };
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
            //tidak usah beri result gpp, kalo mau masukkan dalam try catch

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string strSql = @"delete from Kategori where KategoriId=@KategoriID";
                    var param = new { KategoriID = id };
                    int hasil = conn.Execute(strSql, param);
                    //int hasil = conn.Execute(strSql, new { KategoriID = id });  // jika tanpa param, isi param bisa lngsg dimasukkan seletalh new
                    // bisa ditampilkan juga nama tapi juga buat input tpe hidden untuk nama kategori untuk dikirimakn di tempdata notifikasi
                }
            }
            catch (Exception sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }

        }

        public IEnumerable<Kategori> GetAll()
        {


            IEnumerable<Kategori> results;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql = @"select * from Kategori order by NamaKategori asc";
                results = conn.Query<Kategori>(strSql);
                return results;
                //SqlCommand cmd

            }
            // return View(results); // disabut melemparkan model, selainnya ini menggunakan ViewDAta        
        }

        public Kategori GetById(string id)
        {
            Kategori result = null;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql = @"select * from Kategori where KategoriID=@KategoriID";
                result = conn.QuerySingle<Kategori>(strSql, new { KategoriID = id }); //single bukan list / ienumerable
                return result;
            }

        }

        public IEnumerable<Kategori> SearchByNama(string nama)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql = @"select * from Kategori where NamaKategori like @NamaKategori order by NamaKategori desc";
                var param = new { NamaKategori = "%" + nama + "%" };
                var results = conn.Query<Kategori>(strSql, param);
                return results;

            }
        }
        public void Update(string id, Kategori kategori)
        {
            //return Content(id.ToString() + " " + kategori.NamaKategori );
            try
            {
                // TODO: Add update logic here
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string strSql = @"update Kategori set NamaKategori=@NamaKategori where KategoriID=@KategoriID";
                    //int hasil = conn.Execute(strSql, new {NamaKategori=NamaKategori, KategoriID = id });
                    var param = new
                    {
                        NamaKategori = kategori.NamaKategori,
                        KategoriID = id
                    };
                    int hasil = conn.Execute(strSql, param);
                }


            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);

            }
        }


    }


}
