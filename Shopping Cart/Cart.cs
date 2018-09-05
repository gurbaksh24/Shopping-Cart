using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Cart:ICartOperations
    {
        static List<Items> cartItems = new List<Items>(); 
        public void AddItemsToCart(int itemId,List<Items> items)
        {
            int exist = 0;
            foreach(Items cardItem in cartItems)
            {
                if(cardItem.ItemId==itemId)
                {
                    exist = 1;
                }
            }
            if (exist == 0)
            {
                cartItems.Add(items.Find(id => id.ItemId == itemId));
                Console.WriteLine("Item added to cart");
            }
            else
                Console.WriteLine("Item ID already exist");
        }

        public void ClearCart()
        {
            if (cartItems.Count() == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                cartItems.Clear();
                Console.WriteLine("Cart is cleared");
            }
        }

        public void RemoveItemsFromCart(int itemId)
        {
            int exist = 0;
            if (cartItems.Count() == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                foreach (Items cardItem in cartItems)
                {
                    if (cardItem.ItemId == itemId)
                    {
                        exist = 1;
                    }
                }
                if (exist == 1)
                {
                    cartItems.Remove(cartItems.Find(id => id.ItemId == itemId));
                    Console.WriteLine("Item removed");
                }
                else
                    Console.WriteLine("Item ID doesn't exist");
            }
        }

        public void ShowCart()
        {
            if (cartItems.Count() == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("Available Items in the Cart");
                foreach (Items items in cartItems)
                {
                    Console.WriteLine("Item ID: " + items.ItemId);
                    Console.WriteLine("Item Name: " + items.ItemName);
                    Console.WriteLine("Item Price: " + items.ItemPrice);
                    Console.WriteLine("Item Qty: " + items.ItemQty);
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Total Qty: " + TotalItems());
                Console.WriteLine("Total Price: " + TotalAmountOfCart());
            }
        }

        public double TotalAmountOfCart()
        {
            double totalAmount = 0f;
            foreach(Items items in cartItems)
            {
                totalAmount += items.ItemPrice;
            }
            return totalAmount;
        }

        public int TotalItems()
        {
            int totalQty = 0;
            foreach (Items items in cartItems)
            {
                totalQty += items.ItemQty;
            }
            return totalQty;
        }
    }
}
