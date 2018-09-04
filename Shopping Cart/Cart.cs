using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Cart:ICart
    {
        public int ItemId { get; set; }
        public int TotalQty { get; set; }
        public double TotalPrice { get; set; }

        public void AddItemsToCart(int ItemId, int ItemQty, double ItemPrice)
        {
            throw new NotImplementedException();
        }

        public void ClearCart()
        {
            throw new NotImplementedException();
        }

        public void RemoveItemsFromCart(int ItemId)
        {
            throw new NotImplementedException();
        }

        public void ShowCart()
        {
            throw new NotImplementedException();
        }

        public double TotalAmountOfCart()
        {
            throw new NotImplementedException();
        }
    }
}
