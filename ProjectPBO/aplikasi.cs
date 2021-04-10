using System;
using System.Text;

namespace ProjectPBO
{
    public class aplikasi
    {
        public void ShowApplicationList()
        {   
            string[ ] apk = new string [11] {"Mobile Legends : Bang Bang", 
            "Instagram", 
            "WhatsApp", 
            "Tiktok", 
            "PUBG Mobile", 
            "8 Ball Pool", 
            "Tinder",
            "Free Fire",
            "Gojek",
            "Tahu Bulat",
            "Grab" };
            Console.WriteLine("Berikut adalah list dari aplikasi yang tersedia");
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, apk[i]);
            }    
        
            
        }
    }

    public class listAplikasi
    {
        public void MoLe()
        {
            Console.WriteLine("Pengembang\t: Moonton");
            Console.WriteLine("Kategori\t: Game, Multiplayer, MOBA");
            Console.WriteLine("Ukuran\t\t: 186 MB");
            Console.WriteLine("Rated\t\t: 7+");
            Console.WriteLine("Jumlah Download\t: 100jt+");
        }
        public void Line()
        {
            Console.WriteLine("Pengembang\t: LINE Corporation");
            Console.WriteLine("Kategori\t: App, Sosial Media");
            Console.WriteLine("Ukuran\t\t: 270 MB");
            Console.WriteLine("Rated\t\t: 3+");
            Console.WriteLine("Jumlah Download\t: 500jt+");
        }
        public void Instagram()
        {
            Console.WriteLine("Pengembang\t: Instagram");
            Console.WriteLine("Kategori\t: App, Sosial Media");
            Console.WriteLine("Ukuran\t\t: 111 MB");
            Console.WriteLine("Rated\t\t: 12+");
            Console.WriteLine("Jumlah Download\t: 1milyar+");
        }
        public void WA()
        {
            Console.WriteLine("Pengembang\t: WhatsApp LLC");
            Console.WriteLine("Kategori\t: App, Sosial Media");
            Console.WriteLine("Ukuran\t\t: 69 MB");
            Console.WriteLine("Rated\t\t: 3+");
            Console.WriteLine("Jumlah Download\t: 5milyar+");
        }
        public void Tiktok()
        {
            Console.WriteLine("Pengembang\t: TikTok Pte. Ltd.");
            Console.WriteLine("Kategori\t: App, Sosial Media");
            Console.WriteLine("Ukuran\t\t: 300 MB");
            Console.WriteLine("Rated\t\t: 12+");
            Console.WriteLine("Jumlah Download\t: 100jt+");
        }
        public void PUBGM()
        {
            Console.WriteLine("Pengembang\t: Tencent Games");
            Console.WriteLine("Kategori\t: Game, Multiplayer, Battle Royal");
            Console.WriteLine("Ukuran\t\t: 650 MB");
            Console.WriteLine("Rated\t\t: 16+");
            Console.WriteLine("Jumlah Download\t: 100jt+");
        }
        public void BallPool()
        {
            Console.WriteLine("Pengembang\t: Miniclip.com");
            Console.WriteLine("Kategori\t: Game, Multiplayer, Online");
            Console.WriteLine("Ukuran\t\t: 65 MB");
            Console.WriteLine("Rated\t\t: 12+");
            Console.WriteLine("Jumlah Download\t: 500jt+");
        }
        public void Tinder()
        {
            Console.WriteLine("Pengembang\t: Tinder");
            Console.WriteLine("Kategori\t: App, Dating");
            Console.WriteLine("Ukuran\t\t: 48 MB");
            Console.WriteLine("Rated\t\t: 18+");
            Console.WriteLine("Jumlah Download\t: 100jt+");
        }
        public void FF()
        {
            Console.WriteLine("Pengembang\t: Garena");
            Console.WriteLine("Kategori\t: Game, Multiplayer, Battle Royal");
            Console.WriteLine("Ukuran\t\t: 689 MB");
            Console.WriteLine("Rated\t\t: 12+");
            Console.WriteLine("Jumlah Download\t: 500jt+");
        }
        public void Gojek()
        {
            Console.WriteLine("Pengembang\t: PT. Aplikasi Anak Bangsa");
            Console.WriteLine("Kategori\t: App, Lifestyle, Online Transportation");
            Console.WriteLine("Ukuran\t\t: 60 MB");
            Console.WriteLine("Rated\t\t: 3+");
            Console.WriteLine("Jumlah Download\t: 50jt+");
        }
        public void TahuBulat()
        {
            Console.WriteLine("Pengembang\t: Own Games");
            Console.WriteLine("Kategori\t: Game, Simulation");
            Console.WriteLine("Ukuran\t\t: 39 MB");
            Console.WriteLine("Rated\t\t: 3+");
            Console.WriteLine("Jumlah Download\t: 10jt+");
        }
        public void Grab()
        {
            Console.WriteLine("Pengembang\t: Grab Holdings");
            Console.WriteLine("Kategori\t: App, Lifstyle, Online Transportation");
            Console.WriteLine("Ukuran\t\t: 93 MB");
            Console.WriteLine("Rated\t\t: 3+");
            Console.WriteLine("Jumlah Download\t: 100jt+");
        }
    }
   

}