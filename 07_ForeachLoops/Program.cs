using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // 4 parametre alan bir döngüsür.
            //Foreach(1;2;3;4)
            // 1 : Değişken türü
            // 2 : Değişken adı
            // 3 : In komutu (içinde)
            // 4 : Liste, Koleksiyon, Dizi 'nin adıdır.

            //string[] cities = { "milano", "roma", "budaştepe", "ankara", "istanbul", "varşova" };
            //// dizinin tüm elemanlarını ekranda göstermek için foreach döngüsü kuruyoruz.
            //foreach(string x in cities) //x'in adı her şey olabilir. mantık şu x cities içine gidip sırasıyla bütün değerleri alıyor dizinin sonuna kadar.
            //                           //Fordan farkı şu dizinin başlangıcını bitişini kaçar kaçar artması gibi kurallarla uğraştırmıyor.
            //{
            //    Console.WriteLine(x);
            //}

            // Aritmetik ifadeler için:
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // dizide ki çift sayıları listeleme
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            // bir dizinin içinde yer alan sayıların toplamı
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach(int i in numbers)
            //{
            //    total += i; // total değerine i den gelen veriyi ekle.
            //}

            //Console.WriteLine(total);


            //List<int> numbers = new List<int>() //Listenin eleman tipi ve adı ile bir liste oluşturuyoeuz.
            //{
            //    1, 2, 3, 4, 5, 8 // listeye atama yaptık.
            //};

            //foreach(int number in numbers) //foreach döngüsü Liste + Dizilerle de çalışır.
            //{
            //    Console.WriteLine(number); //metinsel bir ifede çıkıyor. listenin ögeleri için foreach döngüsüne alıyoruz.
            //}


            // Bir kelimeyi harflerine ayıran ifade
            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            ////klavyeden öğrensi sayısı, ismi ve sınav notlarını alıp ortalamalarını hesaplayalım.
            
            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////sınıftaki öğrenci sayısını kullanıcıdan alma:
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var? ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler:
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            ////her öğrenci için notları toplamalıyız bu yüzden for döngüsü açıyoruz.
            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0; //toplam sınav sonuçları başlangıçta 0 olsun.

            //    //Her öğrenci için 3 sınav girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz (3 sınav notu toplanıyor)
            //    }

            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            //// Sınav ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------------");

            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");;

            //    //Öğrencilerin ortalaması ve geçip kalma durumu
            //    if(studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }

            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }

            //    Console.WriteLine("------------------------------------");

            //}

            #endregion

            Console.Read();

        }
    }
}
