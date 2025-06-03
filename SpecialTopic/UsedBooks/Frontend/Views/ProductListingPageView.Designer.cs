namespace SpecialTopic.UsedBooks.Views
{
    partial class ProductListingPageView
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lbxSaleTags = new System.Windows.Forms.ListBox();
            this.lblSaleTags = new System.Windows.Forms.Label();
            this.lbxTopics = new System.Windows.Forms.ListBox();
            this.lblTopics = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnUserCenter = new System.Windows.Forms.Button();
            this.btnAdminCenter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbSearch.Location = new System.Drawing.Point(101, 25);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(171, 30);
            this.txbSearch.TabIndex = 1;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Location = new System.Drawing.Point(28, 13);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(55, 55);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoSize = true;
            this.pnlSidebar.Controls.Add(this.lbxSaleTags);
            this.pnlSidebar.Controls.Add(this.lblSaleTags);
            this.pnlSidebar.Controls.Add(this.lbxTopics);
            this.pnlSidebar.Controls.Add(this.lblTopics);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlSidebar.MaximumSize = new System.Drawing.Size(300, 0);
            this.pnlSidebar.MinimumSize = new System.Drawing.Size(100, 200);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(100, 531);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lbxSaleTags
            // 
            this.lbxSaleTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxSaleTags.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxSaleTags.FormattingEnabled = true;
            this.lbxSaleTags.ItemHeight = 19;
            this.lbxSaleTags.Location = new System.Drawing.Point(0, 293);
            this.lbxSaleTags.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lbxSaleTags.Name = "lbxSaleTags";
            this.lbxSaleTags.Size = new System.Drawing.Size(100, 213);
            this.lbxSaleTags.TabIndex = 3;
            this.lbxSaleTags.SelectedIndexChanged += new System.EventHandler(this.lbxSaleTags_SelectedIndexChanged);
            // 
            // lblSaleTags
            // 
            this.lblSaleTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaleTags.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSaleTags.Location = new System.Drawing.Point(0, 253);
            this.lblSaleTags.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSaleTags.Name = "lblSaleTags";
            this.lblSaleTags.Size = new System.Drawing.Size(100, 40);
            this.lblSaleTags.TabIndex = 2;
            this.lblSaleTags.Text = "促銷標籤";
            this.lblSaleTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxTopics
            // 
            this.lbxTopics.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxTopics.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxTopics.FormattingEnabled = true;
            this.lbxTopics.ItemHeight = 19;
            this.lbxTopics.Location = new System.Drawing.Point(0, 40);
            this.lbxTopics.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lbxTopics.Name = "lbxTopics";
            this.lbxTopics.Size = new System.Drawing.Size(100, 213);
            this.lbxTopics.TabIndex = 0;
            // 
            // lblTopics
            // 
            this.lblTopics.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopics.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTopics.Location = new System.Drawing.Point(0, 0);
            this.lblTopics.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(100, 40);
            this.lblTopics.TabIndex = 1;
            this.lblTopics.Text = "主題分類";
            this.lblTopics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlMain.Controls.Add(this.flpMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(794, 531);
            this.pnlMain.TabIndex = 1;
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Location = new System.Drawing.Point(0, 0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(794, 531);
            this.flpMain.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.splitContainer1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(900, 619);
            this.mainPanel.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlHeader);
            this.splitContainer1.Panel1MinSize = 80;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 500;
            this.splitContainer1.Size = new System.Drawing.Size(898, 617);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnCreateOrder);
            this.pnlHeader.Controls.Add(this.btnUserCenter);
            this.pnlHeader.Controls.Add(this.btnAdminCenter);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txbSearch);
            this.pnlHeader.Controls.Add(this.pbxLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(896, 78);
            this.pnlHeader.TabIndex = 3;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateOrder.Location = new System.Drawing.Point(611, 25);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(80, 30);
            this.btnCreateOrder.TabIndex = 2;
            this.btnCreateOrder.Text = "新增訂單";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // btnUserCenter
            // 
            this.btnUserCenter.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUserCenter.Location = new System.Drawing.Point(519, 25);
            this.btnUserCenter.Name = "btnUserCenter";
            this.btnUserCenter.Size = new System.Drawing.Size(80, 30);
            this.btnUserCenter.TabIndex = 2;
            this.btnUserCenter.Text = "會員中心";
            this.btnUserCenter.UseVisualStyleBackColor = true;
            // 
            // btnAdminCenter
            // 
            this.btnAdminCenter.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdminCenter.Location = new System.Drawing.Point(398, 25);
            this.btnAdminCenter.Name = "btnAdminCenter";
            this.btnAdminCenter.Size = new System.Drawing.Size(109, 30);
            this.btnAdminCenter.TabIndex = 2;
            this.btnAdminCenter.Text = "管理員中心";
            this.btnAdminCenter.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(293, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pnlSidebar);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlMain);
            this.splitContainer2.Size = new System.Drawing.Size(898, 533);
            this.splitContainer2.SplitterDistance = 98;
            this.splitContainer2.TabIndex = 1;
            // 
            // ProductListingPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.mainPanel);
            this.Name = "ProductListingPageView";
            this.Size = new System.Drawing.Size(900, 619);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lbxTopics;
        private System.Windows.Forms.Label lblTopics;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ListBox lbxSaleTags;
        private System.Windows.Forms.Label lblSaleTags;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnUserCenter;
        private System.Windows.Forms.Button btnAdminCenter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
    }
}
