
namespace OnlineBookStore
{
    partial class UserControlShoppingCartItem
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
            this.pictureBox_product = new System.Windows.Forms.PictureBox();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrase = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceH = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceH = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_product
            // 
            this.pictureBox_product.Location = new System.Drawing.Point(33, 27);
            this.pictureBox_product.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_product.Name = "pictureBox_product";
            this.pictureBox_product.Size = new System.Drawing.Size(120, 103);
            this.pictureBox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_product.TabIndex = 0;
            this.pictureBox_product.TabStop = false;
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.SeaGreen;
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrease.Image = global::OnlineBookStore.Properties.Resources.icons8_add_basket_32;
            this.btnIncrease.Location = new System.Drawing.Point(213, 19);
            this.btnIncrease.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(45, 38);
            this.btnIncrease.TabIndex = 1;
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrase
            // 
            this.btnDecrase.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDecrase.FlatAppearance.BorderSize = 0;
            this.btnDecrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrase.Image = global::OnlineBookStore.Properties.Resources.icons8_shopping_basket_remove_32;
            this.btnDecrase.Location = new System.Drawing.Point(213, 103);
            this.btnDecrase.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrase.Name = "btnDecrase";
            this.btnDecrase.Size = new System.Drawing.Size(45, 38);
            this.btnDecrase.TabIndex = 2;
            this.btnDecrase.UseVisualStyleBackColor = false;
            this.btnDecrase.Click += new System.EventHandler(this.btnDecrase_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::OnlineBookStore.Properties.Resources.icons8_cancel_32;
            this.btnDelete.Location = new System.Drawing.Point(844, 58);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "₺";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTL
            // 
            this.lblTL.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.Location = new System.Drawing.Point(500, 72);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(32, 20);
            this.lblTL.TabIndex = 72;
            this.lblTL.Text = "₺";
            this.lblTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(212, 60);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(47, 40);
            this.lblTotalAmount.TabIndex = 71;
            this.lblTotalAmount.Text = "5";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(455, 109);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(52, 32);
            this.lblTotalPrice.TabIndex = 70;
            this.lblTotalPrice.Text = "500";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPriceH
            // 
            this.lblTotalPriceH.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceH.Location = new System.Drawing.Point(354, 109);
            this.lblTotalPriceH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPriceH.Name = "lblTotalPriceH";
            this.lblTotalPriceH.Size = new System.Drawing.Size(93, 32);
            this.lblTotalPriceH.TabIndex = 69;
            this.lblTotalPriceH.Text = "Total Price:";
            this.lblTotalPriceH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(455, 66);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 32);
            this.lblPrice.TabIndex = 68;
            this.lblPrice.Text = "100";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriceH
            // 
            this.lblPriceH.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceH.Location = new System.Drawing.Point(382, 66);
            this.lblPriceH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceH.Name = "lblPriceH";
            this.lblPriceH.Size = new System.Drawing.Size(65, 32);
            this.lblPriceH.TabIndex = 67;
            this.lblPriceH.Text = "Price:";
            this.lblPriceH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(455, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(325, 32);
            this.lblName.TabIndex = 66;
            this.lblName.Text = "Validenin Günlüğü";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameH
            // 
            this.lblNameH.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameH.Location = new System.Drawing.Point(378, 25);
            this.lblNameH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameH.Name = "lblNameH";
            this.lblNameH.Size = new System.Drawing.Size(69, 32);
            this.lblNameH.TabIndex = 65;
            this.lblNameH.Text = "Name:";
            this.lblNameH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserControlShoppingCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalPriceH);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceH);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameH);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDecrase);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.pictureBox_product);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlShoppingCartItem";
            this.Size = new System.Drawing.Size(908, 152);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_product;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrase;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceH;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceH;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameH;
    }
}
