using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.Models;

namespace SampleASPCore.Controllers
{
    public class PegawaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
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