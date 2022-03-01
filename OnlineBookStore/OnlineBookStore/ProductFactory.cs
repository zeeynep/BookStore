/**
*  @author  : Sıla Eşme
*  @number  : 152120181004
*  @mail    : silaesme@gmail.com
*  @date    : 03.06.21
*  @brief   : It's the implementation of Factory Design Pattern..
*/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class ProductFactory
    {
        /// <summary>
        /// This function is creates different type of Products.
        /// </summary>
        /// <param name="ProductType"> Includes type of products as string</param>
        /// <returns>Type of Product</returns>
        public Product getProduct(String ProductType)
        {
            if (ProductType == null)
            {
                return null;
            }
            if (ProductType == "Book")
            {
                return new Book();
            }
            else if (ProductType == "MusicCD")
            {
                return new MusicCD();
            }
            else if (ProductType == "Magazine")
            {
                return new Magazine();
            }

            return null;
        }
        /// <summary>
        /// This function reads the information from the table according to the entered type and creates a product.
        /// </summary>
        /// <param name="ProductType"> Includes type of products as string</param>
        public void CreateProduct(String ProductType)
        {
            if (ProductType == "Book")
            {
                UserControlBooks userControlBooks = UserControlBooks.CreateControlBooks();
                SqlCommand command = new SqlCommand("SELECT Name,Author,Publisher,Page_Number,ISBN,Price,Cover,Type,ID FROM dbo.Books", Database.CreateSingle().Sqlconnection);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Book book = new Book();
                    UserControlBook userControlBook = new UserControlBook();
                    userControlBook.SetLabelBook(dr.GetString(0), dr.GetString(5));
                    userControlBooks.Panel.Controls.Add(userControlBook);

                    book.ProductName = dr.GetString(0);
                    book.Author = dr.GetString(1);
                    book.Publisher = dr.GetString(2);
                    book.Page = dr.GetString(3);
                    book.BookISBN = dr.GetString(4);
                    book.ProductPrice = dr.GetString(5);
                    book.Cover = dr.GetString(6);
                    book.Type = (_type)Enum.Parse(typeof(_type), dr.GetString(7));
                    userControlBook._Book = book;
                }
                Database.CreateSingle().Sqlconnection.Close();
            }
            else if (ProductType == "MusicCD")
            {
                UserControlMusicCDs userControlMusicCDs = UserControlMusicCDs.CreateControlCDs();
                SqlCommand command = new SqlCommand("SELECT * FROM Music_CDs", Database.CreateSingle().Sqlconnection);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    MusicCD musicCD = new MusicCD();

                    UserControlMusicCD userControlMusicCD = new UserControlMusicCD();
                    userControlMusicCD.SetLabelMusicCD(dr.GetString(0), dr.GetString(3));

                    userControlMusicCDs.panel.Controls.Add(userControlMusicCD);

                    musicCD.ProductName = dr.GetString(0);
                    musicCD.Singer = dr.GetString(1);
                    musicCD.ProductPrice = dr.GetString(3);
                    musicCD.Type = (typeCD)Enum.Parse(typeof(typeCD), dr.GetString(2));
                    userControlMusicCD._musicCD = musicCD;
                }
                Database.CreateSingle().Sqlconnection.Close();
            }
            else if (ProductType == "Magazine")
            {
                UserControlMagazines userControlMagazines = UserControlMagazines.CreateControlMagazines();
                SqlCommand command = new SqlCommand("SELECT * FROM Magazines", Database.CreateSingle().Sqlconnection);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Magazine magazine = new Magazine();
                    UserControlMagazine userControlMagazine = new UserControlMagazine();
                    userControlMagazine.SetLabelMagazine(dr.GetString(0), dr.GetString(3));
                    userControlMagazines.panel.Controls.Add(userControlMagazine);
                    magazine.ProductName = dr.GetString(0);
                    magazine.Issue = dr.GetString(1);
                    magazine.ProductPrice = dr.GetString(3);
                    magazine._TypeMagazine = (typeMagazine)Enum.Parse(typeof(typeMagazine), dr.GetString(2));
                    userControlMagazine._Magazine = magazine;
                }
                Database.CreateSingle().Sqlconnection.Close();
            }
        }
    }
}
