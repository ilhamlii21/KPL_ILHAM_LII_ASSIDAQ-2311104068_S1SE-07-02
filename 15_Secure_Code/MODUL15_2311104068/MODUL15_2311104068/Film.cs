public static class Film
{
    public static List<string> DaftarFilm = new List<string>
    {
        "Inception", "The Matrix", "Interstellar", "Parasite", "Spirited Away"
    };

    public static void TampilkanFilm()
    {
        Console.WriteLine("=== Daftar Film ===");
        for (int i = 0; i < DaftarFilm.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {DaftarFilm[i]}");
        }
    }

    public static void PilihFilm()
    {
        TampilkanFilm();
        Console.Write("Pilih nomor film: ");
        if (int.TryParse(Console.ReadLine(), out int pilihan) &&
            pilihan >= 1 && pilihan <= DaftarFilm.Count)
        {
            Console.WriteLine($"Anda memilih: {DaftarFilm[pilihan - 1]}");
        }
        else
        {
            Console.WriteLine("Pilihan tidak valid.");
        }
    }
}
