using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPCore.DAL
{
    public interface ICrud<T> //T tiipe nya adalah umum / generic, bisa apapun
    {
        IEnumerable<T> GetAll();
        T GetById(string id);
        void Create(T obj);
        void Update(string id, T obj);
        void Delete(string id);

        //tujuannya untuk memisahkan supaya tidka jadi fat Controller, misal tidak ada koneksi database
    }
}
