/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's for sign up.
*/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class FormSignUp : Form
    {
        /// <summary>
        /// This function is constructor.
        /// </summary>
        public FormSignUp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function handles Sign Up button click event.
        /// It triggers when sign up button clicked.
        /// It checks informations are correct and if is, write down them to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_signup_Click(object sender, EventArgs e)
        {
            SqlCommand Command;
            bool flag = false;
            HashCriptology hashCriptology = new HashCriptology();
            string sifre = txtPassword.Text;
            hashCriptology.MD5Cyrpt(ref sifre);
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand command2 = new SqlCommand("SELECT Username FROM CUSTOMER", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command2.ExecuteReader();

            if (txtPassword.Text != "" && txtUsername.Text != "" && txtAddress.Text != "" &&
                txtName.Text != "" && txteMail.Text != "" && txtSurname.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    string command = "INSERT INTO Customer(Name, Surname, Adress, EMail, Username, Password, ImagePath) VALUES(@Name, @Surname, @Adress, @EMail, @Username, @Password, @ImagePath)";
                    Command = new SqlCommand(command, Database.CreateSingle().Sqlconnection);
                    Command.Parameters.AddWithValue("@Name", txtName.Text);
                    Command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    Command.Parameters.AddWithValue("@Adress", txtAddress.Text);
                    Command.Parameters.AddWithValue("@EMail", txteMail.Text);
                    Command.Parameters.AddWithValue("@Password", sifre);
                    Command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    Command.Parameters.AddWithValue("@ImagePath", "default-picture.jpg");

                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtUsername.Text)
                        {
                            MessageBox.Show("Your username is already taken!", "Invalid");
                            flag = true;
                            break;
                        }
                    }
                    Database.CreateSingle().Sqlconnection.Close();
                    if (flag == false)
                    {
                        Database.CreateSingle().Sqlconnection.Open();
                        Command.ExecuteNonQuery();
                        Database.CreateSingle().Sqlconnection.Close();
                        FormLogin formLogin = new FormLogin();
                        formLogin.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Your password and confirm password doesn't match!", "Invalid");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the blanks!", "Invalid");
            }
        }
        /// <summary>
        /// This function handles picturebox click event.
        /// It triggers when picturebox clicked.
        /// It closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}