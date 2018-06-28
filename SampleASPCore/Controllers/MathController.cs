﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleASPCore.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost] // karena menangani POST
        public IActionResult Index(double bil1,double bil2,string rdOperator)
        {
            double hasil = 0;
            if (rdOperator=="Tambah")
            {
                hasil=bil1 + bil2;
            }
            else
            {
                hasil = bil1 - bil2;
            }
            ViewBag.Hasil = hasil;
            ViewBag.bil1 = bil1;
            ViewBag.bil2 = bil2;
            //return Content("Hasil : " + hasil);
            return View();
        }
        // GET: Math/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Math/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Math/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Math/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Math/Edit/5
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

        // GET: Math/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Math/Delete/5
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