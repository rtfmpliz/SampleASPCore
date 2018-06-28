using SampleASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//best practice nya buat ICrud untuk General
//buat IKategori / IBarang untuk tambahan yg tidak ada hubungan misal dengan CRUD
namespace SampleASPCore.DAL
{
    public interface IKategori : ICrud<Kategori>
    {
        IEnumerable<Kategori> SearchByNama(string nama); //diimplementasi di DAL
    }
}
