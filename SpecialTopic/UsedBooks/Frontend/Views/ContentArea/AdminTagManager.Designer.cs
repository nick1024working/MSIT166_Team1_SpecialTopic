namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    partial class AdminTagManager
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txbCreate = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblBindTagToBook = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblTagId = new System.Windows.Forms.Label();
            this.txbSetTagId = new System.Windows.Forms.TextBox();
            this.btnSetTagToBook = new System.Windows.Forms.Button();
            this.txbSetBookId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTags = new System.Windows.Forms.DataGridView();
            this.dgvBookTags = new System.Windows.Forms.DataGridView();
            this.pnlContentArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTags)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(798, 531);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(228, 529);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txbDelete, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDelete, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbCreate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCreate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBindTagToBook, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblBookId, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblTagId, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txbSetTagId, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnSetTagToBook, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.txbSetBookId, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 258);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txbDelete
            // 
            this.txbDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbDelete.Location = new System.Drawing.Point(23, 110);
            this.txbDelete.Name = "txbDelete";
            this.txbDelete.Size = new System.Drawing.Size(127, 27);
            this.txbDelete.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(159, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDelete.Location = new System.Drawing.Point(23, 75);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(127, 32);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "刪除促銷標籤 by ID:";
            // 
            // txbCreate
            // 
            this.txbCreate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbCreate.Location = new System.Drawing.Point(23, 45);
            this.txbCreate.Name = "txbCreate";
            this.txbCreate.Size = new System.Drawing.Size(127, 27);
            this.txbCreate.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreate.Location = new System.Drawing.Point(159, 45);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(60, 27);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "新增";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCreate.Location = new System.Drawing.Point(23, 10);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(119, 32);
            this.lblCreate.TabIndex = 2;
            this.lblCreate.Text = "新增促銷標籤名稱:";
            // 
            // lblBindTagToBook
            // 
            this.lblBindTagToBook.AutoSize = true;
            this.lblBindTagToBook.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBindTagToBook.Location = new System.Drawing.Point(23, 140);
            this.lblBindTagToBook.Name = "lblBindTagToBook";
            this.lblBindTagToBook.Size = new System.Drawing.Size(119, 32);
            this.lblBindTagToBook.TabIndex = 7;
            this.lblBindTagToBook.Text = "為書設定促銷標籤";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookId.Location = new System.Drawing.Point(23, 172);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(59, 16);
            this.lblBookId.TabIndex = 10;
            this.lblBookId.Text = "書本ID:";
            // 
            // lblTagId
            // 
            this.lblTagId.AutoSize = true;
            this.lblTagId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTagId.Location = new System.Drawing.Point(23, 221);
            this.lblTagId.Name = "lblTagId";
            this.lblTagId.Size = new System.Drawing.Size(91, 16);
            this.lblTagId.TabIndex = 11;
            this.lblTagId.Text = "促銷標籤ID:";
            // 
            // txbSetTagId
            // 
            this.txbSetTagId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbSetTagId.Location = new System.Drawing.Point(23, 240);
            this.txbSetTagId.Name = "txbSetTagId";
            this.txbSetTagId.Size = new System.Drawing.Size(130, 27);
            this.txbSetTagId.TabIndex = 12;
            // 
            // btnSetTagToBook
            // 
            this.btnSetTagToBook.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetTagToBook.Location = new System.Drawing.Point(159, 240);
            this.btnSetTagToBook.Name = "btnSetTagToBook";
            this.btnSetTagToBook.Size = new System.Drawing.Size(60, 26);
            this.btnSetTagToBook.TabIndex = 13;
            this.btnSetTagToBook.Text = "設定";
            this.btnSetTagToBook.UseVisualStyleBackColor = true;
            this.btnSetTagToBook.Click += new System.EventHandler(this.btnSetTagToBook_Click);
            // 
            // txbSetBookId
            // 
            this.txbSetBookId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbSetBookId.Location = new System.Drawing.Point(23, 191);
            this.txbSetBookId.Name = "txbSetBookId";
            this.txbSetBookId.Size = new System.Drawing.Size(100, 27);
            this.txbSetBookId.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.txbSearch, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblSearch, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSearch, 2, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 267);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 14;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(222, 259);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbSearch.Location = new System.Drawing.Point(23, 29);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(130, 27);
            this.txbSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSearch.Location = new System.Drawing.Point(23, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(99, 16);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "標籤 ID 找書:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(159, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvTags, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvBookTags, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(562, 529);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvTags
            // 
            this.dgvTags.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTags.Location = new System.Drawing.Point(3, 3);
            this.dgvTags.Name = "dgvTags";
            this.dgvTags.RowHeadersWidth = 82;
            this.dgvTags.RowTemplate.Height = 24;
            this.dgvTags.Size = new System.Drawing.Size(556, 258);
            this.dgvTags.TabIndex = 0;
            this.dgvTags.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTags_ColumnHeaderMouseClick);
            // 
            // dgvBookTags
            // 
            this.dgvBookTags.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBookTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookTags.Location = new System.Drawing.Point(3, 267);
            this.dgvBookTags.Name = "dgvBookTags";
            this.dgvBookTags.RowHeadersWidth = 82;
            this.dgvBookTags.RowTemplate.Height = 24;
            this.dgvBookTags.Size = new System.Drawing.Size(556, 259);
            this.dgvBookTags.TabIndex = 1;
            // 
            // AdminTagManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContentArea);
            this.Name = "AdminTagManager";
            this.Size = new System.Drawing.Size(798, 531);
            this.pnlContentArea.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContentArea;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txbDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txbCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.DataGridView dgvTags;
        private System.Windows.Forms.Label lblBindTagToBook;
        private System.Windows.Forms.TextBox txbSetBookId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblTagId;
        private System.Windows.Forms.TextBox txbSetTagId;
        private System.Windows.Forms.Button btnSetTagToBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvBookTags;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}
