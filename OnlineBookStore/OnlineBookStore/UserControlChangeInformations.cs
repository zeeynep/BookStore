/**
*  @author  : Zeynep Gürlüzer
*  @number  : 152120191050
*  @mail    : zeyneopgurluzer0@gmail.com
*  @date    : 02.06.21
*  @brief   : It's for the customers change informations of themselves.
*/
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlChangeInformations : UserControl
    {
        private Customer customer = Customer.CreateCustomer();
        private Byte[] _bytesOfImage;
        UserControlMyPage userControlMyPage;
        public UserControlChangeInformations()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function brings customers information to the textbox and picturebox.
        /// </summary>
        public void SetTextBoxInfo()
        {
            txtaddress.Text = customer.Adress;
            txtemail.Text = customer.Email;
            txtname.Text = customer.Name;
            txtsurname.Text = customer.Surname;
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
        /// This function updates customer's profile picture.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateImage_Click(object sender, System.EventArgs e)
        {

            DialogResult dgResult = openFileDialog1.ShowDialog();
            pictureBoxCustomer.ImageLocation = openFileDialog1.FileName;
            if (dgResult == DialogResult.OK)
            {
                string filename = Path.GetFileName(openFileDialog1.FileName);
                string destinationPath = Path.Combine(Environment.CurrentDirectory, @"Profile Images", filename);

                if (openFileDialog1.FileName != destinationPath)
                    System.IO.File.Copy(openFileDialog1.FileName, destinationPath);
            }
        }
        /// <summary>
        /// This function saves customer's changed profile picture.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string filename = Path.GetFileName(openFileDialog1.FileName);
            Database.CreateSingle().Sqlconnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Customer SET ImagePath=@filename where username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@filename", filename);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);

            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
            MessageBox.Show("The profile image is added.");
        }
        /// <summary>
        /// This function saves customer's informations that changed to the relevant database table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE Customer SET Name=@name, Surname=@surname,Adress=@adress,Email=@Email where username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", txtname.Text);
            command.Parameters.AddWithValue("@surname", txtsurname.Text);
            command.Parameters.AddWithValue("@adress", txtaddress.Text);
            command.Parameters.AddWithValue("@Email", txtemail.Text);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();

            customer.Name= txtname.Text;
            customer.Surname= txtsurname.Text;
            customer.Email= txtemail.Text;
            customer.Adress= txtaddress.Text;

            lblInfoUpdate.Text = "Your Informations is Updated Succesfully!";
        }
    }
}