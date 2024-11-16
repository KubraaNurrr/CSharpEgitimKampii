using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Döngüler (For döngüsü)
            //Döngüler 1+2+3+4+5+6 (1+2=3+3=6+4=10+5=15+6=21)
            //For(x;y;) 3 parametresi vardır. x başlangıç, y bitiş, z artış azalış değerini tutar.
            // Ekrana 5 defa yazı yazdırma

            //int i;
            //for(i=1; i<=5; i++) //i 1 den başlayıp 5 olana kadar 1-1 artacak.
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i=3; i<=50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finisValue = int.Parse(Console.ReadLine());

            //for(int i=1; i<=finisValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet"); //bizim verdiğimiz değer kadar bunu yazdırcaz.
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //// 1 - 100 arası 5'e tam bölünen sayılar listesi:
            //for(int i=1; i<=100; i++)
            //{
            //    if(i % 5 == 0) //5/5=0 5'in katı ekrana yazdır mantığı bu.
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////Ardışık sayıları toplama (n*(n+1) ile de olur bu yaptığımız döngü mantığıdır.)
            //int totalValue = 0;
            //for (int i =1; i<=10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //// 1 - 20 arası çift sayılar toplamı
            //int totalValue = 0;
            //for(int i=1; i<20; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i); //her defasında i yazdırır. yani 2'ye tam bölünen sayıları gösterir.
            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine(totalValue);

            //// 1 - 50 arası 7'ye tam bölünen sayılar.
            //int count = 0;
            //for(int i=1; i<=50; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++; //sayı 7 ise count1 oldu sayı 14 ise count 2 oldu vb.
            //    }
            //}
            //Console.WriteLine(count);

            ////bakteri her saatin sonu kendini 2'ye bölerek çoğaltmaktadır.
            //// 24 saat sonunda oluşan bakteriyi bulacağız.
            //int bacterium = 1;
            //for(int i=1; i<=24; i++) //saat değerini tutacak.
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacterium);
            //}

            #endregion

            #region While Döngüsü
            // şart sağlandığı müddetçe anlamındadır.
            //while(şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //// 1 - 10 3'e tam bölşünen sayılar.
            //int i = 1;
            //while (i <= 10)
            //{
            //    if ( i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //// 1 - 10 arasındaki sayıların toplamı.
            //int i = 1;
            //int sum = 0;
            //while(i<=10)
            //{
            //    sum += i; //i'den gelen değerler.
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            ////klavyeden girilen 3 basamaklı sayının basamakları toplamını
            ////hesaplayan kodu yazınız. 456

            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //hundreds = number / 100; //4.56 --> 4
            //tens = (number % 100)/10;
            //Console.WriteLine("Sayının birler basamağı: " +ones);
            //Console.WriteLine("Sayının onlar basamağı: " + tens);
            //Console.WriteLine("Sayının yüzler basamağı: " + hundreds);
            

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
