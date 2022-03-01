/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's the user control of the cd.
*/
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMusicCD : UserControl
    {
        private UserControlMusicCDDetail userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
        private MusicCD musicCD = new MusicCD();
        /// <summary>
        /// This is constructor.
        /// </summary>
        public UserControlMusicCD()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function reads the relevant database table and sets labels and pictute box it has.
        /// </summary>
        /// <param name="name">Name of the MusicCD</param>
        /// <param name="Price">Price of the MusicCD</param>
        public void SetLabelMusicCD(string name, string Price)//küçük booklar için
        {
            lblName.Text = name;
            lblPrice.Text = Price;

            Database database = Database.CreateSingle();
            database.GetConnection();

            string imagename = "";
            var dirs = Directory.GetFiles(@"MusicCD Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            SqlCommand command = new SqlCommand("SELECT ImagePath FROM dbo.Music_CDs WHERE name = @name", Database.CreateSingle().Sqlconnection);
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
                    pictureBoxMusicCD.Image = new Bitmap(item);
                }
            }
        }

        public MusicCD _musicCD
        {
            get => musicCD;
            set => musicCD = value;
        }
        /// <summary>
        /// This function handles read more button click event.
        /// It triggers when read more button clicked.
        /// It  directs user to UserControl that contains informations of MusicCD and sets informations to the user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadMore_Click(object sender, EventArgs e)
        {
            UserControlBooks.CreateControlBooks().Visible = false;
            UserControlMusicCDs.CreateControlCDs().Visible = false;
            UserControlMagazines.CreateControlMagazines().Visible = false;
            UserControlShoppingCart.Instance().Visible = false;

            userControlMusicCDDetail.SetMusicCDInfo(musicCD.ProductName, musicCD.Singer, musicCD.ProductPrice,
            musicCD.Type);
            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlMusicCDDetail);

            userControlMusicCDDetail.Visible = true;
        }
    }
}