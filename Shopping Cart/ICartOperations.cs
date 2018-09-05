using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    interface ICartOperations
    {
        void AddItemsToCart(int ItemId, List<Items> items);
        void RemoveItemsFromCart(int ItemId);
        double TotalAmountOfCart();
        void ShowCart();
        void ClearCart();
    }
}
