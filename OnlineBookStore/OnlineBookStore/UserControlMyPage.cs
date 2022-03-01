using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
/**
*  @author  : Sıla Eşme
*  @number  : 152120181004
*  @mail    : silaesme@gmail.com
*  @date    : 03.06.21
*  @brief   : It is used for customers to display their informations.
*/
namespace OnlineBookStore
{
    /// <summary>
    /// UserControlMyPage is used for customers to display their informations.
    /// </summary>
    public partial class UserControlMyPage : UserControl
    {
        private Customer customer = Customer.CreateCustomer();
        private UserControlProductDetails userControlProductDetails = UserControlProductDetails.CreateProductDetails();
        private UserControlMusicCDDetail userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
        private UserControlMagazineDetails userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();
      
        private static UserControlMyPage userControlMyPage;
        public string lblname
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }
        public string lblsurname
        {
            get => lblSurname.Text;
            set => lblSurname.Text = value;
        }
        public string lblemail
        {
            get => lblEMail.Text;
            set => lblEMail.Text = value;
        }
        public string lbladdress
        {
            get => lblAddress.Text;
            set => lblAddress.Text = value;
        }
        /// <summary>
        /// CreateMyPage is a singleton design pattern for UserControlMyPage to be created just for once.
        /// </summary>
        /// <returns>returns existing userControlMyPage</returns>
        public static UserControlMyPage CreateMyPage()
        {
            if (userControlMyPage == null)
                userControlMyPage = new UserControlMyPage();
            return userControlMyPage;
        }
        /// <summary>
        /// Constructor of UserControlMyPage.
        /// </summary>
        protected UserControlMyPage()
        {
            userControlMyPage = this;
            InitializeComponent();
        }
        /// <summary>
        /// SetLabelMyPage function sets the labels and images with customers informations by reading it from database.
        /// </summary>
        public void SetLabelMyPage()
        {
            lblName.Text = customer.Name;
            lblSurname.Text = customer.Surname;
            lblEMail.Text = customer.Email;
            lblAddress.Text = customer.Adress;
            lblUsername.Text = customer.userInfo.Username;
            string imagename = "";
            var dirs = Directory.GetFiles(@"Profile Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            SqlCommand command = new SqlCommand("SELECT ImagePath FROM dbo.Customer WHERE username = @username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                imagename = dr.GetString(0);
            }
            Database.CreateSingle().Sqlconnection.Close();

            foreach (var item in dirs)
            {
                if (Path.GetFileName(item) == imagename)
                {
                    pictureBoxCustomer.Image = new Bitmap(item);
                }
            }
        }

        /// <summary>
        /// Directs customer to the Change information page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            UserControlBooks.CreateControlBooks().Visible = false;
            UserControlMusicCDs.CreateControlCDs().Visible = false;
            UserControlMagazines.CreateControlMagazines().Visible = false;
            UserControlShoppingCart.Instance().Visible = false;
            UserControlMyPage.CreateMyPage().Visible = false;

            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;

            FormMainPage.Instance()._UserControlChangeInformations.Visible = true;
            FormMainPage.Instance()._UserControlChangeInformations.SetTextBoxInfo();
            FormMainPage.Instance().panelProductDisplay.Controls.Add(FormMainPage.Instance()._UserControlChangeInformations);
        }
    }
}