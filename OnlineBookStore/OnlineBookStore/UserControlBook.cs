/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's the user control of the book.
*/
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlBook : UserControl
    {
        private UserControlProductDetails userControlProductDetails = UserControlProductDetails.CreateProductDetails();
        private Book book = new Book();

        public Book _Book
        {
            get => book;
            set => book = value;
        }
        /// <summary>
        /// This is constructor.
        /// </summary>
        public UserControlBook()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function reads the relevant database table and sets labels and pictute box it has.
        /// </summary>
        /// <param name="name">Name of the book</param>
        /// <param name="Price">Price of the book</param>
        public void SetLabelBook(string name, string Price)//küçük booklar için
        {
            Database database = Database.CreateSingle();
            database.GetConnection();

            lblName.Text = name;
            lblPrice.Text = Price;

            string imagename = "";
            var dirs = Directory.GetFiles(@"Book Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            SqlCommand command = new SqlCommand("SELECT ImagePath FROM dbo.Books WHERE name = @name", Database.CreateSingle().Sqlconnection);
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
                    pictureBoxBook.Image = new Bitmap(item);
                }
            }
        }
        /// <summary>
        /// This function handles read more button click event.
        /// It triggers when read more button clicked.
        /// It  directs user to UserControl that contains informations of book and sets informations to the user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadMore_Click(object sender, EventArgs e)
        {
            
            UserControlBooks.CreateControlBooks().Visible = false;
            UserControlMusicCDs.CreateControlCDs().Visible = false;
            UserControlMagazines.CreateControlMagazines().Visible = false;
            UserControlShoppingCart.Instance().Visible = false;

            userControlProductDetails.SetBookInfo(book.ProductName, book.Author, book.Publisher,
            book.Page, book.BookISBN, book.ProductPrice, book.Cover, book.Type);
            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlProductDetails);

            userControlProductDetails.Visible = true;
        }
    }
}