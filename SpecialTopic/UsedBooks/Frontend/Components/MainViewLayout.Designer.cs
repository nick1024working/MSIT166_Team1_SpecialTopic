namespace SpecialTopic.UsedBooks.Frontend.Components
{
    partial class MainViewLayout
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.flpHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdminCenter = new System.Windows.Forms.Button();
            this.btnUserCenter = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lbxItem1 = new System.Windows.Forms.ListBox();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.flpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
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
            this.mainPanel.TabIndex = 2;
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
            this.splitContainer1.Panel1.Controls.Add(this.tlpHeader);
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
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 1;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Controls.Add(this.flpHeader, 0, 1);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 3;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.Size = new System.Drawing.Size(896, 78);
            this.tlpHeader.TabIndex = 3;
            // 
            // flpHeader
            // 
            this.flpHeader.AutoSize = true;
            this.flpHeader.Controls.Add(this.pbxLogo);
            this.flpHeader.Controls.Add(this.txbSearch);
            this.flpHeader.Controls.Add(this.btnSearch);
            this.flpHeader.Controls.Add(this.btnAdminCenter);
            this.flpHeader.Controls.Add(this.btnUserCenter);
            this.flpHeader.Controls.Add(this.btnCreateOrder);
            this.flpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHeader.Location = new System.Drawing.Point(3, 20);
            this.flpHeader.Name = "flpHeader";
            this.flpHeader.Size = new System.Drawing.Size(890, 37);
            this.flpHeader.TabIndex = 3;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Location = new System.Drawing.Point(20, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(35, 35);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbSearch.Location = new System.Drawing.Point(76, 2);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(171, 33);
            this.txbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(258, 3);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdminCenter
            // 
            this.btnAdminCenter.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdminCenter.Location = new System.Drawing.Point(358, 3);
            this.btnAdminCenter.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAdminCenter.Name = "btnAdminCenter";
            this.btnAdminCenter.Size = new System.Drawing.Size(109, 26);
            this.btnAdminCenter.TabIndex = 2;
            this.btnAdminCenter.Text = "管理員中心";
            this.btnAdminCenter.UseVisualStyleBackColor = true;
            // 
            // btnUserCenter
            // 
            this.btnUserCenter.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUserCenter.Location = new System.Drawing.Point(487, 3);
            this.btnUserCenter.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnUserCenter.Name = "btnUserCenter";
            this.btnUserCenter.Size = new System.Drawing.Size(80, 26);
            this.btnUserCenter.TabIndex = 2;
            this.btnUserCenter.Text = "會員中心";
            this.btnUserCenter.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.AutoSize = true;
            this.btnCreateOrder.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateOrder.Location = new System.Drawing.Point(587, 3);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(81, 26);
            this.btnCreateOrder.TabIndex = 2;
            this.btnCreateOrder.Text = "新增訂單";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
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
            this.splitContainer2.SplitterDistance = 96;
            this.splitContainer2.TabIndex = 1;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoSize = true;
            this.pnlSidebar.Controls.Add(this.lbxItem1);
            this.pnlSidebar.Controls.Add(this.lblItem1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlSidebar.MaximumSize = new System.Drawing.Size(300, 0);
            this.pnlSidebar.MinimumSize = new System.Drawing.Size(100, 200);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(100, 531);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lbxItem1
            // 
            this.lbxItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxItem1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxItem1.FormattingEnabled = true;
            this.lbxItem1.ItemHeight = 19;
            this.lbxItem1.Items.AddRange(new object[] {
            "項目1選項"});
            this.lbxItem1.Location = new System.Drawing.Point(0, 40);
            this.lbxItem1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lbxItem1.Name = "lbxItem1";
            this.lbxItem1.Size = new System.Drawing.Size(100, 213);
            this.lbxItem1.TabIndex = 0;
            // 
            // lblItem1
            // 
            this.lblItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItem1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblItem1.Location = new System.Drawing.Point(0, 0);
            this.lblItem1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(100, 40);
            this.lblItem1.TabIndex = 1;
            this.lblItem1.Text = "項目1";
            this.lblItem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(796, 531);
            this.pnlMain.TabIndex = 1;
            // 
            // MainViewLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "MainViewLayout";
            this.Size = new System.Drawing.Size(900, 619);
            this.mainPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.flpHeader.ResumeLayout(false);
            this.flpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.FlowLayoutPanel flpHeader;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdminCenter;
        private System.Windows.Forms.Button btnUserCenter;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.ListBox lbxItem1;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Panel pnlMain;
    }
}
