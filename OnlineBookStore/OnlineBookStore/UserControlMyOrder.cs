using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 03.06.21
*  @brief   : It is used for creating ordered items user controls.
*/
namespace OnlineBookStore
{
    /// <summary>
    /// UserControlMyOrder is used for creating ordered items user controls.
    /// </summary>
    public partial class UserControlMyOrder : UserControl
    {
        /// <summary>
        /// Constructor of UserControlMyOrder class.
        /// </summary>
        public UserControlMyOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function sets the labels by parameters of ordered item to display it. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        /// <param name="price"></param>
        /// <param name="no"></param>
        public void SetLabelOrders(string name, string amount, string price, string no)
        {
            lblOrderNo.Text = no;
            lblName.Text = name;
            lblPrice.Text = price;
            lblTotalAmount.Text = amount;
            lblTotalPrice.Text = (Double.Parse(lblPrice.Text.Replace('.', ',')) * Double.Parse(lblTotalAmount.Text)).ToString();
        }

    }
}
