using System;
using System.Net.Http.Headers;

namespace Homework1
{
    class Program
    {
        private static object product;

        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Categories = "Saat";
            product1.ProductName = "Daniel Klein Erkek Gümüş Çelik Kordon";
            product1.ProductQuantity = 94;
            product1.UnitPrice = 525;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Categories = "Saat";
            product2.ProductName = "Casio Mtp-v300d";
            product2.ProductQuantity = 4;
            product2.UnitPrice = 599;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Categories = "Saat";
            product3.ProductName = "Q&Q Erkek Kol Saati 3g2477 Metal Siyah";
            product3.ProductQuantity = 4;
            product3.UnitPrice = 299;

            Product product4 = new Product();
            product4.Id = 4;
            product4.Categories = "Saat";
            product4.ProductName = "Calvin Klein Erkek Kol Saati K3M5155N";
            product4.ProductQuantity = 2;
            product4.UnitPrice = 1975;

            Product[] products = new Product[] { product1, product2, product3, product4 };

            //Foreach
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.UnitPrice  );
            }

            
            {
                Console.WriteLine("*********************");
            }
            //For
            for (int i = 0; i <products.Length; i++)
            {
                Console.WriteLine(products[i].Id + " : " + products[i].ProductName );
            }

            {
                Console.WriteLine("+++++++++++++++++++++");
            }
            //while
            int sayac = 0;
            while (sayac < products.Length)
            {
                Console.WriteLine(products[sayac].ProductName + " : " + products[sayac].Categories);
                sayac++;
            }

        }

        class Product
        {
            public int Id { get; set; }
            public string Categories { get; set; }
            public string ProductName { get; set; }
            public int UnitPrice { get; set; }
            public int ProductQuantity { get; set; }

        }
    }
}
