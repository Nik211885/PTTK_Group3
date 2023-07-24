namespace Group3.Profile.UControlEdit
{
    partial class Infor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infor));
            this.FrName = new System.Windows.Forms.Label();
            this.FrInfromation = new System.Windows.Forms.Label();
            this.FrImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.FrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // FrName
            // 
            this.FrName.AutoSize = true;
            this.FrName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrName.Location = new System.Drawing.Point(23, 27);
            this.FrName.Name = "FrName";
            this.FrName.Size = new System.Drawing.Size(85, 19);
            this.FrName.TabIndex = 0;
            this.FrName.Text = "Ảnh hồ sơ";
            this.FrName.Click += new System.EventHandler(this.FrName_Click);
            // 
            // FrInfromation
            // 
            this.FrInfromation.AutoSize = true;
            this.FrInfromation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrInfromation.Location = new System.Drawing.Point(249, 28);
            this.FrInfromation.Name = "FrInfromation";
            this.FrInfromation.Size = new System.Drawing.Size(336, 17);
            this.FrInfromation.TabIndex = 1;
            this.FrInfromation.Text = "Ảnh hồ sơ giúp bạn cá nhân hóa tài khoản của bạn";
            this.FrInfromation.Click += new System.EventHandler(this.FrName_Click);
            // 
            // FrImage
            // 
            this.FrImage.Image = ((System.Drawing.Image)(resources.GetObject("FrImage.Image")));
            this.FrImage.ImageRotate = 0F;
            this.FrImage.Location = new System.Drawing.Point(756, 2);
            this.FrImage.Name = "FrImage";
            this.FrImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.FrImage.Size = new System.Drawing.Size(70, 64);
            this.FrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FrImage.TabIndex = 2;
            this.FrImage.TabStop = false;
            this.FrImage.Click += new System.EventHandler(this.FrName_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(23, 64);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(803, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // Infor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.FrImage);
            this.Controls.Add(this.FrInfromation);
            this.Controls.Add(this.FrName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Infor";
            this.Size = new System.Drawing.Size(864, 75);
            this.Click += new System.EventHandler(this.FrName_Click);
            ((System.ComponentModel.ISupportInitialize)(this.FrImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FrName;
        private System.Windows.Forms.Label FrInfromation;
        private Guna.UI2.WinForms.Guna2CirclePictureBox FrImage;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
