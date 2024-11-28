using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ado.net --> SQL yapılarını kullanmamızı sağlayan bir çerçevedir

            Console.WriteLine("***** C# Veri Tabanlı Ürün - Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine(); //kullanıcıdan numara girme
            Console.WriteLine("--------------------------------------------");

            //SQL bağlantısı için kullanılacak komut --> SqlConnection 

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-031GI5CN; initial Catalog=EgitimKampiDb; integrated security=true ");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable(); //nesne örneği oluşturuyoruz. verileri geçici belleğe almamızı sağlar.

            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows) //datarow datatable gelen sınıftır.
            {
                foreach (var item in row.ItemArray) //rowdan gelen satırdan gelen dizinin içeriğidir.
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
