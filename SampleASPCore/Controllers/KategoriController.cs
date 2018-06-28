using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
using SampleASPCore.Models;
using SampleASPCore.DAL;

namespace SampleASPCore.Controllers
{
    public class KategoriController : Controller
    {
        private IKategori _kategori;

        public KategoriController(IKategori kategori)
        {
            _kategori = kategori;
        }
        //string connStr = string.Empty;
        //public KategoriController(IConfiguration config)
        //{
        //    //mengambil connection string
        //    connStr = config.GetConnectionString("DefaultConnection"); 
        //}
        // GET: Kategori
        public ActionResult Index()
        {

            //cek data temp data

            if (TempData["Pesan"] != null)
                ViewBag.Pesan = TempData["Pesan"];
            else
                ViewBag.Pesan = "";

            var results = _kategori.GetAll();


           /* IEnumerable<Kategori> results;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql = @"select * from Kategori order by NamaKategori asc";
                 results = conn.Query<Kategori>(strSql);
                //SqlCommand cmd
                
            }

    */
            return View(results); // disabut melemparkan model, selainnya ini menggunakan ViewDAta
        }

        // GET: Kategori/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kategori/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kategori/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kategori kategori )
        {
            try
            {
                /*
                // TODO: Add insert logic here
                using(SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string strSql = @"insert into Kategori(NamaKategori) values(@NamaKategori)";
                        //jangan lupa pakai parameterize query supaya tidak bisa diinject dengan @
                        var param = new { NamaKategori = kategori.NamaKategori };
                        conn.Execute(strSql, param);
                    }
                }*/

                _kategori.Create(kategori);
                TempData["Pesan"] = "<span class='alert alert-success'>" + "Data " + kategori.NamaKategori + "berhasil ditambah ! </span>";
                    //cek dulu temp data ada tidak, baru dimasukkan ke view bag... ngirim data lewat Controller dulu
                return RedirectToAction(nameof(Index)); //mau nambah info jika sudah masuk, karena return redirect maka tidak bisa langsur lempar data tapi gunakan TEmpDAta
            }
            //catch(SqlException sqlEx) // tidak lagi menggunakan SqlException
            catch (Exception ex)
            {
                ViewBag.Error = "<span class='alert alert-danger'>" + ex.Message + "</span>"; //return view maka pake view bag
                return View();
            }
        }

        // GET: Kategori/Edit/5
        public ActionResult Edit(int id)
        {



            var result = _kategori.GetById(id.ToString());
            if (result != null)
                return View(result);
            else
                return RedirectToAction(nameof(Index));
        }

        // POST: Kategori/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Kategori kategori)
        {
            //return Content(id.ToString() + " " + kategori.NamaKategori );
            try
            {

                /*
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
                }*/

                _kategori.Update(id.ToString(), kategori);
                TempData["Pesan"] = "<span class='alert alert-success'>" + "Data " + kategori.NamaKategori + "berhasil diedit ! </span>";

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Error = "<span class='alert alert-danger'>" + ex.Message + "</span>"; //return view maka pake view bag

                return View();
            }
            //return (result);
            
        }

        // GET: Kategori/Delete/5
        public ActionResult Delete(int id)
        {
            /*
            Kategori result;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql = @"select * from Kategori where KategoriID=@KategoriID";
                result = conn.QuerySingle<Kategori>(strSql, new { KategoriID = id }); //single bukan list / ienumerable
                if (result == null)
                {
                    ViewBag.Pesan = "<span class='alert alert-danger'>" + "Data tidak ditemuka ! </span>";
                    return View();
                }
            }
            */
            var result = _kategori.GetById(id.ToString());
            if (result == null)
            {
                ViewBag.Pesan = "Data tidak ditemukan";
            }
            return View(result);
            
        }

        // POST: Kategori/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Kategori kategori)
        {
            try
            {

                /*
                using(SqlConnection conn = new SqlConnection(connStr))
                {
                    string strSql = @"delete from Kategori where KategoriId=@KategoriID";
                   var param = new { KategoriID = id };
                    int hasil = conn.Execute(strSql, param);
                    //int hasil = conn.Execute(strSql, new { KategoriID = id });  // jika tanpa param, isi param bisa lngsg dimasukkan seletalh new
                    // bisa ditampilkan juga nama tapi juga buat input tpe hidden untuk nama kategori untuk dikirimakn di tempdata notifikasi
                }

    */
                _kategori.Delete(id.ToString());
                // TODO: Add delete logic here
                TempData["Pesan"] = "<span class='alert alert-success'>" + "Data " + kategori.NamaKategori + "berhasil delete ! </span>";

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = "<span class='alert alert-danger'>" + ex.Message + "</span>"; //return view maka pake view bag

                return View();
            }
        }
    }
}