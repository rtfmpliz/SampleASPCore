using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;
using SampleASPCore.Models;

namespace SampleASPCore.Controllers
{
    public class PegawaiController : Controller
    {
        private IPegawai _pegawai;
        public PegawaiController(IPegawai pegawai)
        {
            _pegawai = pegawai;
        }
        public IActionResult Index()
        {
            var results = _pegawai.GetAll();
            return View(results);
        }

        public IActionResult Tambah()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Tambah(Pegawai pegawai) //tidak perlu variable 1 persatu nama Nik dll, tp lgsg ke class Pegawai, pegawai adalah variabl / parameter supaya bisa dipakai di dalam kalang
        {
            return Content("Nik: " + pegawai.Nik + "Nama: " + pegawai.Nama);
        }
    }
}