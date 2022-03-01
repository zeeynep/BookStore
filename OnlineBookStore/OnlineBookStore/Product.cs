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
    /// This class is abstract. It includes name and price of product.
    /// </summary>
    public abstract class Product
    {
        private string productName;
        private string productPrice;

        /// <summary>
        /// This is constructor.
        /// </summary>
        public Product()
        {
        }

        public virtual string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public virtual string ProductPrice
        {
            get => productPrice;
            set => productName = value;
        }
    }
}