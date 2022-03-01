using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
/**
*  @author  : Zeynep Gürlüzer
*  @number  : 152120191050
*  @mail    : zeyneopgurluzer0@gmail.com
*  @date    : 03.06.21
*  @brief   : It's for displaying details and images of the books. It also allows customers to add product into their shopping carts.
*/
namespace OnlineBookStore
{
    /// <summary>
    /// UserControlProductDetails class is used for displaying details and images of the books. It also allows customers to add product into their shopping carts.
    /// </summary>
    public partial class UserControlProductDetails : UserControl
    {
        private static UserControlProductDetails userControlProductDetails;

        /// <summary>
        /// CreateProductDetails function is a singleton design pattern.Only creates new object if its not created before.
        /// </summary>
        /// <returns>returns existing userControlProductDetails</returns>
        public static UserControlProductDetails CreateProductDetails()
        {
            if (userControlProductDetails == null)
                userControlProductDetails = new UserControlProductDetails();
            return userControlProductDetails;
        }
        /// <summary>
        /// Constructor of userControlProductDetails Class.
        /// </summary>
        public UserControlProductDetails()
        {
            InitializeComponent();
        }
        /// <summary>
        /// SetBookInfo function sets the informations of the book according the parameters and adds an image by reading the path from database.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="publisher"></param>
        /// <param name="page"></param>
        /// <param name="ISBN"></param>
        /// <param name="price"></param>
        /// <param name="cover"></param>
        /// <param name="type"></param>
        public void SetBookInfo(string name, string author, string publisher,
        string page, string ISBN, string price, string cover, _type type)
        {
            lblName.Text = name;
            lblAuthor.Text = author;
            lblPublisher.Text = publisher;
            lblPage.Text = page;
            lblISBN.Text = ISBN;
            lblPrice.Text = price;
            lblCover.Text = cover;
            lblType.Text = type.ToString();

            Database database = Database.CreateSingle();
            database.GetConnection();

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
        /// btn_AddtoCart_Click function adds the selected item to shopping cart and database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddtoCart_Click(object sender, System.EventArgs e)
        {
            Database.CreateSingle().Sqlconnection.Open();

            int SqlAmount = 0;
            bool read;
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand amount = new SqlCommand("SELECT Amount from ShoppingCart where ProductName='" + lblName.Text + "' and Username='" + Customer.CreateCustomer().userInfo.Username + "'", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = amount.ExecuteReader();
            read = dr.Read();
            Database.CreateSingle().Sqlconnection.Close();

            if (read == false)//data yoktur yeni eklenecek
            {
                SqlCommand command = new SqlCommand("INSERT INTO dbo.ShoppingCart (Productname,price,amount,username,producttype) VALUES (@name,@price,@amount,@username,@producttype)", Database.CreateSingle().Sqlconnection);
                command.Parameters.AddWithValue("@name", lblName.Text);
                command.Parameters.AddWithValue("@price", lblPrice.Text);
                command.Parameters.AddWithValue("@amount", "1");
                command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
                command.Parameters.AddWithValue("@producttype", "Book");
                Database.CreateSingle().Sqlconnection.Open();
                command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
            }
            else if (read == true)//data vardır amount arttırılcak
            {
                SqlCommand amount2 = new SqlCommand("SELECT Amount from ShoppingCart where ProductName='" + lblName.Text + "' and Username='" + Customer.CreateCustomer().userInfo.Username + "'", Database.CreateSingle().Sqlconnection);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr2 = amount2.ExecuteReader();

                while (dr2.Read())
                {
                    SqlAmount = Int32.Parse(dr2.GetString(0));
                }

                Database.CreateSingle().Sqlconnection.Close();
                SqlAmount++;
                string command2 = "UPDATE ShoppingCart SET Amount=@Amount where ProductName='" + lblName.Text + "' and Username='" + Customer.CreateCustomer().userInfo.Username + "'";
                SqlCommand Command2 = new SqlCommand(command2, Database.CreateSingle().Sqlconnection);
                Command2.Parameters.AddWithValue("@Amount", SqlAmount.ToString());
                Database.CreateSingle().Sqlconnection.Open();
                Command2.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
            }
            labelAddInfo.Text = "Product is added to cart successfully";
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, d) =>
            {
                labelAddInfo.Text = "";
                t.Stop();
            };
            t.Start();
        }
    }
}