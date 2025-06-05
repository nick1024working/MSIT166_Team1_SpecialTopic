namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    partial class AdminTopicManager
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
            this.lblCreate = new System.Windows.Forms.Label();
            this.txbCreate = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txbDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblBindTagToBook = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txbSetBookId = new System.Windows.Forms.TextBox();
            this.lblTagId = new System.Windows.Forms.Label();
            this.txbSetTagId = new System.Windows.Forms.TextBox();
            this.btnSetTagToBook = new System.Windows.Forms.Button();
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
            this.pnlContentArea.TabIndex = 1;
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
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblCreate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbCreate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDelete, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbDelete, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBindTagToBook, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblBookId, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txbSetBookId, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblTagId, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txbSetTagId, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnSetTagToBook, 2, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 529);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCreate.Location = new System.Drawing.Point(23, 20);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(107, 16);
            this.lblCreate.TabIndex = 2;
            this.lblCreate.Text = "新增主題名稱:";
            // 
            // txbCreate
            // 
            this.txbCreate.Location = new System.Drawing.Point(23, 39);
            this.txbCreate.Name = "txbCreate";
            this.txbCreate.Size = new System.Drawing.Size(127, 22);
            this.txbCreate.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreate.Location = new System.Drawing.Point(174, 39);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 36);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "新增";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDelete.Location = new System.Drawing.Point(23, 98);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(115, 16);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "刪除主題 by ID:";
            // 
            // txbDelete
            // 
            this.txbDelete.Location = new System.Drawing.Point(23, 117);
            this.txbDelete.Name = "txbDelete";
            this.txbDelete.Size = new System.Drawing.Size(127, 22);
            this.txbDelete.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(174, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblBindTagToBook
            // 
            this.lblBindTagToBook.AutoSize = true;
            this.lblBindTagToBook.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBindTagToBook.Location = new System.Drawing.Point(23, 176);
            this.lblBindTagToBook.Name = "lblBindTagToBook";
            this.lblBindTagToBook.Size = new System.Drawing.Size(103, 16);
            this.lblBindTagToBook.TabIndex = 8;
            this.lblBindTagToBook.Text = "為書設定主題";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookId.Location = new System.Drawing.Point(23, 192);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(59, 16);
            this.lblBookId.TabIndex = 11;
            this.lblBookId.Text = "書本ID:";
            // 
            // txbSetBookId
            // 
            this.txbSetBookId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbSetBookId.Location = new System.Drawing.Point(23, 211);
            this.txbSetBookId.Name = "txbSetBookId";
            this.txbSetBookId.Size = new System.Drawing.Size(100, 27);
            this.txbSetBookId.TabIndex = 12;
            // 
            // lblTagId
            // 
            this.lblTagId.AutoSize = true;
            this.lblTagId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTagId.Location = new System.Drawing.Point(23, 241);
            this.lblTagId.Name = "lblTagId";
            this.lblTagId.Size = new System.Drawing.Size(59, 16);
            this.lblTagId.TabIndex = 13;
            this.lblTagId.Text = "主題ID:";
            // 
            // txbSetTagId
            // 
            this.txbSetTagId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbSetTagId.Location = new System.Drawing.Point(23, 260);
            this.txbSetTagId.Name = "txbSetTagId";
            this.txbSetTagId.Size = new System.Drawing.Size(145, 27);
            this.txbSetTagId.TabIndex = 14;
            // 
            // btnSetTagToBook
            // 
            this.btnSetTagToBook.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetTagToBook.Location = new System.Drawing.Point(174, 260);
            this.btnSetTagToBook.Name = "btnSetTagToBook";
            this.btnSetTagToBook.Size = new System.Drawing.Size(60, 26);
            this.btnSetTagToBook.TabIndex = 15;
            this.btnSetTagToBook.Text = "設定";
            this.btnSetTagToBook.UseVisualStyleBackColor = true;
            this.btnSetTagToBook.Click += new System.EventHandler(this.btnSetTagToBook_Click);
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
            this.dgvMain.Size = new System.Drawing.Size(542, 529);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_ColumnHeaderMouseClick);
            // 
            // AdminTopicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContentArea);
            this.Name = "AdminTopicManager";
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
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txbCreate;
        private System.Windows.Forms.Label lblBindTagToBook;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txbSetBookId;
        private System.Windows.Forms.Label lblTagId;
        private System.Windows.Forms.TextBox txbSetTagId;
        private System.Windows.Forms.Button btnSetTagToBook;
    }
}
