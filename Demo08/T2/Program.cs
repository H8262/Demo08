using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {

            ShoppingList list = new ShoppingList();
            Console.WriteLine("Create ShoppingList");
            int i = 0;
            do {
                Console.WriteLine("1. New product");
                Console.WriteLine("2. Inspect list");
                Console.WriteLine("3. Save list into desktop");
                Console.WriteLine("4. Go shopping");
                int menu = int.Parse(Console.ReadLine());                                
                switch (menu)
                {
                    case 1:
                        {
                            Product product = new Product();
                            Console.WriteLine("Name: ");
                            string name = Console.ReadLine();
                            product.Name = name;
                            Console.WriteLine("Value: ");
                            double value = double.Parse(Console.ReadLine());
                            product.Value = value;
                            list.AddProduct(product);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Your list contains: ");
                            list.ShowList();
                            break;
                        }
                    case 3:
                        {
                            list.SaveList();
                            Console.WriteLine("Saved!");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Bye!");
                            i = 1;
                            break;
                        }
                }

               } while (i == 0);



        }
    }
}
