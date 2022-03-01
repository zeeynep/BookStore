/**
*  @author  : Sıla Eşme
*  @number  : 152120181004
*  @mail    : silaesme@gmail.com
*  @date    : 03.06.21
*  @brief   : It's ShoppingCart.
*/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    /// <summary>
    /// This class contains shopping cart list and operations.
    /// </summary>
    public class ShoppingCart
    {
        private Customer customer = Customer.CreateCustomer();
        ///<list type = "ItemToPurchase" > this contains products and amounts of them. </List>
        private List<ItemToPurchase> list = new List<ItemToPurchase>();

        private static ShoppingCart shoppingCart;
        /// <summary>
        /// This function is for implement Singleton Pattern.
        /// </summary>
        /// <returns>Non Null ShoppingCart object</returns>
        public static ShoppingCart CreateShoppingCart()
        {
            if (shoppingCart == null)
                shoppingCart = new ShoppingCart();
            return shoppingCart;
        }
        private enum PaymentType
        { cash, CreditCard }

        /// <summary>
        /// This is constructor
        /// </summary>
        protected ShoppingCart()
        {
        }

        public List<ItemToPurchase> List
        {
            get => list;
        }
        /// <summary>
        /// This functions reads cart items' informations from the database and creates objects type of ItemToPurchase.
        /// </summary>
        private void GetList()
        {
            SqlCommand command = new SqlCommand("SELECT ProductName, Price, Amount, ProductType FROM dbo.ShoppingCart where OrderNo is NULL and Username = '" + Customer.CreateCustomer().userInfo.Username + "'", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                ProductFactory factory = new ProductFactory();
                Product product = factory.getProduct(dr.GetString(3));
                ItemToPurchase itemToPurchase = new ItemToPurchase();
                product.ProductName = dr.GetString(0);
                product.ProductPrice = dr.GetString(1);
                itemToPurchase.Product = product;
                itemToPurchase.Quantity = dr.GetString(2);
                AddProduct(itemToPurchase);
            }
            Database.CreateSingle().Sqlconnection.Close();
        }

        /// <summary>
        /// This function reads the products in the cart list and creates a usercontrol from them and adds them to the relevant panel.
        /// </summary>
        public void ListCart()
        {
            this.List.Clear();
            UserControlShoppingCart.Instance().flowLayoutPanelProducts.Controls.Clear();
            GetList();
            double totalprice = 0;
            int totalamount = 0;
            foreach (var item in List)
            {
                UserControlShoppingCartItem cartItem = new UserControlShoppingCartItem();
                cartItem.SetLabel(item.Product.ProductName, item.Product.ProductPrice, item.Quantity);
                UserControlShoppingCart.Instance().flowLayoutPanelProducts.Controls.Add(cartItem);
                item.Product.ProductPrice = item.Product.ProductPrice.Replace('.', ',');

                totalprice += Double.Parse(item.Product.ProductPrice) * Int32.Parse(item.Quantity);
                totalamount += Int32.Parse(item.Quantity);
            }
            UserControlShoppingCart.Instance().SetLabelPrice(totalprice.ToString().Replace(',', '.'));
            UserControlShoppingCart.Instance().SetLabelAmount(totalamount.ToString());
        }

        /// <summary>
        /// This function adds product and it's amount(ItemToPurchase) to the list
        /// </summary>
        /// <param name="item">Contains product and it's amount</param>
        public void AddProduct(ItemToPurchase item)
        {
            list.Add(item);
        }
        /// <summary>
        /// This function removes product and it's amount(ItemToPurchase) to the list
        /// </summary>
        /// <param name="item">Contains product and it's amount</param>
        public void RemoveProduct(ItemToPurchase item)
        {
            list.Remove(item);
        }
        /// <summary>
        /// This function clears list and relevant database table by order number and username.
        /// </summary>
        /// <param name="no">It is order number</param>
        public void ClearCart(int no)
        {
            UserControlShoppingCart userControlShoppingCart = UserControlShoppingCart.Instance();
            List.Clear();
            userControlShoppingCart.flowLayoutPanelProducts.Controls.Clear();
            userControlShoppingCart.SetLabelAmount("0");
            userControlShoppingCart.SetLabelPrice("0");

            SqlCommand command = new SqlCommand("delete FROM dbo.ShoppingCart where Username = @username and OrderNo = @no", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            command.Parameters.AddWithValue("@no", no);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }
        /// <summary>
        /// This function clears list and relevant database table by username.
        /// </summary>
        public void ClearCart()
        {
            UserControlShoppingCart userControlShoppingCart = UserControlShoppingCart.Instance();
            List.Clear();
            userControlShoppingCart.flowLayoutPanelProducts.Controls.Clear();
            userControlShoppingCart.SetLabelAmount("0");
            userControlShoppingCart.SetLabelPrice("0");

            SqlCommand command = new SqlCommand("delete FROM dbo.ShoppingCart where Username = @username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }
        /// <summary>
        /// This function places order.
        /// </summary>
        /// <param name="invoice">It determines the way that how the send invoice.</param>
        public void PlaceOrder(string invoice)
        {
            MessageBox.Show("Your Order has been created! " + invoice, "New Order", MessageBoxButtons.OK);
        }

        /// <summary>
        /// This function cancels existing order and removes items which are in the order.
        /// </summary>
        /// <param name="no">This is order number</param>
        public void CancelOrder(int no)
        {
            ClearCart(no);
            SqlCommand command = new SqlCommand("DELETE from OrderList where OrderNumber = @no", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@no", no);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>This is message stating that the invoice will be sent as SMS</returns>
        public string SendInvoiceBySMS()
        {
            return "Your invoice will be sent via SMS.";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>This is message stating that the invoice will be sent as E-Mail</returns>
        public string SendInvoiceByEMail()
        {
            return "Your invoice will be sent via E-Mail.";
        }
    }
}