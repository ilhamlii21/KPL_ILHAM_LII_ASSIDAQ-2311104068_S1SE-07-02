using System;
using System.IO;
using System.Text.Json;

namespace TPMODUL7
{
    public class DataMahasiswa2311104068
    {
        public class Mahasiswa
        {
            public string nama { get; set; }
            public string nim { get; set; }
            public string fakultas { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("TPMODULL_1_7.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"Nama {mhs.nama} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
        }
    }
}