using System.Net.Sockets;
using System;

namespace ProjectPBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan username anda :");
            string username = Console.ReadLine();
           
            Console.WriteLine("Masukkan email anda :");
            string email = Console.ReadLine();
          
            Member data = new Member(username,email);
           
            Console.WriteLine("----------Selamat datang di PlayApp store-----------");
            data.ShowMemberInformation();

            Console.WriteLine("Berikut ini adalah aplikasi-aplikasi yang ada.");
            Console.WriteLine("Mobile Legends : Bang Bang, Instagram, WhatsApp, Tiktok, PUBG Mobile, 8 Ball Pool, Tinder, Free Fire, Gojek, Tahu Bulat, Grab ");
            Console.WriteLine();

            pilihan tmpl = new pilihan();
            tmpl.ulangPilihan();
            

        }
    }
}