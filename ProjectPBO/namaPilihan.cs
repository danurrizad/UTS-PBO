using System.Collections.Generic;
using System;

namespace ProjectPBO
{
    public class namaPilihan
    {
        string[ ] apk = new string [11] {
                    "Mobile Legends:Bang Bang", 
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
        public void filterApp()
        {
            Console.WriteLine();
            Console.WriteLine("Aplikasi Game:");
            Console.WriteLine("1. Mobile Legends:Bang Bang");
            Console.WriteLine("2. PUBG Mobile");
            Console.WriteLine("3. 8 Ball Pool");
            Console.WriteLine("4. Free Fire");
            Console.WriteLine("5. Tahu Bulat");
            Console.WriteLine("\nAplikasi Non-Game:");
            Console.WriteLine("1. Instagram");
            Console.WriteLine("2. WhatsApp");
            Console.WriteLine("3. Tiktok");
            Console.WriteLine("4. Tinder");
            Console.WriteLine("5. Gojek");
            Console.WriteLine("6. Grab");      
        }
        public int installApp()
        {
            int pilih_apk;
            int jawab;
           
            aplikasi dat = new aplikasi(); 
            dat.ShowApplicationList();
            Console.WriteLine();
               Console.WriteLine("Silahkan pilih nomor aplikasi yang ingin anda install:");
               pilih_apk = int.Parse(Console.ReadLine());
               listAplikasi list = new listAplikasi();
               switch (pilih_apk)
               {
                    case 1:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[0]);
                       list.MoLe();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini? (1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                    case 2:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[1]);
                       list.Instagram();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini?(1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                    case 3:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[2]);
                       list.WA();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini?(1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                    case 4:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[3]);
                       list.Tiktok();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini?(1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                    default:
                       break;
                     case 5:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[4]);
                       list.PUBGM();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini? (1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                    case 6:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[5]);
                       list.BallPool();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini?(1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                    case 7:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[6]);
                       list.Tinder();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini?(1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                    case 8:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[7]);
                       list.FF();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini?(1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                     case 9:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[8]);
                       list.Gojek();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini?(1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                    case 10:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[9]);
                       list.TahuBulat();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini?(1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
                    case 11:
                       Console.WriteLine("Informasi mengenai aplikasi {0}:", apk[10]);
                       list.Grab();
                       Console.WriteLine("Apakah anda ingin menginstall aplikasi ini?(1(yes)/0(no))");
                       jawab = int.Parse(Console.ReadLine());
                       if (jawab == 1)
                       {
                           Console.WriteLine("Proses Menginstal...");
                           Console.WriteLine("Selesai");
                       }
                       else if (jawab == 0)
                       {
                           Console.WriteLine("Exit.");
                       }
                       break;
               }
            return 0;   
        }

        public void urutApp()
        {
            String temp;
               // buah[i]=MyScanner.next();
           
            Console.WriteLine("Aplikasi yang sudah urut sesuai nama:");
            for(int i=0;i<11-1;i++)
            {
                for(int j=0;j<11-1;j++)
                {
                    if(apk[j].CompareTo(apk[j+1])>0)
                    {
                        temp=apk[j+1];
                        apk[j+1]=apk[j];
                        apk[j]=temp;
                    }
                }
            }
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("{0}. {1}", i+1, apk[i]);
            }
            


        
        }
    }
}