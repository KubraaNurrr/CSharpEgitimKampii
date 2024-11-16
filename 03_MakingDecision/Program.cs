using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            ////Kullanıcıdan değer alıp bizim istediğimiz değer olup olmadığını kontrol etme.
            //string password;
            //Console.Write("Lütfen şifreyi giriniz: ");
            //password = Console.ReadLine(); //consoldaki yazıyı passwordde okunsun demek.
            //if(password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number ==5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            ////Sınav ortalamasına göre değerlendirme sonucu yapma.
            //int exam1, exam2, exam3, avarage;
            //string result="Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + avarage);

            //if(avarage>0 & avarage<=50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if(avarage>50 & avarage<=70)
            //{
            //    result = "Sonuç orta";
            //}
            //if(avarage>70 & avarage<=84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if(avarage>84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez!");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}



            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.WriteLine("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 ==0 )
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}

            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team=='g' | team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Menü Projesi
            Console.WriteLine("****** C# EĞİTİM KAMPI RESTORAN ******");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Çorbalar");
            Console.WriteLine("3- Pizzalar");
            Console.WriteLine("4- İçecekler");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            string menuItem;
            Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("-------------- Ana Yemekler --------------");
                Console.WriteLine();
                Console.WriteLine("1- Köri Soslu Tavuk");
                Console.WriteLine("2- Kızartma Tabağı");
                Console.WriteLine("3- Fasulye Pilav");
                Console.WriteLine("4- Fırında Somon");
                Console.WriteLine("5- Patlıcan Musakka");
                Console.WriteLine("-------------- Ana Yemekler --------------");

                Console.WriteLine();
            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("-------------- Çorbalar --------------");
                Console.WriteLine();
                Console.WriteLine("1- Mercimek Çorbası");
                Console.WriteLine("2- Ezogelin Çorbası");
                Console.WriteLine("-------------- Çorbalar --------------");

                Console.WriteLine();
            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("-------------- Pizzalar --------------");
                Console.WriteLine();
                Console.WriteLine("1- Akdeniz Pizza ");
                Console.WriteLine("2- Margarita");
                Console.WriteLine("3- Tavuklu Pizza");
                Console.WriteLine("-------------- Pizzalar --------------");

                Console.WriteLine();
            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("-------------- İçecekler --------------");
                Console.WriteLine();
                Console.WriteLine("1- Kola ");
                Console.WriteLine("2- Ayran");
                Console.WriteLine("3- Su");
                Console.WriteLine("-------------- İçecekler --------------");

                Console.WriteLine();
            }

            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("-------------- Tatlılar --------------");
                Console.WriteLine();
                Console.WriteLine("1- Triliçe ");
                Console.WriteLine("2- Kazandibi");
                Console.WriteLine("3- Sütlaç");
                Console.WriteLine("-------------- Tatlılar --------------");

                Console.WriteLine();
            }

            #endregion

            #region Switch Case

            ////Sayıya göre yılın aylarını veren uygulama
            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break; //bu işlemin bittiğini break ile belirtiyoruz.
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi"); break; //kullanıcı bunlar dışında veri girerse böyle görünecek.
            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}

            #endregion


            Console.ReadLine();
        }
    }
}
