namespace Group3.ShoopingCart
{
    partial class ControlCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCart));
            this.Img = new Guna.UI2.WinForms.Guna2PictureBox();
            this.nameProduct = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.numRicQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.share = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRicQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Img
            // 
            this.Img.Image = ((System.Drawing.Image)(resources.GetObject("Img.Image")));
            this.Img.ImageRotate = 0F;
            this.Img.Location = new System.Drawing.Point(0, 0);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(200, 188);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img.TabIndex = 0;
            this.Img.TabStop = false;
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProduct.Location = new System.Drawing.Point(16, 13);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(68, 28);
            this.nameProduct.TabIndex = 1;
            this.nameProduct.Text = "label1";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(952, 13);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(71, 28);
            this.Price.TabIndex = 2;
            this.Price.Text = "label1";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(16, 10);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(68, 16);
            this.status.TabIndex = 3;
            this.status.Text = "Đang xử lý";
            // 
            // numRicQuantity
            // 
            this.numRicQuantity.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.numRicQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numRicQuantity.BorderRadius = 7;
            this.numRicQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numRicQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numRicQuantity.Location = new System.Drawing.Point(19, 37);
            this.numRicQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numRicQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRicQuantity.Name = "numRicQuantity";
            this.numRicQuantity.Size = new System.Drawing.Size(148, 37);
            this.numRicQuantity.TabIndex = 4;
            this.numRicQuantity.UpDownButtonFillColor = System.Drawing.Color.RosyBrown;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.share);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.numRicQuantity);
            this.panel1.Controls.Add(this.status);
            this.panel1.Location = new System.Drawing.Point(212, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 78);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(190, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 30);
            this.panel2.TabIndex = 5;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.SteelBlue;
            this.delete.Location = new System.Drawing.Point(219, 46);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(56, 18);
            this.delete.TabIndex = 6;
            this.delete.Text = "Xóa bỏ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(296, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 6;
            // 
            // share
            // 
            this.share.AutoSize = true;
            this.share.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.share.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.share.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.share.LinkColor = System.Drawing.Color.SteelBlue;
            this.share.Location = new System.Drawing.Point(318, 46);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(58, 18);
            this.share.TabIndex = 7;
            this.share.TabStop = true;
            this.share.Text = "Chia sẻ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nameProduct);
            this.panel4.Controls.Add(this.Price);
            this.panel4.Location = new System.Drawing.Point(212, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1026, 59);
            this.panel4.TabIndex = 6;
            // 
            // ControlCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Img);
            this.Name = "ControlCart";
            this.Size = new System.Drawing.Size(1241, 188);
            this.Load += new System.EventHandler(this.ControlCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRicQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox Img;
        private System.Windows.Forms.Label nameProduct;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label status;
        private Guna.UI2.WinForms.Guna2NumericUpDown numRicQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel share;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Panel panel4;
    }
}
