using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Article
    {
        private string nameProduct;
        public string NameProduct { get { return nameProduct; } set { nameProduct = value; } }

        private string nameMagazine;
        public string NameMagazine { get { return nameMagazine; } set { nameMagazine = value; } }

        private int price;
        public int Price { get { return price; } set { price = value; } }


        public Article(string nameProduct, string nameMagazine, int price)
        {
            NameMagazine = nameMagazine;
            NameProduct = nameProduct;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine($"{NameProduct} - {NameMagazine} - {Price}");
        }
    }


}
