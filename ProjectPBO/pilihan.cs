using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPBO
{
    public class pilihan
    {
        public void ShowPilihan()
        {
            Console.WriteLine("List pilihan:");
            Console.WriteLine("1. Install Aplikasi");
            Console.WriteLine("2. Filter Aplikasi");
            Console.WriteLine("3. Urutkan Aplikasi");
            Console.WriteLine("4. Exit");
        }
        public int ulangPilihan()
        {
            pilihan show = new pilihan();
                show.ShowPilihan();
                Console.WriteLine("Silahkan masukkan pilihan:");
                int input2;
                input2 = int.Parse(Console.ReadLine());
                pilihan isi = new pilihan();
                isi.IsiPilihan(input2);
            return 0;
        }
       public int IsiPilihan(int input)
       {
           namaPilihan tag = new namaPilihan();
           pilihan tmpl = new pilihan();
           if (input == 1)
           {
               tag.installApp();
               Console.WriteLine("____________________________________________");
               tmpl.ulangPilihan(); 
           }
           
           else if (input == 2)
           {
               tag.filterApp();
                Console.WriteLine("____________________________________________");
               tmpl.ulangPilihan();
           }
           else if (input == 3)
           {
               tag.urutApp();
                Console.WriteLine("____________________________________________");
               tmpl.ulangPilihan();
           }
           else if (input == 4)
           {
               Console.WriteLine("Exit aplikasi...");
               Console.WriteLine("____________________________________________");
           }

        return 0;
       }
    }

}