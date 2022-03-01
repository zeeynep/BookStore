/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's for books' informations.
*/
namespace OnlineBookStore
{
    /// <summary>
    /// This is enum class.
    /// This Enum class for seperate books' types.
    /// </summary>
    public enum _type { Fiction, Classic, Story, TurkishClassic, Education,}

    /// <summary>
    /// This class is type of Product. It's for books' informations.
    /// It includes magazine's informations and operations.
    /// </summary>
    public class Book : Product
    {
        private string productName, productPrice;
        private string ISBN, author, publisher;
        private string page, cover;
        private static int ID = 1;

        private _type type;

        public Book()
        {
            ID++;
        }

        public override string ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }

        public string Page
        {
            get => page;
            set => page = value;
        }

        public int BookID
        {
            get => ID;
            set => ID = value;
        }

        public override string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string BookISBN
        {
            get => ISBN;
            set => ISBN = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Publisher
        {
            get => publisher;
            set => publisher = value;
        }

        public string Cover
        {
            get => cover;
            set => cover = value;
        }

        public _type Type
        {
            get => type;
            set => type = value;
        }
    }
}