using System;
using System.Text;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return Math.Abs(a * b) / FPB(a, b);
        }

        public string Turunan(int[] persamaan)
        {
            StringBuilder sb = new StringBuilder();
            int derajat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i];
                int pangkat = derajat - i;

                int hasil = koef * pangkat;
                int pangkatBaru = pangkat - 1;

                if (hasil == 0) continue;

                if (sb.Length > 0 && hasil > 0) sb.Append(" + ");
                else if (hasil < 0) sb.Append(" - ");

                if (Math.Abs(hasil) != 1 || pangkatBaru == 0)
                    sb.Append(Math.Abs(hasil));

                if (pangkatBaru > 0)
                {
                    sb.Append("x");
                    if (pangkatBaru > 1)
                        sb.Append(pangkatBaru);
                }
            }
            return sb.ToString();
        }

        public string Integral(int[] persamaan)
        {
            StringBuilder sb = new StringBuilder();
            int derajat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length; i++)
            {
                int koef = persamaan[i];
                int pangkat = derajat - i + 1;

                double hasil = (double)koef / pangkat;
                if (hasil == 0) continue;

                if (sb.Length > 0)
                    sb.Append(hasil > 0 ? " + " : " - ");
                else if (hasil < 0)
                    sb.Append("-");

                double absHasil = Math.Abs(hasil);
                if (absHasil != 1)
                    sb.Append(absHasil % 1 == 0 ? ((int)absHasil).ToString() : absHasil.ToString("0.##"));

                sb.Append("x");
                if (pangkat > 1)
                    sb.Append(pangkat);
            }

            sb.Append(" + C");
            return sb.ToString();
        }
    }
}