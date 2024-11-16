using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            // bir yapının metot olduğunu anlayabilmemiz için sonuna () yapılır.
            // // metotlar ikiye ayrılı:
            // 1. Geriye değer döndürmeyen metotlar
            //Customer--> Listele, ekle, sil, güncelle
            // Void --> programlamada böyle tanımlanıyor.
            // 2. Geriye değer döndüren metotlar


            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //customerList();
            //customerList();
            //customerList();
            //customerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            // Müşteri kartı yapma:
            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //customerCard("Mehmet", "Yıldız");
            //customerCard("Ayşegül", "Kaya");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";  //bu metotda geriye döndürme işlemi return ile yapılır.
            //}

            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName  + " - Başkent:  " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));

            //Console.WriteLine(countryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(sum(45, 98));
            //Console.WriteLine(sum(36, 25));
            //Console.WriteLine(sum(44, 36));
            //Console.WriteLine(sum(14, 20));

            #endregion

            #region Örnek Uygulama

            //string examResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result >=50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti" + " Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi" + " Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(examResult("Ali", 25, 41, 55));
            //Console.WriteLine(examResult("Ayşe", 36, 88, 33));

            #endregion

            Console.Read();

        }
    }
}
