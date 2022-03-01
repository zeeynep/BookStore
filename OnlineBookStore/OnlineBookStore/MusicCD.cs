/**
*  @author  : Sanem Yıldız Kavukoğlu
*  @number  : 152120181043
*  @mail    : sanemkavukoğlu420@gmail.com
*  @date    : 01.06.21
*  @brief   : 
*/
namespace OnlineBookStore
{
    /// <summary>
    /// This is enum class.
    /// This Enum class for seperate CDs' types.
    /// </summary>
    public enum typeCD { Rock, Classical, Pop, Country, Jazz, Rap, Punk, Metal }
    /// <summary>
    /// This class is type of Product. It's for MusicCDs' informations.
    /// It includes MusicCD's informations and operations.
    /// </summary>
    public class MusicCD : Product
    {
        private string productName, productPrice;
        private static int ID;
        private string singer;

        private typeCD typecd;

        public typeCD Type
        {
            get => typecd;
            set => typecd = value;
        }
        /// <summary>
        /// This is constructor.
        /// </summary>
        public MusicCD()
        {
        }

        public override string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string Singer
        {
            get => singer;
            set => singer = value;
        }

        public int MusicCDID
        {
            get => ID;
            set => ID = value;
        }

        public override string ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }
    }
}