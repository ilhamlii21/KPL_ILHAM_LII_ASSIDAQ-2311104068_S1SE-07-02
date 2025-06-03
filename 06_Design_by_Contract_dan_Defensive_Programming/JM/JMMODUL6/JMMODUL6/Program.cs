using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Ilham Lii");

            string[] filmTitles = {
                "Breaking Bad",
                "Reply 1988",
                "The Last Kingdom",
                "Doctor Strange in the Multiverse of Madness",
                "Interstellar",
                "Blade Runner 2049",
                "Prison Break",
                "Sherlock (BBC)",
                "La Révolution",
                "Alice in Borderland"
            };

            for (int i = 0; i < filmTitles.Length; i++)
            {
                SayaTubeVideo video = new SayaTubeVideo("Review Film") + filmTitles[i] + "Ilham Lii");
                video.IncreasePlayCount((i + 1) * 100000);
                user.AddVideo(video);
            }

            user.PrintAllVideoPlaycount();

            Console.WriteLine("Total Play Count: " + user.GetTotalVideoPlayCount());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}