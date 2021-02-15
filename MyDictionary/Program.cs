using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        { 
           
            Dictionary<int,string> product = new Dictionary<int,string>();
            Console.WriteLine("product.Count : " + product.Count);

            product.Add(1, "kalem a");
            product.Add(2, "kitap b");
            product.Add(3, "masa c");

            foreach (var products in product)
            {
                Console.WriteLine(products);

            }

            Console.WriteLine("products.Count : " + product.Count);


            Console.WriteLine("--------------------");

            MyDictionary<int, string> myProducts = new MyDictionary<int, string>();
            Console.WriteLine("myProducts.Count : " + myProducts.Count);

            myProducts.Add(1, "kitap a");
            myProducts.Add(2, "kitap b");
            myProducts.Add(3, "kitap c");

            foreach (var products in myProducts.KeyList)
            {
                Console.WriteLine(product);

            }

            foreach (var products in myProducts.ValueList)
            {
                Console.WriteLine(product);

            }



            Console.WriteLine("myProducts.Count : " + myProducts.Count);








            Console.ReadLine();
        }
    }
}
