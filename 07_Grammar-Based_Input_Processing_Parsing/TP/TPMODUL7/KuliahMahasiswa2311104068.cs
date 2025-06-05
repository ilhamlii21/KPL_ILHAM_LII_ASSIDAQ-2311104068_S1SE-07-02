using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace TPMODUL7
{
    public class KuliahMahasiswa2311104068
    {
        public class MataKuliah
        {
            public string kode { get; set; }
            public string nama { get; set; }
        }

        public class DaftarKuliah
        {
            public List<MataKuliah> mataKuliah { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("TPMODULL_2_7.json");
            DaftarKuliah daftar = JsonSerializer.Deserialize<DaftarKuliah>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var mk in daftar.mataKuliah)
            {
                Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
                i++;
            }
        }
    }
}