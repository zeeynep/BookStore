/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's Main Form of the app.
*/
using System;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class FormMainPage : Form
    {
        private static FormMainPage mainPage;

        private ProductFactory factory = new ProductFactory();
        private UserControlBooks userControlBooks;
        private UserControlMusicCDs userControlMusicCDs;
        private UserControlMagazines UserControlMagazines;
        private UserControlShoppingCart userControlShoppingCart;

        private UserControlProductDetails userControlProductDetails;
        private UserControlMusicCDDetail userControlMusicCDDetail;
        private UserControlMagazineDetails userControlMagazineDetails;
        private UserControlChangeInformations userControlChangeInformations;
        private UserControlMyPage userControlMyPage;
        private UserControlPayment userControlPayment;
        private UserControlMyOrders userControlMyOrders;
        public UserControlMyPage _UserControlMyPage
        {
            get => userControlMyPage;
            set => userControlMyPage = value;
        }

        public UserControlChangeInformations _UserControlChangeInformations
        {
            get => userControlChangeInformations;
            set => userControlChangeInformations = value;
        }
        /// <summary>
        /// This function is for implement Singleton Pattern.
        /// </summary>
        /// <returns>Non Null FormMainPage object.</returns>
        public static FormMainPage Instance()
        {
            if (mainPage == null)
            {
                mainPage = new FormMainPage();
            }
            return mainPage;
        }

        /// <summary>
        /// This function is constructor.
        /// It Initialize components of form and creates intances of user controls.
        /// </summary>
        public FormMainPage()
        {
            InitializeComponent();
            mainPage = this;
            factory = new ProductFactory();
            userControlBooks = UserControlBooks.CreateControlBooks();
            userControlMusicCDs = UserControlMusicCDs.CreateControlCDs();
            UserControlMagazines = UserControlMagazines.CreateControlMagazines();
            userControlShoppingCart = UserControlShoppingCart.Instance();

            userControlProductDetails = UserControlProductDetails.CreateProductDetails();
            userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
            userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();
            userControlChangeInformations = new UserControlChangeInformations();
            userControlMyPage = UserControlMyPage.CreateMyPage();
            userControlPayment = UserControlPayment.CreateUserControlPayment();
            userControlMyOrders = UserControlMyOrders.CreateUserControlMyORders();
        }

        /// <summary>
        /// This function handles picturebox click event.
        /// It triggers when picturebox clicked.
        /// It closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This function handles Books button click event.
        /// It triggers when Books button clicked.
        /// It directs user to UserControlBooks user control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBooks_Click(object sender, EventArgs e)
        {
            userControlBooks.Visible = true;
            userControlMusicCDs.Visible = false;
            UserControlMagazines.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = false;
            userControlPayment.Visible = false;
            userControlMyOrders.Visible = false;

            userControlChangeInformations.Visible = false;
            userControlBooks.DeleteBook();
            factory.CreateProduct("Book");

            this.panelProductDisplay.Controls.Add(userControlBooks);
        }
        /// <summary>
        /// This function handles MusicCDs button click event.
        /// It triggers when MusicCDs button clicked.
        /// It directs user to UserControlMusicCDs user control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicCDs_Click(object sender, EventArgs e)
        {
            userControlMusicCDs.Visible = true;
            userControlBooks.Visible = false;
            UserControlMagazines.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyOrders.Visible = false;

            userControlPayment.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;

            userControlMusicCDs.DeleteMusicCD();
            factory.CreateProduct("MusicCD");

            this.panelProductDisplay.Controls.Add(userControlMusicCDs);
        }
        /// <summary>
        /// This function handles Magazines button click event.
        /// It triggers when Magazines button clicked.
        /// It directs user to UserControlMagazines user control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMagazines_Click(object sender, EventArgs e)
        {
            UserControlMagazines.Visible = true;
            UserControlMagazines.BringToFront();
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyOrders.Visible = false;

            userControlPayment.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;

            UserControlMagazines.DeleteMagazine();
            factory.CreateProduct("Magazine");

            this.panelProductDisplay.Controls.Add(UserControlMagazines);
        }
        /// <summary>
        /// This function handles MyPage button click event.
        /// It triggers when MyPage button clicked.
        /// It directs user to UserControlMyPage user control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyPage_Click(object sender, EventArgs e)
        {
            UserControlMagazines.Visible = false;
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlPayment.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyOrders.Visible = false;

            userControlMyPage.Visible = true;
            userControlMyPage.BringToFront();
            userControlChangeInformations.Visible = false;

            userControlMyPage.SetLabelMyPage();
            this.panelProductDisplay.Controls.Add(userControlMyPage);
        }
        /// <summary>
        /// This function handles Books button click event.
        /// It triggers when Books button clicked.
        /// It directs user to UserControlBooks user control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            UserControlMagazines.Visible = false;
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlPayment.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;
            userControlMyOrders.Visible = false;

            userControlShoppingCart.Visible = true;
            userControlShoppingCart.BringToFront();
            userControlShoppingCart.ShoppingCart.ListCart();
            this.panelProductDisplay.Controls.Add(userControlShoppingCart);
        }

        /// <summary>
        /// This function handles Sign Out button click event.
        /// It triggers when sign out button clicked.
        /// It directs user to log in form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }
        /// <summary>
        /// This function handles Form's load event.
        /// It triggers when form loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMainPage_Load(object sender, EventArgs e)
        {
            btnBooks_Click(sender,e);
        }
        /// <summary>
        /// This function handles MyOrders button click event.
        /// It triggers when MyOrders button clicked.
        /// It directs user to UserControlMyOrders user control.
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void btnMyOrders_Click(object sender, EventArgs e)
        {

            userControlBooks.Visible = false;
            userControlMusicCDs.Visible = false;
            UserControlMagazines.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;
            userControlPayment.Visible = false;

            userControlMyOrders.DeleteOrders();

            if(userControlMyOrders.CreateOrder()==false)
            {
                DialogResult dialog = new DialogResult();
                dialog= MessageBox.Show("You have not ordered anything yet!", "Fail Order", MessageBoxButtons.OK);
                if(dialog == DialogResult.OK)
                {
                    btnShoppingCart_Click(sender,e);
                }
            }
            else
            {
                userControlMyOrders.Visible = true;
                userControlMyOrders.BringToFront();
                this.panelProductDisplay.Controls.Add(userControlMyOrders);
            }
           

        }
    }
}