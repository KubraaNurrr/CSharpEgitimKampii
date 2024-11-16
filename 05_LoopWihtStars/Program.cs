using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWihtStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız OLuşturma

            //for(int i=1; i<=10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Üçgen

            //for(int i=1; i<=5; i++)
            //{
            //    for(int j=1; j<=i; j++ )
            //    {
            //        Console.Write("*"); // 5*2 gibi yapıp 10 yıldız oldu (j<=2 iken)
            //    }
            //    Console.WriteLine(); // 5 tane 2 yıldız göründü
            //}

            #endregion

            #region Ters Dik Üçgen

            //for (int i=5 ; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*"); 
            //    }
            //    Console.WriteLine(); 
            //}

            #endregion

            #region Dik ve Ters Dik Üçgen Beraber

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >=1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            //int n = 5;
            //for(int i=n; i>=1; i--)
            //{
            //    //boşluklar
            //    for(int j=n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
           
            //}

            #endregion

            Console.Read();


        }
    }
}
