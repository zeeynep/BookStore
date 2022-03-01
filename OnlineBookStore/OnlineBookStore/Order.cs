using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class Order
    {
        string orderNumber;
        string dateTime;
        List<ItemToPurchase> productList = new List<ItemToPurchase>();

        public Order(string on, string date)
        {
            orderNumber = on;
            FillList();
        }
        public string OrderNumber
        {
            get => orderNumber;
        }
        public void FillList()
        {
            ShoppingCart shoppingCart = ShoppingCart.CreateShoppingCart();
            productList = shoppingCart.List;

        }
    }
}
