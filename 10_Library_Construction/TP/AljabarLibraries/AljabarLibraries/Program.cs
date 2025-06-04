using System;
using AljabarLibraries;

namespace AljabarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] kuadrat = { 1, -3, -10 };
            var hasilAkar = Aljabar.AkarPersamaanKuadrat(kuadrat);
            Console.WriteLine("Akar-akar dari x^2 - 3x - 10:");
            Console.WriteLine($"x1 = {hasilAkar[0]}, x2 = {hasilAkar[1]}");

            double[] linier = { 2, -3 };
            var hasilKuadrat = Aljabar.HasilKuadrat(linier);
            Console.WriteLine("\nHasil kuadrat dari (2x - 3)^2:");
            Console.WriteLine($"{hasilKuadrat[0]}x^2 + {hasilKuadrat[1]}x + {hasilKuadrat[2]}");
        }
    }
}