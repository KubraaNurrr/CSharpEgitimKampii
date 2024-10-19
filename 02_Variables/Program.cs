using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = Encoding.UTF8; // ₺ işaretini yapıyor
            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + patatoPrice + " ₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " ₺");


            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;


            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram =0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            ////Console.WriteLine("Elmanın Toplam Fiyatı: " + appleTotalPrice);

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + patatoPrice + " - Gramaj: " + patatoGram + " - Toplam Tutar: " + patatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            // charlar ' ile tanımlanır !!!

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentyNumber;

            //Console.Write("Yolcu Adı: "); //kullanıcıya bilgi vericez.
            //passengerName = Console.ReadLine(); //yani isim dışarıdan alınacak.

            //Console.Write("Yolcu Soyadı: "); 
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentyNumber = Console.ReadLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentyNumber + " - Yolcu Ad Soyad: " + passengerName + " " 
            //    + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);
            ////ilk olarak yukarıda kendimiz klavyeden giricez. sonrasında son 2 satır klavyeden girilern bilgileri bize geri yansıtacak. 



            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            ////E Ticaret için satış paneli oluşturuyoeuz.

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount =int.Parse(Console.ReadLine()); //c# başlangıçta bütün veri girişini str kabul eder fakat burda int bir giriş için dönüşüm uyguluyoruz. 

            //Console.Write("Lütfen aldığınız bilgisayar sasyısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sasyısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sasyısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödmeniz gereken tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();

        }
    }
}
