using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;
using SampleASPCore.Models;

namespace SampleASPCore.Controllers
{
    public class RankController : Controller
    {
        private IRank _rank;
        public RankController(IRank rank)
        {
            _rank = rank;
        }
        // GET: Rank
        public ActionResult Index()
        {
            var results = _rank.GetAll();
            return View(results);
        }

        // GET: Rank/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rank/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rank/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rank rank)
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

                _rank.Create(rank);
                TempData["Pesan"] = "<span class='alert alert-success'>" + "Data " + rank.RankName + "berhasil ditambah ! </span>";
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

        // GET: Rank/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rank/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Rank/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rank/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}