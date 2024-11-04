using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("***** Menü Spariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection conection = new SqlConnection("Data Source=DESKTOP-QKPIVHK;initial Catalog=EgitimKampiDb;integrated security=true");
            //conection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values(@p1)", conection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //conection.Close();

            //Console.Write("Kategori Başarıyla Eklendi.");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection conection = new SqlConnection("Data Source=DESKTOP-QKPIVHK;initial Catalog=EgitimKampiDb;integrated security=true");
            //conection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", conection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //conection.Close();
            //Console.Write("Ürün Eklemsi Başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection conection = new SqlConnection("Data Source=DESKTOP-QKPIVHK;initial Catalog=EgitimKampiDb;integrated security=true");
            //conection.Open();
            //SqlCommand command = new SqlCommand("select * from TblProduct", conection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+"  ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection conection = new SqlConnection("Data Source=DESKTOP-QKPIVHK;initial Catalog=EgitimKampiDb;integrated security=true");
            //conection.Open();

            //SqlCommand command = new SqlCommand("delete from TblProduct where ProductId=@productId",conection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //conection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı.");




            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection conection = new SqlConnection("Data Source=DESKTOP-QKPIVHK;initial Catalog=EgitimKampiDb;integrated security=true");
            conection.Open();

            SqlCommand command = new SqlCommand("update TblProduct set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",conection);
            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@productPrice",productPrice);
            command.Parameters.AddWithValue("@productId",productId);
            command.ExecuteNonQuery();

            conection.Close();
            Console.WriteLine("Güncelleme Başarılı");




            #endregion

            Console.Read();
        }
    }
}
