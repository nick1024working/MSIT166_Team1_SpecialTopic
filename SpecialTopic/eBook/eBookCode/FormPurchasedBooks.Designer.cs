namespace SpecialTopic.eBook.eBookCode
{
    partial class FormPurchasedBooks
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



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPurchased = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOpenBook = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActualPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEbookName = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPurchased = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchased)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPurchased
            // 
            this.dgvPurchased.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchased.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvPurchased.Location = new System.Drawing.Point(0, 0);
            this.dgvPurchased.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPurchased.Name = "dgvPurchased";
            this.dgvPurchased.RowTemplate.Height = 24;
            this.dgvPurchased.Size = new System.Drawing.Size(600, 712);
            this.dgvPurchased.TabIndex = 0;
            this.dgvPurchased.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchased_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(90, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 19);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "搜尋書名";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(276, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOpenBook
            // 
            this.btnOpenBook.Location = new System.Drawing.Point(32, 109);
            this.btnOpenBook.Name = "btnOpenBook";
            this.btnOpenBook.Size = new System.Drawing.Size(109, 27);
            this.btnOpenBook.TabIndex = 4;
            this.btnOpenBook.Text = "開啟書籍";
            this.btnOpenBook.UseVisualStyleBackColor = true;
            this.btnOpenBook.Click += new System.EventHandler(this.btnOpenBook_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "刪除此筆";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(307, 566);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "關閉";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtActualPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEbookName);
            this.panel1.Controls.Add(this.txtUID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAddPurchased);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnOpenBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 712);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "實售價";
            // 
            // txtActualPrice
            // 
            this.txtActualPrice.Location = new System.Drawing.Point(72, 272);
            this.txtActualPrice.Name = "txtActualPrice";
            this.txtActualPrice.Size = new System.Drawing.Size(187, 26);
            this.txtActualPrice.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "書名";
            // 
            // txtEbookName
            // 
            this.txtEbookName.Location = new System.Drawing.Point(59, 225);
            this.txtEbookName.Name = "txtEbookName";
            this.txtEbookName.Size = new System.Drawing.Size(187, 26);
            this.txtEbookName.TabIndex = 10;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(59, 175);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(188, 26);
            this.txtUID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "UID";
            // 
            // btnAddPurchased
            // 
            this.btnAddPurchased.Location = new System.Drawing.Point(266, 225);
            this.btnAddPurchased.Name = "btnAddPurchased";
            this.btnAddPurchased.Size = new System.Drawing.Size(148, 27);
            this.btnAddPurchased.TabIndex = 7;
            this.btnAddPurchased.Text = "新增已購買書籍";
            this.btnAddPurchased.UseVisualStyleBackColor = true;
            this.btnAddPurchased.Click += new System.EventHandler(this.btnAddPurchased_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(59, 355);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(121, 32);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "儲存變更";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // FormPurchasedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPurchased);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPurchasedBooks";
            this.Text = "FormPurchasedBooks";
            this.Load += new System.EventHandler(this.FormPurchasedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchased)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPurchased;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOpenBook;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPurchased;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEbookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActualPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}