using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class User
    {
        static void Main(string[] args)
        {
            List<Items> item = new List<Items>()
            {
                new Items(){ItemId=101,ItemName="ABC",ItemPrice=1000,ItemQty=2 },
                new Items(){ItemId=102,ItemName="PQR",ItemPrice=2000,ItemQty=1 },
                new Items(){ItemId=103,ItemName="XYZ",ItemPrice=3000,ItemQty=1 }
            };
            Cart cart = new Cart();

            Console.WriteLine("-----------Shopping Cart-----------"); ;
            Console.WriteLine("Available Items");
            foreach(Items items in item)
            {
                Console.WriteLine("Item ID: " + items.ItemId);
                Console.WriteLine("Item Name: " + items.ItemName);
                Console.WriteLine("Item Price: " + items.ItemPrice);
                Console.WriteLine("Item Qty: " + items.ItemQty);
            }
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Add Items to Cart");
                Console.WriteLine("2. Remove Items from Cart");
                Console.WriteLine("3. Show Cart");
                Console.WriteLine("4. Show Total Number of Items in the Cart");
                Console.WriteLine("5. Show Total Price");
                Console.WriteLine("6. Clear Cart");
                Console.WriteLine("7. Exit");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                int productId;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter ID of the Product to be Added");
                        int.TryParse(Console.ReadLine(), out productId);
                        cart.AddItemsToCart(productId, item);
                        break;
                    case 2:
                        Console.WriteLine("Enter ID of the Product to be Removed");
                        int.TryParse(Console.ReadLine(), out productId);
                        cart.RemoveItemsFromCart(productId);
                        break;
                    case 3:
                        cart.ShowCart();
                        break;
                    case 4:
                        Console.WriteLine("Total Number of Items");
                        Console.WriteLine(cart.TotalItems());
                        break;
                    case 5:
                        Console.WriteLine("Total Price");
                        Console.WriteLine(cart.TotalAmountOfCart());
                        break;
                    case 6:
                        cart.ClearCart();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Choose a Correct Option");
                        break;
                }
            } while (true);
        }
    }
}
