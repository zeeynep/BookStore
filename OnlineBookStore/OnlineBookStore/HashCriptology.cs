/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's util for cyript the password.
*/
using System.Security.Cryptography;
using System.Text;

namespace OnlineBookStore
{
    public class HashCriptology
    {
        public StringBuilder sb = new StringBuilder();

        /// <summary>
        /// This function cyrpts given string.
        /// </summary>
        /// <param name="password"></param>
        public void MD5Cyrpt(ref string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] dizi = Encoding.UTF8.GetBytes(password);

            dizi = md5.ComputeHash(dizi);

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            password = sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Cyrpted string</returns>
        public string getPass()
        {
            return sb.ToString();
        }
    }
}