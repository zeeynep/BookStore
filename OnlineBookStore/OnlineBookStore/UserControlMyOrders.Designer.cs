
namespace OnlineBookStore
{
    partial class UserControlMyOrders
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
            this.flowLayoutPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelOrderDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelOrders
            // 
            this.flowLayoutPanelOrders.AutoScroll = true;
            this.flowLayoutPanelOrders.Location = new System.Drawing.Point(13, 19);
            this.flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            this.flowLayoutPanelOrders.Size = new System.Drawing.Size(519, 524);
            this.flowLayoutPanelOrders.TabIndex = 0;
            // 
            // flowLayoutPanelOrderDetails
            // 
            this.flowLayoutPanelOrderDetails.AutoScroll = true;
            this.flowLayoutPanelOrderDetails.Location = new System.Drawing.Point(538, 19);
            this.flowLayoutPanelOrderDetails.Name = "flowLayoutPanelOrderDetails";
            this.flowLayoutPanelOrderDetails.Size = new System.Drawing.Size(559, 524);
            this.flowLayoutPanelOrderDetails.TabIndex = 1;
            // 
            // UserControlMyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelOrderDetails);
            this.Controls.Add(this.flowLayoutPanelOrders);
            this.Name = "UserControlMyOrders";
            this.Size = new System.Drawing.Size(1109, 568);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrders;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrderDetails;
    }
}
