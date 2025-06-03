using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL6
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Judul video tidak boleh null dan panjangnya maksimal 100 karakter.");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
            {
                throw new ArgumentException("Penambahan play count maksimal 10.000.000 per panggilan.");
            }

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow terjadi pada penambahan play count.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {this.id}");
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Play Count: {this.playCount}");
        }
    }
}
