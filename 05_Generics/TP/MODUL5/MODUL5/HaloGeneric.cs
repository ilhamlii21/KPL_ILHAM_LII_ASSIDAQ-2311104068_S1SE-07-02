using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL5
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T input)
        {
            Console.WriteLine($"Hai User {input}");
        }
    }
}