
namespace OnlineBookStore
{
    partial class UserControlChangeInformations
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
            this.btnUpdateImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblInfoUpdate = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblAddressH = new System.Windows.Forms.Label();
            this.lblEMailH = new System.Windows.Forms.Label();
            this.lblSurnameH = new System.Windows.Forms.Label();
            this.lblNameH = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateImage.FlatAppearance.BorderSize = 0;
            this.btnUpdateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateImage.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateImage.Image = global::OnlineBookStore.Properties.Resources.icons8_update_user_40;
            this.btnUpdateImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateImage.Location = new System.Drawing.Point(69, 425);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(172, 54);
            this.btnUpdateImage.TabIndex = 25;
            this.btnUpdateImage.Text = "Update Image";
            this.btnUpdateImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateImage.UseVisualStyleBackColor = false;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::OnlineBookStore.Properties.Resources.icons8_save_40;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(247, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 54);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblInfoUpdate
            // 
            this.lblInfoUpdate.AutoSize = true;
            this.lblInfoUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblInfoUpdate.Location = new System.Drawing.Point(713, 504);
            this.lblInfoUpdate.Name = "lblInfoUpdate";
            this.lblInfoUpdate.Size = new System.Drawing.Size(0, 17);
            this.lblInfoUpdate.TabIndex = 33;
            this.lblInfoUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.Gainsboro;
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddress.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(597, 272);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(233, 90);
            this.txtaddress.TabIndex = 41;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(597, 217);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(233, 39);
            this.txtemail.TabIndex = 40;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsurname
            // 
            this.txtsurname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtsurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsurname.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsurname.Location = new System.Drawing.Point(597, 162);
            this.txtsurname.Multiline = true;
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(233, 39);
            this.txtsurname.TabIndex = 39;
            this.txtsurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(597, 107);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(233, 39);
            this.txtname.TabIndex = 38;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddressH
            // 
            this.lblAddressH.AutoSize = true;
            this.lblAddressH.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressH.Location = new System.Drawing.Point(508, 309);
            this.lblAddressH.Name = "lblAddressH";
            this.lblAddressH.Size = new System.Drawing.Size(67, 19);
            this.lblAddressH.TabIndex = 37;
            this.lblAddressH.Text = "Address:";
            // 
            // lblEMailH
            // 
            this.lblEMailH.AutoSize = true;
            this.lblEMailH.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMailH.Location = new System.Drawing.Point(518, 237);
            this.lblEMailH.Name = "lblEMailH";
            this.lblEMailH.Size = new System.Drawing.Size(57, 19);
            this.lblEMailH.TabIndex = 36;
            this.lblEMailH.Text = "E-Mail:";
            // 
            // lblSurnameH
            // 
            this.lblSurnameH.AutoSize = true;
            this.lblSurnameH.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameH.Location = new System.Drawing.Point(501, 182);
            this.lblSurnameH.Name = "lblSurnameH";
            this.lblSurnameH.Size = new System.Drawing.Size(74, 19);
            this.lblSurnameH.TabIndex = 35;
            this.lblSurnameH.Text = "Surname:";
            // 
            // lblNameH
            // 
            this.lblNameH.AutoSize = true;
            this.lblNameH.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameH.Location = new System.Drawing.Point(522, 127);
            this.lblNameH.Name = "lblNameH";
            this.lblNameH.Size = new System.Drawing.Size(53, 19);
            this.lblNameH.TabIndex = 34;
            this.lblNameH.Text = "Name:";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Image = global::OnlineBookStore.Properties.Resources.icons8_update_user_40;
            this.btnUpdateInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateInfo.Location = new System.Drawing.Point(597, 378);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(233, 54);
            this.btnUpdateInfo.TabIndex = 19;
            this.btnUpdateInfo.Text = "Update My Informations";
            this.btnUpdateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Location = new System.Drawing.Point(69, 107);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(267, 284);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCustomer.TabIndex = 13;
            this.pictureBoxCustomer.TabStop = false;
            // 
            // UserControlChangeInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblAddressH);
            this.Controls.Add(this.lblEMailH);
            this.Controls.Add(this.lblSurnameH);
            this.Controls.Add(this.lblNameH);
            this.Controls.Add(this.lblInfoUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateImage);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.pictureBoxCustomer);
            this.Name = "UserControlChangeInformations";
            this.Size = new System.Drawing.Size(893, 580);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.Button btnUpdateImage;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblInfoUpdate;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblAddressH;
        private System.Windows.Forms.Label lblEMailH;
        private System.Windows.Forms.Label lblSurnameH;
        private System.Windows.Forms.Label lblNameH;
    }
}
