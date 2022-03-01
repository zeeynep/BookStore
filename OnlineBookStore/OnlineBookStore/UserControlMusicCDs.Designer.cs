
namespace OnlineBookStore
{
    partial class UserControlMusicCDs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel_productDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_productDisplay
            // 
            this.flowLayoutPanel_productDisplay.AutoScroll = true;
            this.flowLayoutPanel_productDisplay.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_productDisplay.Name = "flowLayoutPanel_productDisplay";
            this.flowLayoutPanel_productDisplay.Size = new System.Drawing.Size(1108, 564);
            this.flowLayoutPanel_productDisplay.TabIndex = 0;
            // 
            // UserControlMusicCDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_productDisplay);
            this.Name = "UserControlMusicCDs";
            this.Size = new System.Drawing.Size(1114, 572);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_productDisplay;
    }
}
