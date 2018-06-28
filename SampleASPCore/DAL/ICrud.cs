using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPCore.DAL
{
    public interface ICrud<T> //T tiipe nya adalah umum / generic, bisa apapun
    {
        IEnumerable<T> GetAll();
        int Create(T obj);
    }
}
