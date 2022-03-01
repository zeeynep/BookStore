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
    /// This Enum class for seperate Magazine' types.
    /// </summary>
    public enum typeMagazine { Culture, Technology, Science, Geography, Caricature, Kids, Society, Art, Entertainment, Other }
    /// <summary>
    /// This class is type of Product. It's for Magazines' informations.
    /// It includes magazine's informations and operations.
    /// </summary>
    public class Magazine : Product
    {
        private string productName, productPrice;
        private string issue;
        private typeMagazine TypeMagazine;

        public typeMagazine _TypeMagazine
        {
            get => TypeMagazine;
            set => TypeMagazine = value;
        }

        /// <summary>
        /// This is constructor.
        /// </summary>
        public Magazine()
        {
        }

        public override string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string Issue
        {
            get => issue;
            set => issue = value;
        }

        public override string ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }
    }
}