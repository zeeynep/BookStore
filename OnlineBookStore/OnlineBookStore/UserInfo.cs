/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's for keeping customer's Username and password
*/
namespace OnlineBookStore
{
    /// <summary>
    /// User Info Class is used for keeping customer's Username and password
    /// </summary>
    public class UserInfo
    {
        private string username;
        private string password;

        /// <summary>
        /// Constructor of Userınfo Class
        /// </summary>
        public UserInfo()
        {
        }

        /// <summary>
        /// Get,Set method for customer's username
        /// </summary>
        public string Username
        {
            get => username;
            set => username = value;
        }
        /// <summary>
        /// Get,Set method for customer's password
        /// </summary>
        public string Password
        {
            get => password;
            set => password = value;
        }
    }
}