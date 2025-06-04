using System;
using System.Text;

namespace MatematikaLibraries //DARI MODUL 10
{
    public class Matematika
    {
        // Menghitung Faktor Persekutuan Terbesar (FPB) dari dua bilangan
        public int HitungFPB(int angka1, int angka2)
        {
            while (angka2 != 0)
            {
                int sementara = angka2;
                angka2 = angka1 % angka2;
                angka1 = sementara;
            }
            return angka1;
        }

        // Menghitung Kelipatan Persekutuan Terkecil (KPK) dari dua bilangan
        public int HitungKPK(int angka1, int angka2)
        {
            return Math.Abs(angka1 * angka2) / HitungFPB(angka1, angka2);
        }

        // Menghitung turunan dari sebuah polinomial yang direpresentasikan sebagai array koefisien
        public string HitungTurunan(int[] koefisienPolinomial)
        {
            StringBuilder hasilTurunan = new StringBuilder();
            int derajat = koefisienPolinomial.Length - 1;

            for (int i = 0; i < koefisienPolinomial.Length - 1; i++)
            {
                int koefisien = koefisienPolinomial[i];
                int pangkat = derajat - i;

                int koefHasil = koefisien * pangkat;
                int pangkatBaru = pangkat - 1;

                if (koefHasil == 0) continue;

                if (hasilTurunan.Length > 0 && koefHasil > 0) hasilTurunan.Append(" + ");
                else if (koefHasil < 0) hasilTurunan.Append(" - ");

                if (Math.Abs(koefHasil) != 1 || pangkatBaru == 0)
                    hasilTurunan.Append(Math.Abs(koefHasil));

                if (pangkatBaru > 0)
                {
                    hasilTurunan.Append("x");
                    if (pangkatBaru > 1)
                        hasilTurunan.Append(pangkatBaru);
                }
            }
            return hasilTurunan.ToString();
        }

        // Menghitung integral tak tentu dari sebuah polinomial yang direpresentasikan sebagai array koefisien
        public string HitungIntegral(int[] koefisienPolinomial)
        {
            StringBuilder hasilIntegral = new StringBuilder();
            int derajat = koefisienPolinomial.Length - 1;

            for (int i = 0; i < koefisienPolinomial.Length; i++)
            {
                int koefisien = koefisienPolinomial[i];
                int pangkat = derajat - i + 1;

                double koefHasil = (double)koefisien / pangkat;
                if (koefHasil == 0) continue;

                if (hasilIntegral.Length > 0)
                    hasilIntegral.Append(koefHasil > 0 ? " + " : " - ");
                else if (koefHasil < 0)
                    hasilIntegral.Append("-");

                double nilaiMutlak = Math.Abs(koefHasil);
                if (nilaiMutlak != 1)
                    hasilIntegral.Append(nilaiMutlak % 1 == 0 ? ((int)nilaiMutlak).ToString() : nilaiMutlak.ToString("0.##"));

                hasilIntegral.Append("x");
                if (pangkat > 1)
                    hasilIntegral.Append(pangkat);
            }

            hasilIntegral.Append(" + C");
            return hasilIntegral.ToString();
        }
    }
}
