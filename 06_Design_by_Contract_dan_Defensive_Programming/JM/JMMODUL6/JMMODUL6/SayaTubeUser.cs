using System;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        if (username == null) throw new ArgumentNullException("Username tidak boleh null.");
        if (username.Length > 100) throw new ArgumentException("Panjang username tidak boleh lebih dari 100 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null) throw new ArgumentNullException("Video tidak boleh null.");
        if (video.GetPlayCount() > int.MaxValue) throw new ArgumentException("Play count pada video melebihi batas integer maksimum.");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.GetPlayCount();
        }
        return totalPlayCount;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + username);
        int i = 1;

        foreach (var video in uploadedVideos)
        {
            if (i > 8) break;
            Console.WriteLine("Video " + i + " judul: " + video.GetTitle());
            i++;
        }
    }
}