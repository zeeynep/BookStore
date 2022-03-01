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
*  @date    : 02.06.21
*  @brief   : It's for setting properties and buttons of shopping cart item.
*/
namespace OnlineBookStore
{
    /// <summary>
    /// UserControlShoppingCartItem is used for setting properties and buttons of shopping cart item.
    /// </summary>
    public partial class UserControlShoppingCartItem : UserControl
    {
        private UserControlShoppingCart userControlShoppingCart = UserControlShoppingCart.Instance();

        /// <summary>
        /// Constructor of UserControlShoppingCartItem class.
        /// </summary>
        public UserControlShoppingCartItem()
        {
            InitializeComponent();
        }
        /// <summary>
        /// SetLabel function sets the labels of the shopping item , gets the path of the image of item from database and selects from project image folder by product type.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="amount"></param>
        public void SetLabel(string name, string price, string amount)
        {
            lblName.Text = name;
            lblPrice.Text = price;
            lblTotalAmount.Text = amount;

            lblTotalPrice.Text= (Double.Parse(price.Replace('.',',')) * Int32.Parse(amount)).ToString();

            string producttype = "";
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand command = new SqlCommand("SELECT ProductType FROM dbo.ShoppingCart WHERE ProductName = @Productname", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@ProductName", lblName.Text);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                producttype = dr.GetString(0);
            }
            Database.CreateSingle().Sqlconnection.Close();

            if (producttype == "Book")
            {
                string imagename = "";
                var dirs = Directory.GetFiles(@"Book Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
                SqlCommand command2 = new SqlCommand("SELECT ImagePath FROM dbo.Books WHERE name = @name", Database.CreateSingle().Sqlconnection);
                command2.Parameters.AddWithValue("@name", lblName.Text);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr2 = command2.ExecuteReader();

                while (dr2.Read())
                {
                    imagename = dr2.GetString(0);
                }
                Database.CreateSingle().Sqlconnection.Close();

                foreach (var item in dirs)
                {
                    if (Path.GetFileName(item) == imagename)
                    {
                        pictureBox_product.Image = new Bitmap(item);
                    }
                }
            }
            else if (producttype == "Magazine")
            {
                string imagename = "";
                var dirs = Directory.GetFiles(@"Magazine Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
                SqlCommand command3 = new SqlCommand("SELECT ImagePath FROM dbo.Magazines WHERE name = @name", Database.CreateSingle().Sqlconnection);
                command3.Parameters.AddWithValue("@name", lblName.Text);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr3 = command3.ExecuteReader();

                while (dr3.Read())
                {
                    imagename = dr3.GetString(0);
                }
                Database.CreateSingle().Sqlconnection.Close();

                foreach (var item in dirs)
                {
                    if (Path.GetFileName(item) == imagename)
                    {
                        pictureBox_product.Image = new Bitmap(item);
                    }
                }
            }
            else if (producttype == "MusicCD")
            {
                string imagename = "";
                var dirs = Directory.GetFiles(@"MusicCD Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
                SqlCommand command4 = new SqlCommand("SELECT ImagePath FROM dbo.Music_CDs WHERE name = @name", Database.CreateSingle().Sqlconnection);
                command4.Parameters.AddWithValue("@name", lblName.Text);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr4 = command4.ExecuteReader();

                while (dr4.Read())
                {
                    imagename = dr4.GetString(0);
                }
                Database.CreateSingle().Sqlconnection.Close();

                foreach (var item in dirs)
                {
                    if (Path.GetFileName(item) == imagename)
                    {
                        pictureBox_product.Image = new Bitmap(item);
                    }
                }
            }
        }
        /// <summary>
        /// btnIncrease_Click function is used for increasing the number of the item on shopping cart and database. Function also sets the labels again depends on new amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update dbo.shoppingcart set Amount=@amount WHERE Productname = @name and username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", lblName.Text);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            int amount = Int32.Parse(lblTotalAmount.Text) + 1;
            lblTotalAmount.Text = amount.ToString();
            command.Parameters.AddWithValue("@amount", amount.ToString());

            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();

            int TempAmount = 0;
            double TempPrice = 0;
            TempAmount = Convert.ToInt32(userControlShoppingCart.GetLabelAmount());
            TempAmount++;
            userControlShoppingCart.SetLabelAmount(TempAmount.ToString());

            TempPrice = Double.Parse(userControlShoppingCart.GetLabelPrice());
            TempPrice += Double.Parse(this.lblPrice.Text.Replace('.', ','));
            userControlShoppingCart.SetLabelPrice(TempPrice.ToString());

            lblTotalPrice.Text = (Double.Parse(lblTotalAmount.Text) * Double.Parse(lblPrice.Text.Replace('.', ','))).ToString();

        }
        /// <summary>
        /// btnDelete_Click function is used for deleting the item on shopping cart and database. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int TempAmount = 0;
            double TempPrice = 0;
            TempAmount = Convert.ToInt32(userControlShoppingCart.GetLabelAmount());
            TempAmount -= Int32.Parse(this.lblTotalAmount.Text);
            userControlShoppingCart.SetLabelAmount(TempAmount.ToString());

            TempPrice = Double.Parse(userControlShoppingCart.GetLabelPrice());
            TempPrice -= Double.Parse(this.lblPrice.Text.Replace('.', ',')) * Int32.Parse(lblTotalAmount.Text);
            userControlShoppingCart.SetLabelPrice(TempPrice.ToString());

            this.Visible = false;
            userControlShoppingCart.flowLayoutPanelProducts.Controls.Remove(this);

            SqlCommand command = new SqlCommand("delete from dbo.shoppingcart WHERE Productname = @name and username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", lblName.Text);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }
        /// <summary>
        /// btnDelete_Click function is used for decreasing the number of the item on shopping cart and database. Function also sets the labels again depends on new amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecrase_Click(object sender, EventArgs e)
        {
            if (lblTotalAmount.Text == "1")
            {
                btnDelete_Click(sender, e);
            }
            else
            {
                SqlCommand command = new SqlCommand("update dbo.shoppingcart set Amount=@amount WHERE Productname = @name and username=@username", Database.CreateSingle().Sqlconnection);
                command.Parameters.AddWithValue("@name", lblName.Text);
                command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);

                int TempAmount = 0;
                double TempPrice = 0;
                int amount = Int32.Parse(lblTotalAmount.Text) - 1;
                lblTotalAmount.Text = amount.ToString();
                TempAmount = Convert.ToInt32(userControlShoppingCart.GetLabelAmount());
                TempAmount--;
                userControlShoppingCart.SetLabelAmount(TempAmount.ToString());

                TempPrice = Double.Parse(userControlShoppingCart.GetLabelPrice());
                TempPrice -= Double.Parse(this.lblPrice.Text.Replace('.', ','));
                userControlShoppingCart.SetLabelPrice(TempPrice.ToString());
                command.Parameters.AddWithValue("@amount", amount.ToString());

                lblTotalPrice.Text = (Double.Parse(lblTotalAmount.Text) * Double.Parse(lblPrice.Text.Replace('.', ','))).ToString();


                Database.CreateSingle().Sqlconnection.Open();
                command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
            }
        }

        
    }
}