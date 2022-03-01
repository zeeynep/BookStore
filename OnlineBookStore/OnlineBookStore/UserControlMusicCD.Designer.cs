
namespace OnlineBookStore
{
    partial class UserControlMusicCD
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
            this.btnReadMore = new System.Windows.Forms.Button();
            this.pictureBoxMusicCD = new System.Windows.Forms.PictureBox();
            this.lblTL = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicCD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadMore
            // 
            this.btnReadMore.BackColor = System.Drawing.Color.RosyBrown;
            this.btnReadMore.FlatAppearance.BorderSize = 0;
            this.btnReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMore.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadMore.ForeColor = System.Drawing.Color.White;
            this.btnReadMore.Location = new System.Drawing.Point(34, 230);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(164, 46);
            this.btnReadMore.TabIndex = 21;
            this.btnReadMore.Text = "Read More";
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // pictureBoxMusicCD
            // 
            this.pictureBoxMusicCD.Location = new System.Drawing.Point(34, 16);
            this.pictureBoxMusicCD.Name = "pictureBoxMusicCD";
            this.pictureBoxMusicCD.Size = new System.Drawing.Size(164, 121);
            this.pictureBoxMusicCD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMusicCD.TabIndex = 19;
            this.pictureBoxMusicCD.TabStop = false;
            // 
            // lblTL
            // 
            this.lblTL.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.Location = new System.Drawing.Point(131, 187);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(32, 33);
            this.lblTL.TabIndex = 26;
            this.lblTL.Text = "₺";
            this.lblTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(76, 187);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 33);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "999,99";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(230, 38);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlMusicCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnReadMore);
            this.Controls.Add(this.pictureBoxMusicCD);
            this.Name = "UserControlMusicCD";
            this.Size = new System.Drawing.Size(230, 292);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadMore;
        private System.Windows.Forms.PictureBox pictureBoxMusicCD;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
    }
}
