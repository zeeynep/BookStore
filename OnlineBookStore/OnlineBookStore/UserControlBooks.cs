/**
*  @author  : Sıla Eşme
*  @number  : 152120181004
*  @mail    : silaesme@gmail.com
*  @date    : 03.06.21
*  @brief   : It's the user control that contains little UserControlBook.
*/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlBooks : UserControl
    {
        public FlowLayoutPanel Panel
        {
            get => flowLayoutPanelProductDisplay;
        }
        private static UserControlBooks controlBooks;
        /// <summary>
        /// This function is for implement Singleton Pattern.
        /// </summary>
        /// <returns>Non Null UserControlBooks object</returns>
        public static UserControlBooks CreateControlBooks()
        {
            if (controlBooks == null)
            {
                controlBooks = new UserControlBooks();
            }
            return controlBooks;
        }
        /// <summary>
        /// This is constructor.
        /// </summary>
        protected UserControlBooks()
        {
            controlBooks = this;
            InitializeComponent();
        }
        /// <summary>
        /// This function clears panel that owns.
        /// </summary>
        public void DeleteBook()
        {
            flowLayoutPanelProductDisplay.Controls.Clear();
        }
    }
}