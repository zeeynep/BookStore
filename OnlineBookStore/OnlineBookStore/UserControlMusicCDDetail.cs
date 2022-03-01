/**
*  @author  : Zeynep Gürlüzer
*  @number  : 152120191050
*  @mail    : zeyneopgurluzer0@gmail.com
*  @date    : 02.06.21
*  @brief   : It's for the read details of the product.
*/
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMusicCDDetail : UserControl
    {
        private static UserControlMusicCDDetail userControlMusicCDDetail;

        public UserControlMusicCDDetail()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function is for implement Singleton Pattern.
        /// </summary>
        /// <returns>Non Null UserControlMusicCDDetail object</returns>
        public static UserControlMusicCDDetail CreateMusicCDDeatils()
        {
            if (userControlMusicCDDetail == null)
                userControlMusicCDDetail = new UserControlMusicCDDetail();
            return userControlMusicCDDetail;
        }
        /// <summary>
        /// This function sets products information
        /// </summary>
        /// <param name="name">This is the name of the MusicCD</param>
        /// <param name="Singer">This is the name of the Singer</param>
        /// <param name="Price">this is price of the cd</param>
        /// <param name="type">This is the type of the MusicCD</param>
        public void SetMusicCDInfo(string name, string Singer, string Price,
         typeCD type)
        {
            lblName.Text = name;
            lblSinger.Text = Singer;
            lblPrice.Text = Price;
            lblType.Text = type.ToString();

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
        /// <summary>
        /// This function adds product to cart.
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
                SqlCommand command = new SqlCommand("INSERT INTO dbo.ShoppingCart (Productname,price,amount,username,producttype) VALUES (@name,@price,@amount,@username, @producttype)", Database.CreateSingle().Sqlconnection);
                command.Parameters.AddWithValue("@name", lblName.Text);
                command.Parameters.AddWithValue("@price", lblPrice.Text);
                command.Parameters.AddWithValue("@amount", "1");
                command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
                command.Parameters.AddWithValue("@producttype", "MusicCD");

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