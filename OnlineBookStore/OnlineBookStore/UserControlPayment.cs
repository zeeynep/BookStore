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
*  @date    : 03.06.21
*  @brief   : It's used for payment options for ordered items.
*/
namespace OnlineBookStore
{
    /// <summary>
    /// UserControlPayment Class is used for payment options for ordered items.
    /// </summary>
    public partial class UserControlPayment : UserControl
    {
        public bool flag = false;

        ShoppingCart ShoppingCart = ShoppingCart.CreateShoppingCart();
        Customer customer = Customer.CreateCustomer();
        UserControlMyOrders userControlMyOrders = UserControlMyOrders.CreateUserControlMyORders();
       
        private static UserControlPayment userControlPayment;
        /// <summary>
        /// CreateUserControlPayment is a singleton design pattern for UserControlPayment.
        /// </summary>
        /// <returns>returns existing userControlPayment</returns>
        public static UserControlPayment CreateUserControlPayment()
        {
            if (userControlPayment == null)
                userControlPayment = new UserControlPayment();
            return userControlPayment;

        }
        /// <summary>
        /// Constructor of userControlPayment class.
        /// </summary>
        public UserControlPayment()
        {
            InitializeComponent();
        }
        
        private void UserControlPayment_Load(object sender, EventArgs e)
        {
            UserControlShoppingCart UserControlShoppingCart = UserControlShoppingCart.Instance();
            lblTotalProduct.Text = UserControlShoppingCart.GetLabelPrice();
        }
        /// <summary>
        /// CalculateTotal function is calculates the installments of credit card.
        /// </summary>
        public void CalculateTotal()
        {
            UserControlShoppingCart UserControlShoppingCart = UserControlShoppingCart.Instance();
            lblTotalProduct.Text = UserControlShoppingCart.GetLabelPrice();
            double temp2 = 0;
            temp2 = Double.Parse(lblTotalProduct.Text) + Double.Parse(lblCargo.Text);
            lblFinalTotal.Text = temp2.ToString();

            lblTwo.Text = Math.Round ((Double.Parse(lblFinalTotal.Text) /2), 2).ToString();
            lblFour.Text = Math.Round((Double.Parse(lblFinalTotal.Text) /4), 2).ToString();
            lblFive.Text = Math.Round((Double.Parse(lblFinalTotal.Text) /5), 2).ToString();
            lblSix.Text = Math.Round((Double.Parse(lblFinalTotal.Text) /6), 2).ToString();

        }
        /// <summary>
        /// btnPurchaseNow_Click allows user to create an order if all the informations is filled correctly.Function adds the ordered items on database and My orders tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPurchaseNow_Click(object sender, EventArgs e)
        {
            flag = true;

            if (radioButtonYutici.Checked == false && radioButtonAras.Checked == false)
            {
                MessageBox.Show("Please Select a Cargo Company or Invoice Option!", "Fail Order", MessageBoxButtons.OK);
            }
            else
            {
                DateTime date = DateTime.Now;
                Random rand = new Random();
                int OrderNumber = rand.Next(10000, 999999);

                //---------------------------------SQL ORDERLİST
                SqlCommand command = new SqlCommand("insert into orderlist (OrderNumber,OrderTime,OrderTotalPrice,username) values (@orderno,@ordertime,@orderTotalPrice,@username)", Database.CreateSingle().Sqlconnection);

                command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
                command.Parameters.AddWithValue("@orderno", OrderNumber.ToString());
                command.Parameters.AddWithValue("@OrderTime", date.ToString());
                command.Parameters.AddWithValue("@orderTotalPrice", lblFinalTotal.Text);

                Database.CreateSingle().Sqlconnection.Open();
                command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();

                //--------------------------------SQL SHOPPINGCART
                SqlCommand command2 = new SqlCommand("UPDATE shoppingcart SET OrderNo = @no WHERE username=@username and OrderNo is NULL", Database.CreateSingle().Sqlconnection);

                command2.Parameters.AddWithValue("@no", OrderNumber.ToString());
                command2.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);

                Database.CreateSingle().Sqlconnection.Open();
                command2.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();

                //----------------------------------Shopping Cart İşlemleri-----------------------------------//
                string invoiceMessage = "";
                if (radioButtonSMS.Checked)
                {
                    invoiceMessage = ShoppingCart.SendInvoiceBySMS();
                }
                else if (radioButtonMail.Checked)
                {
                    invoiceMessage = ShoppingCart.SendInvoiceByEMail();
                }
                ShoppingCart.PlaceOrder(invoiceMessage);

            }

        }

        /// <summary>
        /// Sets Radio buttons if its cheched and rearranges the amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonYutici_CheckedChanged(object sender, EventArgs e)
        {
            lblCargo.Text = "11,90";
            CalculateTotal();
        }
        /// <summary>
        /// Sets Radio buttons if its cheched and rearranges the amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonAras_CheckedChanged_1(object sender, EventArgs e)
        {
            lblCargo.Text = "8,50";
            CalculateTotal();
        }

        /// <summary>
        /// Deletes a tab's informations if the other tab is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlCredit.SelectedTab==tabPageCash)
            {
            textBoxCreditNum.Text = "";
            textBoxNameCredit.Text = "";
            textBoxCVV.Text = "";
            comboBoxYear.Text = "";
            comboBoxMonth.Text = "";
            }
            else if (tabControlCredit.SelectedTab ==tabPageCreditCard)
            {
            textBoxCashBankNo.Text = "";
            textBoxCardNme.Text = "";
            textBoxCashCVV.Text = "";
            comboBoxCashMonth.Text = "";
            comboBoxCashYear.Text = "";
            }    
        }
    }
}
