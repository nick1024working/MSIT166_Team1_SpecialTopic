namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    partial class AdminOrderManager
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
            this.txbChangeStatusId = new System.Windows.Forms.TextBox();
            this.lblChangeStatus = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txbCreate = new System.Windows.Forms.Label();
            this.cbxOrderStatus = new System.Windows.Forms.ComboBox();
            this.btnChangeStatus = new System.Windows.Forms.Button();
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
            this.pnlContentArea.TabIndex = 0;
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
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txbSearch, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSearch, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLoadAll, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadAll, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbChangeStatusId, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblChangeStatus, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txbCreate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbxOrderStatus, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeStatus, 2, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 529);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(23, 88);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(127, 22);
            this.txbSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSearch.Location = new System.Drawing.Point(23, 69);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 16);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "關鍵字查詢:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(171, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblLoadAll
            // 
            this.lblLoadAll.AutoSize = true;
            this.lblLoadAll.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoadAll.Location = new System.Drawing.Point(23, 20);
            this.lblLoadAll.Name = "lblLoadAll";
            this.lblLoadAll.Size = new System.Drawing.Size(107, 16);
            this.lblLoadAll.TabIndex = 7;
            this.lblLoadAll.Text = "載入全部訂單:";
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoadAll.Location = new System.Drawing.Point(171, 23);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(60, 23);
            this.btnLoadAll.TabIndex = 8;
            this.btnLoadAll.Text = "載入";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // txbChangeStatusId
            // 
            this.txbChangeStatusId.Location = new System.Drawing.Point(23, 217);
            this.txbChangeStatusId.Name = "txbChangeStatusId";
            this.txbChangeStatusId.Size = new System.Drawing.Size(127, 22);
            this.txbChangeStatusId.TabIndex = 4;
            // 
            // lblChangeStatus
            // 
            this.lblChangeStatus.AutoSize = true;
            this.lblChangeStatus.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChangeStatus.Location = new System.Drawing.Point(23, 182);
            this.lblChangeStatus.Name = "lblChangeStatus";
            this.lblChangeStatus.Size = new System.Drawing.Size(127, 32);
            this.lblChangeStatus.TabIndex = 2;
            this.lblChangeStatus.Text = "更改訂單狀態 by ID:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreate.Location = new System.Drawing.Point(171, 137);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(60, 22);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "執行";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txbCreate
            // 
            this.txbCreate.AutoSize = true;
            this.txbCreate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbCreate.Location = new System.Drawing.Point(23, 134);
            this.txbCreate.Name = "txbCreate";
            this.txbCreate.Size = new System.Drawing.Size(123, 16);
            this.txbCreate.TabIndex = 9;
            this.txbCreate.Text = "新增與修改訂單:";
            // 
            // cbxOrderStatus
            // 
            this.cbxOrderStatus.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxOrderStatus.FormattingEnabled = true;
            this.cbxOrderStatus.Items.AddRange(new object[] {
            "上架",
            "下架"});
            this.cbxOrderStatus.Location = new System.Drawing.Point(23, 245);
            this.cbxOrderStatus.Name = "cbxOrderStatus";
            this.cbxOrderStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxOrderStatus.TabIndex = 13;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChangeStatus.Location = new System.Drawing.Point(171, 245);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(60, 22);
            this.btnChangeStatus.TabIndex = 3;
            this.btnChangeStatus.Text = "更改";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
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
            this.dgvMain.Size = new System.Drawing.Size(556, 529);
            this.dgvMain.TabIndex = 0;
            // 
            // AdminOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContentArea);
            this.Name = "AdminOrderManager";
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
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLoadAll;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.TextBox txbChangeStatusId;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Label lblChangeStatus;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label txbCreate;
        private System.Windows.Forms.ComboBox cbxOrderStatus;
    }
}
