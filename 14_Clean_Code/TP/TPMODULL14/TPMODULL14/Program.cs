using System;
using System.Collections.Generic;

public class SayaTubeUser //DARI MODUL 6
{
    // Private fields (menggunakan camelCase sesuai standar C#)
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    // Constructor untuk inisialisasi user
    public SayaTubeUser(string username)
    {
        if (username == null)
            throw new ArgumentNullException("Username tidak boleh null.");

        if (username.Length > 100)
            throw new ArgumentException("Panjang username tidak boleh lebih dari 100 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    // Menambahkan objek video ke dalam daftar video yang diunggah
    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
            throw new ArgumentNullException("Video tidak boleh null.");

        if (video.GetPlayCount() > int.MaxValue)
            throw new ArgumentException("Play count pada video melebihi batas maksimum.");

        uploadedVideos.Add(video);
    }

    // Mengembalikan total jumlah play count dari semua video yang diunggah
    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.GetPlayCount();
        }

        return totalPlayCount;
    }

    // Menampilkan daftar maksimal 8 judul video milik user
    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + username);

        for (int i = 0; i < uploadedVideos.Count && i < 8; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " Judul: " + uploadedVideos[i].GetTitle());
        }
    }
}
