/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : It's for database connection.
*/
/**
*  @author  : Zeynep Gürlüzer
*  @number  : 152120191050
*  @mail    : zeyneopgurluzer0@gmail.com
*  @date    : 02.06.21
*  @brief   : It's for database connection.
*/
using System.Data.SqlClient;

namespace OnlineBookStore
{
    public class Database
    {
        private static Database database;

        private string connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=db_a75067_sanemyildiz;User Id=db_a75067_sanemyildiz_admin;Password=sanem4196";
        private SqlConnection sqlConnection;

        public string ConnectionString
        {
            get => connectionString;
        }
        /// <summary>
        /// This function creates connection with connection string.
        /// </summary>
        public void GetConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public SqlConnection Sqlconnection
        {
            get => sqlConnection;
        }
        /// <summary>
        /// This function is for implement Singleton Pattern.
        /// </summary>
        /// <returns>Non Null Database object</returns>
        public static Database CreateSingle()
        {
            if (database == null)
            {
                database = new Database();
            }
            return database;
        }
    }
}