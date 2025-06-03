using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMMODUL5
{
    public class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3) where T : struct
        {
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;
            return (T)(a + b + c);
        }
    }
}
