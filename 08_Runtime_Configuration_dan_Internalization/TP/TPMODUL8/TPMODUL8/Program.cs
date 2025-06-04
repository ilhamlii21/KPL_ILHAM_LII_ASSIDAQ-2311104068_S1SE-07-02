using System;

class Program
{
    static void Main()
    {
        CovidConfig config = CovidConfig.LoadConfig();

        Console.WriteLine("==== Aplikasi Pengecekan Kesehatan ====");
        Console.WriteLine($"Satuan suhu saat ini: {config.satuan_suhu}");

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}\n>> ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?\n>> ");
        int hari = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        bool suhuNormal = false;
        if (config.satuan_suhu == "celcius")
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        else if (config.satuan_suhu == "fahrenheit")
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;

        bool hariValid = hari < config.batas_hari_deman;

        Console.WriteLine("Hasil:");
        if (suhuNormal && hariValid)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }
    }
}