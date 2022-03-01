/**
*  @author  : Sıla Eşme
*  @number  : 152120181004
*  @mail    : silaesme@gmail.com
*  @date    : 03.06.21
*  @brief   : It's the user control that contains little UserControlMagazine.
*/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMagazines : UserControl
    {
        public FlowLayoutPanel panel
        {
            get => flowLayoutPanelProductDisplay;
        }
        private static UserControlMagazines controlMagazines;
        /// <summary>
        /// This function is for implement Singleton Pattern.
        /// </summary>
        /// <returns>Non Null UserControlMagazines object</returns>
        public static UserControlMagazines CreateControlMagazines()
        {
            if (controlMagazines == null)
            {
                controlMagazines = new UserControlMagazines();
            }
            return controlMagazines;
        }
        /// <summary>
        /// This is constructor.
        /// </summary>
        protected UserControlMagazines()
        {
            controlMagazines = this;
            InitializeComponent();
        }
        /// <summary>
        /// This function clears panel that owns.
        /// </summary>
        public void DeleteMagazine()
        {
            flowLayoutPanelProductDisplay.Controls.Clear();
        }
    }
}