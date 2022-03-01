using System;
using System.Data.SqlClient;
using System.Windows.Forms;
/**
*  @author  : Sıla Eşme
*  @number  : 152120181004
*  @mail    : silaesme@gmail.com
*  @date    : 03.06.21
*  @brief   : It's the displaying shopping cart items together. 
*/
namespace OnlineBookStore
{
    /// <summary>
    /// UserControlShoppingCart Class is used for displaying shopping cart items together.
    /// </summary>
    public partial class UserControlShoppingCart : UserControl
    {
        private UserControlBooks userControlBooks = UserControlBooks.CreateControlBooks();
        private UserControlMusicCDs userControlMusicCDs = UserControlMusicCDs.CreateControlCDs();
        private UserControlMagazines userControlMagazines = UserControlMagazines.CreateControlMagazines();
        private UserControlProductDetails userControlProductDetails = UserControlProductDetails.CreateProductDetails();
        private UserControlMusicCDDetail userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
        private UserControlMagazineDetails userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();
        UserControlPayment userControlPayment = UserControlPayment.CreateUserControlPayment();

        private ShoppingCart shoppingCart =  ShoppingCart.CreateShoppingCart();

        public ShoppingCart ShoppingCart
        {
            get => shoppingCart;
        }
        public FlowLayoutPanel flowLayoutPanel
        {
            get => flowLayoutPanel;
        }
        private static UserControlShoppingCart userControlShoppingCart;
        /// <summary>
        /// Instance function is a singleton design pattern. Only creates an object if it is not created.
        /// </summary>
        /// <returns>returns existing userControlShoppingCart </returns>
        public static UserControlShoppingCart Instance()
        {
            if (userControlShoppingCart == null)
                userControlShoppingCart = new UserControlShoppingCart();
            return userControlShoppingCart;
        }
        /// <summary>
        /// Constructor of UserControlShoppingCart Class.
        /// </summary>
        public UserControlShoppingCart()
        {
            InitializeComponent();
            userControlShoppingCart = this;
        }
       
        public void SetLabelAmount(string amount)
        {
            lblTotalAmount.Text = amount;
        }

        public void SetLabelPrice(string price)
        {
            lblTotalPrice.Text = price;
        }

        public string GetLabelAmount()
        {
            return lblTotalAmount.Text;
        }

        public string GetLabelPrice()
        {
            return lblTotalPrice.Text.Replace('.',',');
        }

        /// <summary>
        /// btnCancel_Click function Clears the shopping cart items from shopping cart list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            shoppingCart.ClearCart();
        }
        /// <summary>
        /// btnOrder_Click function is directing customer to the payment page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlMagazines.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            FormMainPage.Instance()._UserControlMyPage.Visible = false;
            FormMainPage.Instance()._UserControlChangeInformations.Visible = false;
            userControlPayment.Visible = true;
            userControlPayment.CalculateTotal();

            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlPayment);
        }
    }
}