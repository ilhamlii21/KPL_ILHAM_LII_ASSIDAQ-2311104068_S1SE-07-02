using MODUL5;
using System;
namespace tpmodul5_2311104068;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Masukkan nama user: ");
        string inputUser = Console.ReadLine();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(inputUser);

        Console.WriteLine();

        DataGeneric<string> data = new DataGeneric<string>("Namikaze Ilham");
        data.PrintData();
    }
}