using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    interface ICart
    {
        void AddItemsToCart(int ItemId, int ItemQty, double ItemPrice);
        void RemoveItemsFromCart(int ItemId);
        double TotalAmountOfCart();
        void ShowCart();
        void ClearCart();
    }
}
