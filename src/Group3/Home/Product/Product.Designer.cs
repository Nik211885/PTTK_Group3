namespace Group3.Home.Product
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.imgFood = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Buy = new Guna.UI2.WinForms.Guna2Button();
            this.PanelPromotion = new Guna.UI2.WinForms.Guna2Panel();
            this.PromotionFood = new System.Windows.Forms.Label();
            this.NameProduct = new System.Windows.Forms.Label();
            this.FoodPromotion = new System.Windows.Forms.Label();
            this.PromotionPriced = new System.Windows.Forms.Label();
            this.PriceFood = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).BeginInit();
            this.PanelPromotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgFood
            // 
            this.imgFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFood.Image = ((System.Drawing.Image)(resources.GetObject("imgFood.Image")));
            this.imgFood.ImageRotate = 0F;
            this.imgFood.Location = new System.Drawing.Point(0, 0);
            this.imgFood.Name = "imgFood";
            this.imgFood.Size = new System.Drawing.Size(252, 222);
            this.imgFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood.TabIndex = 0;
            this.imgFood.TabStop = false;
            this.imgFood.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Buy
            // 
            this.Buy.Animated = true;
            this.Buy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.Buy.BorderRadius = 7;
            this.Buy.BorderThickness = 2;
            this.Buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.Buy.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.Buy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.Buy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.Buy.FillColor = System.Drawing.Color.White;
            this.Buy.Font = new System.Drawing.Font("Calibri", 9F);
            this.Buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.Buy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.Buy.HoverState.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy.HoverState.ForeColor = System.Drawing.Color.White;
            this.Buy.ImageSize = new System.Drawing.Size(30, 30);
            this.Buy.Location = new System.Drawing.Point(3, 317);
            this.Buy.Name = "Buy";
            this.Buy.PressedColor = System.Drawing.Color.OldLace;
            this.Buy.Size = new System.Drawing.Size(245, 36);
            this.Buy.TabIndex = 4;
            this.Buy.Text = "Chọn mua";
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // PanelPromotion
            // 
            this.PanelPromotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.PanelPromotion.Controls.Add(this.PromotionFood);
            this.PanelPromotion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelPromotion.Location = new System.Drawing.Point(3, 3);
            this.PanelPromotion.Name = "PanelPromotion";
            this.PanelPromotion.Size = new System.Drawing.Size(54, 36);
            this.PanelPromotion.TabIndex = 5;
            // 
            // PromotionFood
            // 
            this.PromotionFood.AutoSize = true;
            this.PromotionFood.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromotionFood.ForeColor = System.Drawing.Color.White;
            this.PromotionFood.Location = new System.Drawing.Point(5, 6);
            this.PromotionFood.Name = "PromotionFood";
            this.PromotionFood.Size = new System.Drawing.Size(46, 20);
            this.PromotionFood.TabIndex = 6;
            this.PromotionFood.Text = "45%";
            this.PromotionFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSize = true;
            this.NameProduct.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct.Location = new System.Drawing.Point(8, 234);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(112, 21);
            this.NameProduct.TabIndex = 6;
            this.NameProduct.Text = "label2aaaaaa";
            // 
            // FoodPromotion
            // 
            this.FoodPromotion.AutoSize = true;
            this.FoodPromotion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodPromotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.FoodPromotion.Location = new System.Drawing.Point(8, 284);
            this.FoodPromotion.Name = "FoodPromotion";
            this.FoodPromotion.Size = new System.Drawing.Size(64, 21);
            this.FoodPromotion.TabIndex = 7;
            this.FoodPromotion.Text = "10000đ";
            // 
            // PromotionPriced
            // 
            this.PromotionPriced.Location = new System.Drawing.Point(0, 0);
            this.PromotionPriced.Name = "PromotionPriced";
            this.PromotionPriced.Size = new System.Drawing.Size(100, 23);
            this.PromotionPriced.TabIndex = 0;
            // 
            // PriceFood
            // 
            this.PriceFood.AutoSize = true;
            this.PriceFood.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceFood.Location = new System.Drawing.Point(93, 284);
            this.PriceFood.Name = "PriceFood";
            this.PriceFood.Size = new System.Drawing.Size(52, 21);
            this.PriceFood.TabIndex = 8;
            this.PriceFood.Text = "label2";
            // 
            // panelLine
            // 
            this.panelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLine.Location = new System.Drawing.Point(97, 295);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(100, 1);
            this.panelLine.TabIndex = 9;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.PriceFood);
            this.Controls.Add(this.FoodPromotion);
            this.Controls.Add(this.NameProduct);
            this.Controls.Add(this.PanelPromotion);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.imgFood);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(252, 356);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).EndInit();
            this.PanelPromotion.ResumeLayout(false);
            this.PanelPromotion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imgFood;
        private Guna.UI2.WinForms.Guna2Button Buy;
        private Guna.UI2.WinForms.Guna2Panel PanelPromotion;
        private System.Windows.Forms.Label PromotionFood;
        private System.Windows.Forms.Label NameProduct;
        private System.Windows.Forms.Label FoodPromotion;
        private System.Windows.Forms.Label PromotionPriced;
        private System.Windows.Forms.Label PriceFood;
        private System.Windows.Forms.Panel panelLine;
    }
}
