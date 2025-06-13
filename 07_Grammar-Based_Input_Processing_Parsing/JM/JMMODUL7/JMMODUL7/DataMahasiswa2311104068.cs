using Newtonsoft.Json;
using System;
using System.IO;


namespace JMMODUL7
{
    class DataMahasiswa2311104068
    {
        public string NIM { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public static void ReadJSON()
        {
            // Path ke file JSON
            string filePath = "JURNAL7_1.json";

            // Membaca file JSON dan mendeserialize ke objek
            string jsonData = File.ReadAllText(filePath);
            DataMahasiswa2311104068 mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa2311104068>(jsonData);

            // Print hasil deserialisasi
            Console.WriteLine($"NIM: {mahasiswa.NIM}");
            Console.WriteLine($"First Name: {mahasiswa.FirstName}");
            Console.WriteLine($"Last Name: {mahasiswa.LastName}");
            Console.WriteLine($"Age: {mahasiswa.Age}");
            Console.WriteLine($"Gender: {mahasiswa.Gender}");
        }
    }
}