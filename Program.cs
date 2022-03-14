using System;
using System.Data.SqlClient;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
//Değişkenler 
            //Kilo bilgisini tutacak bir değişken(byte, short, int, long)
         /*   byte kilo = 100;
            byte? kilo2 = null;
            //Plaka bilgisini tutacak bir değişken
            byte plaka = 81;
            string _plaka = "81";
            //Araç km bilgisini tutan bir değişken
            int km = 100000;
            //Müşteri id si tutacak bir değişken
            int müsteriId = 1;
            string musteri_id= "A1111";   
            //Bir ürünün satuşta olup olmadığunı tutuan bilgisi
            bool satışta = true;    
            //Maaş bilgisini tutacak değişken(float, double, decimal)
            float maas = 100000.00f;
            double maas2 = 100000.00;
            decimal maas3 = 100000.00m;
            //Öğrenci adını tutacak bir değişken
                string ad = "Nur";
                string soyad = "Berber";
                string adSoyad = ad + " " + soyad;  //Nur Berber

            //ENDdeğişkenler

            //Veritipi dönüşümü
            //implicit casting:smaller type to larger küçük veriyi büyük veriye çevirme
            int a = 10;
            long b=a;
            float e = 10.5f; //daha az kapisetli
            double f = e; //kapasite daha yüksel floata göre
          
            //explicit casting:larger type to smaller büyük veriyi küçük veriye çevirme
            long c = 10;
            int d = (int)c;

            double g = 10.6;
            float h = (float)g;

            double k = 10.5;
            int l =(int)k;

            int m = 23654;
            byte n = (byte)m;

            int x = 10;
            string z = x.ToString();*/

            //EndVeritipi dönüşümü

            GetSqlConnection();
        }

        static void GetSqlConnection()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=SSPI;";
            //connection.Open();
            //connection.Close();
            using(var connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    Console.WriteLine("Bağlantı başarılı");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Bağlantı başarısız");
                    Console.WriteLine(ex.Message);
                }
            
                {
                    Console.WriteLine("Bağlantı başarısız");
                }
            }
        }

    }
}
