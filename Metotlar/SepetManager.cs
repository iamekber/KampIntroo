using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Name);
        }

        public void Ekle2(string productName, string explain, double price, int stock)
        {
            Console.WriteLine("Sepete eklendi: " + productName);
        }
    }

}
