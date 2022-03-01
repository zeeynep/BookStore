using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's for books' informations.
*/
namespace OnlineBookStore
{
    /// <summary>
    /// UserControlMy_OrderList is used for displaying ordered items on a single user control and also canceling and viewing ordered items and their properties.
    /// </summary>
    public partial class UserControlMy_OrderList : UserControl
    {
        UserControlMyOrders userControlMyOrders = UserControlMyOrders.CreateUserControlMyORders();
        /// <summary>
        /// Constructor of UserControlMy_OrderList class.
        /// </summary>
        public UserControlMy_OrderList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sets the total price date and order number labels on ordered items pack.
        /// </summary>
        /// <param name="takipno"></param>
        /// <param name="Date"></param>
        /// <param name="total"></param>
        public void SetLabelOrder(string takipno, string Date, string total)
        {
            lblOrderNo.Text = takipno;
            lblDate.Text = Date;
            lblTotalPrice.Text = total;
        }
        /// <summary>
        /// Brings the details of the order on user controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            foreach (var item in userControlMyOrders.flowLayoutPanelOrderDetails.Controls.OfType<UserControlMyOrder>())
            {
                item.Visible = false;
            }
            userControlMyOrders.CreateMyOrders(lblOrderNo.Text);
        }
        /// <summary>
        /// This Function cancels the ordered items and removes it from history.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            ShoppingCart.CreateShoppingCart().CancelOrder(int.Parse(lblOrderNo.Text));
            userControlMyOrders.flowLayoutPanelOrders.Controls.Remove(this);
        }
    }
}
