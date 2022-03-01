
namespace OnlineBookStore
{
    partial class UserControlBooks
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
            this.flowLayoutPanelProductDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelProductDisplay
            // 
            this.flowLayoutPanelProductDisplay.AutoScroll = true;
            this.flowLayoutPanelProductDisplay.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanelProductDisplay.Name = "flowLayoutPanelProductDisplay";
            this.flowLayoutPanelProductDisplay.Size = new System.Drawing.Size(1109, 568);
            this.flowLayoutPanelProductDisplay.TabIndex = 0;
            // 
            // UserControlBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelProductDisplay);
            this.Name = "UserControlBooks";
            this.Size = new System.Drawing.Size(1115, 571);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductDisplay;
    }
}
