using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud --> 4 temel veritabanı işlemidir. Create - Read - Update - Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            //Amaç yeni bir kayıt eklemek.
            Console.WriteLine("----------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.WriteLine("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //// veritabanına yeni bir kategori eklemek istiyoruz sql ile değil c# ile ekleyeceğiz.
            //SqlConnection connection = new SqlConnection("Data Source = LAPTOP-********; initial catalog = EgitimKampiDb; integrated security = true ");
            //connection.Open();

            ////ekleme işlemi için ilk sorgu sqlcommand. sınıftan bir nesne örneği türetip bu türetmiş olduğumuz nesne örneğine ait metotları kullanacağız.
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection); // ınsert, into sql de içine ekle demektir. 
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); //koşulsuz bir şekilde sorguyu çalıştırmayı sağlar.

            //connection.Close(); //bağlantıyı kapattık

            //Console.Write("Kategori başarıyla eklendi!!");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.WriteLine("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-********; initial catalog = EgitimKampiDb; integrated security = true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values(@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true); //dışarıdan almıycaz başlangıçta hepsini true olarak kabul ettik.
            //command.ExecuteNonQuery(); //değişiklikleri kaydet ve bunu veritabanına yansıt.

            //connection.Close(); //bağlantıyı kapattık.
            //Console.Write("Ürün eklemesi başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-********; initial catalog = EgitimKampiDb; integrated security = true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection); //bağlantıyla ilişkilendirdik.
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //sql'de verileri çekerken verileri listelemeyi sağlarken bir köprü görevi gören komut sqldataadapterdir.
            //DataTable dataTable = new DataTable(); //verileri hafızaya geçici belleğe almak için kullandığımız komuttur dataTabledir.
            //adapter.Fill(dataTable);

            ////Oluşan verileri kullanıcıya göstermek için döngü kullanmalıyız.
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray) //ilgili satırın sütunlarına gittik
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-********; initial catalog = EgitimKampiDb; integrated security = true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery(); //değişiklikleri veritabanına yansıttık.

            //connection.Close();

            //Console.WriteLine("Silme işlemi başarıyla gerçekleşti!");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            
            
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-********; initial catalog = EgitimKampiDb; integrated security = true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, productPrice=@productPrice Where productId=@productId", connection); //güncelleme işlemini yapıyoruz.
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncellemeler başarıyla gerçekleşti!");

            #endregion


            Console.Read();

        
        }

    }
}
