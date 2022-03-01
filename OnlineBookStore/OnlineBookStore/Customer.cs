/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's for customers' informations.
*/
namespace OnlineBookStore
{

    public class Customer
    {
        private static Customer customer;

        private static int customerID;
        private string name;
        private string adress;
        private string email;
        private string surname;

        private UserInfo UserInfo = new UserInfo();

        /// <summary>
        /// This function is for implement Singleton Pattern.
        /// </summary>
        /// <returns>Non Null Customer object</returns>
        public static Customer CreateCustomer()
        {
            if (customer == null)
                customer = new Customer();
            return customer;
        }

        /// <summary>
        /// This function is Constructor.
        /// </summary>
        protected Customer()
        {
        }

        public UserInfo userInfo
        {
            get => UserInfo;
            set => UserInfo = value;
        }

        public int CustomerId
        {
            get => customerID;
            set => customerID = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public string Adress
        {
            get => adress;
            set => adress = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}