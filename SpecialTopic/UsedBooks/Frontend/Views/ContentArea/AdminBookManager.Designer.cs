namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    partial class AdminBookManager
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
            this.pnlContentArea = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLoadAll = new System.Windows.Forms.Label();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.txbDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.txbIsActiveId = new System.Windows.Forms.TextBox();
            this.btnIsActive = new System.Windows.Forms.Button();
            this.cbxIsActiveStatus = new System.Windows.Forms.ComboBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlContentArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContentArea
            // 
            this.pnlContentArea.Controls.Add(this.splitContainer1);
            this.pnlContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentArea.Location = new System.Drawing.Point(0, 0);
            this.pnlContentArea.Name = "pnlContentArea";
            this.pnlContentArea.Size = new System.Drawing.Size(798, 531);
            this.pnlContentArea.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMain);
            this.splitContainer1.Size = new System.Drawing.Size(798, 531);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txbSearch, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSearch, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLoadAll, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadAll, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbDelete, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblDelete, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblIsActive, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txbIsActiveId, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnIsActive, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.cbxIsActiveStatus, 1, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 529);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(12, 88);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(127, 22);
            this.txbSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSearch.Location = new System.Drawing.Point(12, 69);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 16);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "關鍵字查詢:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(145, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblLoadAll
            // 
            this.lblLoadAll.AutoSize = true;
            this.lblLoadAll.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoadAll.Location = new System.Drawing.Point(12, 20);
            this.lblLoadAll.Name = "lblLoadAll";
            this.lblLoadAll.Size = new System.Drawing.Size(107, 16);
            this.lblLoadAll.TabIndex = 7;
            this.lblLoadAll.Text = "載入全部書本:";
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoadAll.Location = new System.Drawing.Point(145, 23);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(60, 23);
            this.btnLoadAll.TabIndex = 8;
            this.btnLoadAll.Text = "載入";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // txbDelete
            // 
            this.txbDelete.Location = new System.Drawing.Point(12, 153);
            this.txbDelete.Name = "txbDelete";
            this.txbDelete.Size = new System.Drawing.Size(127, 22);
            this.txbDelete.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(145, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDelete.Location = new System.Drawing.Point(12, 134);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(115, 16);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "刪除書本 by ID:";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIsActive.Location = new System.Drawing.Point(12, 199);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(115, 16);
            this.lblIsActive.TabIndex = 9;
            this.lblIsActive.Text = "下架書本 by ID:";
            // 
            // txbIsActiveId
            // 
            this.txbIsActiveId.Location = new System.Drawing.Point(12, 218);
            this.txbIsActiveId.Name = "txbIsActiveId";
            this.txbIsActiveId.Size = new System.Drawing.Size(127, 22);
            this.txbIsActiveId.TabIndex = 10;
            // 
            // btnIsActive
            // 
            this.btnIsActive.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIsActive.Location = new System.Drawing.Point(145, 246);
            this.btnIsActive.Name = "btnIsActive";
            this.btnIsActive.Size = new System.Drawing.Size(60, 23);
            this.btnIsActive.TabIndex = 11;
            this.btnIsActive.Text = "更改";
            this.btnIsActive.UseVisualStyleBackColor = true;
            this.btnIsActive.Click += new System.EventHandler(this.btnIsActive_Click);
            // 
            // cbxIsActiveStatus
            // 
            this.cbxIsActiveStatus.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxIsActiveStatus.FormattingEnabled = true;
            this.cbxIsActiveStatus.Items.AddRange(new object[] {
            "上架",
            "下架"});
            this.cbxIsActiveStatus.Location = new System.Drawing.Point(12, 246);
            this.cbxIsActiveStatus.Name = "cbxIsActiveStatus";
            this.cbxIsActiveStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxIsActiveStatus.TabIndex = 12;
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 82;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(562, 529);
            this.dgvMain.TabIndex = 0;
            // 
            // AdminBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContentArea);
            this.Name = "AdminBookManager";
            this.Size = new System.Drawing.Size(798, 531);
            this.pnlContentArea.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContentArea;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txbDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblLoadAll;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.TextBox txbIsActiveId;
        private System.Windows.Forms.Button btnIsActive;
        private System.Windows.Forms.ComboBox cbxIsActiveStatus;
    }
}
