//using System;
//using System.Collections.Generic;

//namespace jmmodul4_2311104068
//{
//    public class KodeBuah
//    {
//        private Dictionary<string, string> kodeBuah = new Dictionary<string, string>
//        {
//            { "Apel", "A00" },
//            { "Aprikot", "B00" },
//            { "Alpukat", "C00" },
//            { "Pisang", "D00" },
//            { "Paprika", "E00" },
//            { "Blackberry", "F00" },
//            { "Ceri", "H00" },
//            { "Kelapa", "I00" },
//            { "Jagung", "J00" }
//        };

//        public string GetKodeBuah(string namaBuah)
//        {
//            if (kodeBuah.ContainsKey(namaBuah))
//            {
//                return kodeBuah[namaBuah];
//            }
//            else
//            {
//                return "Kode buah tidak ditemukan";
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            KodeBuah kodeBuah = new KodeBuah();

//            // Contoh input dan output
//            Console.Write("Masukkan nama buah: ");
//            string namaBuah = Console.ReadLine();

//            string kode = kodeBuah.GetKodeBuah(namaBuah);
//            Console.WriteLine($"Kode buah untuk {namaBuah}: {kode}");
//        }
//    }
//}


using System;

public enum State
{
    Berdiri,
    Jongkok,
    Tengkurap,
    Terbang
}

public class PosisiKarakterGame
{
    private State state;

    public PosisiKarakterGame()
    {
        state = State.Berdiri; 
        Console.WriteLine("Posisi awal: Berdiri");
    }

    public void TombolS()
    {
        Console.WriteLine("Tombol arah bawah ditekan");
    }

    public void TombolW()
    {
        Console.WriteLine("Tombol arah atas ditekan");
    }

    public void UbahState(State newState)
    {
        if (state == State.Terbang && newState == State.Jongkok)
        {
            Console.WriteLine("Posisi landing");
        }
        else if (state == State.Berdiri && newState == State.Terbang)
        {
            Console.WriteLine("Posisi take off");
        }
        else if (newState == State.Berdiri)
        {
            Console.WriteLine("Posisi standby");
        }
        else if (newState == State.Tengkurap)
        {
            Console.WriteLine("Posisi istirahat");
        }

        state = newState; 
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Masukkan NIM Anda: ");
        long nim = long.Parse(Console.ReadLine()); 
        int nimMod = (int)(nim % 3); 

        PosisiKarakterGame karakter = new PosisiKarakterGame();

        if (nimMod == 0)
        {
            karakter.TombolS();
            karakter.TombolW();
        }
        else if (nimMod == 1)
        {
            karakter.UbahState(State.Berdiri);
            karakter.UbahState(State.Tengkurap);
        }
        else if (nimMod == 2)
        {
            karakter.UbahState(State.Terbang);
            karakter.UbahState(State.Jongkok);
        }
    }
}
