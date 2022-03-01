using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 03.06.21 
*  @brief   : It is used for creating order summary and order details.
*/
namespace OnlineBookStore
{
    /// <summary>
    /// UserControlMyOrders is used for creating order summary and order details.
    /// </summary>
    public partial class UserControlMyOrders : UserControl
    {

        private static UserControlMyOrders userControlMyOrders;
        /// <summary>
        /// CreateUserControlMyORders is a singleton design pattern that only creates object if it is null.
        /// </summary>
        /// <returns>returns existing userControlMyOrders</returns>
        public static UserControlMyOrders CreateUserControlMyORders()
        {
            if (userControlMyOrders == null)
                userControlMyOrders = new UserControlMyOrders();
            return userControlMyOrders;
        }
        /// <summary>
        /// Constructor of UserControlMyOrders class.
        /// </summary>
        protected UserControlMyOrders()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Tis function search database and Create order details user controls by order numbers and username.
        /// </summary>
        /// <param name="no"></param>
        public void CreateMyOrders(string no)//ürün detayları
        {
            SqlCommand command = new SqlCommand("SELECT ProductName,price,amount,OrderNo FROM dbo.ShoppingCart where username=@username and OrderNo=@no", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            command.Parameters.AddWithValue("@no", no);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                UserControlMyOrder userControlMyOrder = new UserControlMyOrder();
                userControlMyOrder.SetLabelOrders(dr.GetString(0), dr.GetString(2), dr.GetString(1), no);
                flowLayoutPanelOrderDetails.Controls.Add(userControlMyOrder);
            }
            Database.CreateSingle().Sqlconnection.Close();
        }

        /// <summary>
        /// CreateOrder function records the ordered products into database and my orders page by date time and order number.
        /// </summary>
        /// <returns></returns>
        public bool CreateOrder()//order list
        {
            SqlCommand command = new SqlCommand("SELECT OrderNumber,OrderTime,OrderTotalPrice,username FROM dbo.OrderList where username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);

            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();
            if(!dr.Read())
            {
                Database.CreateSingle().Sqlconnection.Close();
                return false;
            }
            else
            {
                while (dr.Read())
                {
                    UserControlMy_OrderList userControlMy_OrderList = new UserControlMy_OrderList();
                    userControlMy_OrderList.SetLabelOrder(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                    flowLayoutPanelOrders.Controls.Add(userControlMy_OrderList);
                }
            }
            Database.CreateSingle().Sqlconnection.Close();
            return true;
        }
        /// <summary>
        /// DeleteOrders function deletes the ordered items from my orders page.
        /// </summary>
        public void DeleteOrders()
        {
            flowLayoutPanelOrders.Controls.Clear();
        }
    }
}
