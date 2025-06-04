using System;
using MatematikaLibraries;

namespace Modul10ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematika mtk = new Matematika();

            Console.WriteLine("FPB(60, 45) = " + mtk.FPB(60, 45));
            Console.WriteLine("KPK(12, 8) = " + mtk.KPK(12, 8));
            Console.WriteLine("Turunan({1, 4, -12, 9}) = " + mtk.Turunan(new int[] { 1, 4, -12, 9 }));
            Console.WriteLine("Integral({4, 6, -12, 9}) = " + mtk.Integral(new int[] { 4, 6, -12, 9 }));

            Console.ReadKey();
        }
    }
}