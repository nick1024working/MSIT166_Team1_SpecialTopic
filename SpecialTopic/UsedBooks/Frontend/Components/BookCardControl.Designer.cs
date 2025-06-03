namespace SpecialTopic.UsedBooks.Frontend.Components
{
    partial class BookCardControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxCover = new System.Windows.Forms.PictureBox();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpPriceAll = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCover)).BeginInit();
            this.flpPriceAll.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxCover
            // 
            this.pbxCover.Location = new System.Drawing.Point(0, 0);
            this.pbxCover.Name = "pbxCover";
            this.pbxCover.Size = new System.Drawing.Size(70, 105);
            this.pbxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCover.TabIndex = 0;
            this.pbxCover.TabStop = false;
            // 
            // lblAuthors
            // 
            this.lblAuthors.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAuthors.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAuthors.Location = new System.Drawing.Point(0, 30);
            this.lblAuthors.Margin = new System.Windows.Forms.Padding(0);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(146, 14);
            this.lblAuthors.TabIndex = 3;
            this.lblAuthors.Text = " 麥可・艾爾珀特";
            this.lblAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblPrice.Location = new System.Drawing.Point(100, 0);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.MaximumSize = new System.Drawing.Size(0, 24);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 24);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "296";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(78, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 24);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "NT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // flpPriceAll
            // 
            this.flpPriceAll.AutoSize = true;
            this.flpPriceAll.BackColor = System.Drawing.Color.Transparent;
            this.flpPriceAll.Controls.Add(this.lblPrice);
            this.flpPriceAll.Controls.Add(this.label1);
            this.flpPriceAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPriceAll.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPriceAll.Location = new System.Drawing.Point(0, 75);
            this.flpPriceAll.Name = "flpPriceAll";
            this.flpPriceAll.Size = new System.Drawing.Size(146, 31);
            this.flpPriceAll.TabIndex = 5;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pbxCover);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(70, 106);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.flpPriceAll);
            this.pnlRight.Controls.Add(this.lblDescription);
            this.pnlRight.Controls.Add(this.lblAuthors);
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(70, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(146, 106);
            this.pnlRight.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDescription.Location = new System.Drawing.Point(0, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblDescription.Size = new System.Drawing.Size(146, 31);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "再舉高一點，踩在艱難現實泥濘的你，\r\n必須把夢想高舉過頭啊！\r\n\r\n";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblTitle.Size = new System.Drawing.Size(122, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "倫敦超展開 ：\r\n維多利亞時代的城市";
            // 
            // BookCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.MaximumSize = new System.Drawing.Size(216, 106);
            this.MinimumSize = new System.Drawing.Size(100, 50);
            this.Name = "BookCardControl";
            this.Size = new System.Drawing.Size(216, 106);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCover)).EndInit();
            this.flpPriceAll.ResumeLayout(false);
            this.flpPriceAll.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCover;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpPriceAll;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
    }
}
