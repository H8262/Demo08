using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class ShoppingList
    {
        List<Product> list;

        public ShoppingList()
        {
            list = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            list.Add(product);
        }
        public void ShowList()
        {
            foreach (Product product in list)
            {
                Console.WriteLine(product.ToString());
            }
        }
        public void SaveList()
        {
            System.IO.StreamWriter outputfile = new System.IO.StreamWriter(@"Z:\Dox\Desktop\ShoppingList.txt");
            outputfile.WriteLine("Shopping list: ");
            foreach (Product product in list)
            {
                outputfile.WriteLine(product.ToString());
            }
            outputfile.Close();
        }
    }
}
