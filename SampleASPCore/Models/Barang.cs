using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPCore.Models
{
    public class Barang
    {
        public string KodeBarang { get; set; }
        public int KategoriID { get; set; }
        public string NamaBarang { get; set; }
        public int Stock { get; set; }
        public string HargaBeli { get; set; }
        public string HargaJual { get; set; }

        public Kategori Kategori { get; set; } //navigation properti, bisa select barang + kategori ketika mengquery data sudah ada kategorinya
    }
}
