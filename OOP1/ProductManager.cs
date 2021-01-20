using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapslation //daha az değişken vermek için Product kullan
        public void Add(Product product)
        {
            Console.WriteLine(product.Productname + " Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.Productname + "Güncellendi ");
        }
     
    }
}
