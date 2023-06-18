using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Diagnostics.Eventing.Reader;

namespace DirectoriIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yeniklasor("c:\\enderKlasor");
            //klasorkontrol("c:\\enderKlasor");
            //klasorSilme("c:\\enderKlasor");
        }
        //static void yeniklasor(string path)
        //{
        //    DirectoryInfo directori = Directory.CreateDirectory(path);
        //}
        //static void klasorkontrol(string path)
        //{
        //    bool kontrol = Directory.Exists(path);
        //}
        //static void klasorSilme(string path)
        //{
        //    Directory.Delete(path,true);//true klasör doluysada silmesi için onay verme
        //}

        static void odev(string path)
        {
            string dosyaYolu = @"c:\\enderKlasor";
            bool kontrol = Directory.Exists(dosyaYolu);
            if (kontrol)
            {
                Console.WriteLine("Eklemek istediğiniz Klasör Mevcutta bulunmaktadır");
                Console.Write("Silip Yerine yenisini eklemek ister misiniz ? [E]/[H] ");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "E")
                {
                    Directory.Delete(dosyaYolu, true);
                    Console.WriteLine("Dosyanız Başarılı silindi");
                    System.Threading.Thread.Sleep(3000);
                    Directory.CreateDirectory(dosyaYolu); 
                    Console.WriteLine("Yeni Dosyanız Başarılı Olarak oluşturuldu");

                }
                else if (cevap == "H") 
                {
                    Console.WriteLine("İsleminiz Tamamlandı");
                }
                else
                {
                    Console.WriteLine("Yanlış Tuşlama Yaptınız!");
                }
                
            }
            else
            {
               DirectoryInfo d1= Directory.CreateDirectory(dosyaYolu);

                if (d1.Exists)
                {
                    Console.WriteLine("Dosya sistemde oluşturuldu ");
                }
                else
                {
                    Console.WriteLine("Dosya Sitemde oluşturulama Lütfen tekrar deneyinzi");
                }

            }
        }
    }
}
