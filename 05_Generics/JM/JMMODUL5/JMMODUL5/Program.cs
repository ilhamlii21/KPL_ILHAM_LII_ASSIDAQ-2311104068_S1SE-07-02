// See https://aka.ms/new-console-template for more information
﻿using System;
using JMMODUL5;

public class Program
{
    public static void Main(string[] args)
    {
        string NIM = "2311104068";
        int digit1 = int.Parse(NIM.Substring(0, 2));
        int digit2 = int.Parse(NIM.Substring(2, 2));
        int digit3 = int.Parse(NIM.Substring(4, 2));

        char digitTerakhir = NIM[^1];
        Penjumlahan penjumlahan = new Penjumlahan();
        SimpleDataBase<int> database = new SimpleDataBase<int>();

        if (digitTerakhir == '1' || digitTerakhir == '2')
        {
            float angka1 = digit1;
            float angka2 = digit2;
            float angka3 = digit3;
            var hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
            Console.WriteLine($"Hasil penjumlahan (float): {hasil}");
        }
        else if (digitTerakhir == '3' || digitTerakhir == '4' || digitTerakhir == '5')
        {
            double angka1 = digit1;
            double angka2 = digit2;
            double angka3 = digit3;
            var hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
            Console.WriteLine($"Hasil penjumlahan (double): {hasil}");
        }
        else if (digitTerakhir == '6' || digitTerakhir == '7' || digitTerakhir == '8')
        {
            int angka1 = digit1;
            int angka2 = digit2;
            int angka3 = digit3;
            var hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
            Console.WriteLine($"Hasil penjumlahan (int): {hasil}");
        }
        else if (digitTerakhir == '9' || digitTerakhir == '0')
        {
            long angka1 = digit1;
            long angka2 = digit2;
            long angka3 = digit3;
            var hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
            Console.WriteLine($"Hasil penjumlahan (long): {hasil}");
        }

        Console.WriteLine();

        database.AddNewData(12);
        database.AddNewData(34);
        database.AddNewData(56);

        database.PrintAllData();

        Console.WriteLine();
    }
}