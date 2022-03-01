/**
*  @author  : Sıla Eşme
*  @number  : 152120181004
*  @mail    : silaesme@gmail.com
*  @date    : 03.06.21
*  @brief   : It's the user control that contains little UserControlMusicCD.
*/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMusicCDs : UserControl
    {
        public FlowLayoutPanel panel
        {
            get => flowLayoutPanel_productDisplay;
        }
        private static UserControlMusicCDs controlMusicCDs;
        /// <summary>
        /// This function is for implement Singleton Pattern.
        /// </summary>
        /// <returns>Non Null UserControlMusicCDs object</returns>
        public static UserControlMusicCDs CreateControlCDs()
        {
            if (controlMusicCDs == null)
            {
                controlMusicCDs = new UserControlMusicCDs();
            }
            return controlMusicCDs;
        }
        /// <summary>
        /// This is constructor.
        /// </summary>
        protected UserControlMusicCDs()
        {
            controlMusicCDs = this;
            InitializeComponent();
        }
        /// <summary>
        /// This function clears panel that owns.
        /// </summary>
        public void DeleteMusicCD()
        {
            flowLayoutPanel_productDisplay.Controls.Clear();
        }
    }
}