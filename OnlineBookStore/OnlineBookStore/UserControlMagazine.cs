/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's the user control of the magazine.
*/
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMagazine : UserControl
    {
        private UserControlMagazineDetails userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();
        private Magazine magazine = new Magazine();

        public Magazine _Magazine
        {
            get => magazine;
            set => magazine = value;
        }
        /// <summary>
        /// This is constructor.
        /// </summary>
        public UserControlMagazine()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function reads the relevant database table and sets labels and pictute box it has.
        /// </summary>
        /// <param name="name">Name of the magazine</param>
        /// <param name="Price">Price of the magazine</param>
        public void SetLabelMagazine(string name, string Price)
        {
            Database database = Database.CreateSingle();
            database.GetConnection();

            lblName.Text = name;
            lblPrice.Text = Price;

            string imagename = "";
            var dirs = Directory.GetFiles(@"Magazine Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            SqlCommand command = new SqlCommand("SELECT ImagePath FROM dbo.Magazines WHERE name = @name", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", lblName.Text);
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
                    pictureBoxMagazine.Image = new Bitmap(item);
                }
            }
        }
        /// <summary>
        /// This function handles read more button click event.
        /// It triggers when read more button clicked.
        /// It  directs user to UserControl that contains informations of magazine and sets informations to the user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadMore_Click(object sender, EventArgs e)
        {
            UserControlBooks.CreateControlBooks().Visible = false;
            UserControlMusicCDs.CreateControlCDs().Visible = false;
            UserControlMagazines.CreateControlMagazines().Visible = false;
            UserControlShoppingCart.Instance().Visible = false;

            userControlMagazineDetails.SetMagazineInfo(magazine.ProductName, magazine.Issue, magazine.ProductPrice,
            magazine._TypeMagazine);
            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlMagazineDetails);

            userControlMagazineDetails.Visible = true;
        }
    }
}