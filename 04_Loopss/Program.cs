using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loopss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Dögüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For (x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //ekrana 5 defa yazdırma
            //09:26 dakikada sıralama açıklaması var

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adeti giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları

            // 1-100 arası 5 e tam bölünen sayıları yazdırma
            //for (int i = 1; i <= 100; i++)   
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1 den 10 a kadar olan sayıları  yazdırma
            //17:20 dk

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //1-20 arası çift sayılar toplamı
            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine(totalValue);


            //1-50 arası 7 ye tam bölünen kaç sayı var
            //20:25
            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //    Console.WriteLine(count);

            //bakteri her saat sonu kendini 2 ye bölerek çoğalıyor, yenileri de 2 ye bölünerek çoğalıyor, 24 saatin sonunda kaç bakteri olur

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat sonunda: " + bacterium);
            //}



            #endregion

            #region While Döngüsü

            //şart sağlandığı müddetçe demektir
            //While(Şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //1-10 arası 3 e tam bölünen sayılar
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            ////1-10 arası sayılar toplamı
            //int i = 1;
            //int sum = 0;
            //while(i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);


            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız

            //456

            //Console.Write("Sayıyı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10; 
            //tens = number % 100 / 10; 
            //hundreds = number / 100;
            
            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);




            #endregion
        }
    }
}
