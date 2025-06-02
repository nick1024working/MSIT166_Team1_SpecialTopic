using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpecialTopic
{
    partial class EBookControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOpenSelectedBook = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnPurchasedBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1892, 1104);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 146);
            this.button1.TabIndex = 0;
            this.button1.Text = "電子書";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(52, 36);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(177, 54);
            this.btnImportExcel.TabIndex = 1;
            this.btnImportExcel.Text = "importexcelbutton";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Openebookid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(426, 275);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnOpenSelectedBook
            // 
            this.btnOpenSelectedBook.Location = new System.Drawing.Point(63, 209);
            this.btnOpenSelectedBook.Name = "btnOpenSelectedBook";
            this.btnOpenSelectedBook.Size = new System.Drawing.Size(181, 32);
            this.btnOpenSelectedBook.TabIndex = 4;
            this.btnOpenSelectedBook.Text = "開啟選取電子書";
            this.btnOpenSelectedBook.UseVisualStyleBackColor = true;
            this.btnOpenSelectedBook.Click += new System.EventHandler(this.btnOpenSelectedBook_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(831, 53);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(212, 280);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 5;
            this.pictureBoxCover.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(63, 297);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(166, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "新增編輯書";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1129, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 31);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1351, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 34);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "搜書";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(1161, 309);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(188, 48);
            this.btnViewOrders.TabIndex = 10;
            this.btnViewOrders.Text = "訂單管理";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnPurchasedBooks
            // 
            this.btnPurchasedBooks.Location = new System.Drawing.Point(84, 408);
            this.btnPurchasedBooks.Name = "btnPurchasedBooks";
            this.btnPurchasedBooks.Size = new System.Drawing.Size(112, 33);
            this.btnPurchasedBooks.TabIndex = 11;
            this.btnPurchasedBooks.Text = "button3";
            this.btnPurchasedBooks.UseVisualStyleBackColor = true;
            // 
            // EBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPurchasedBooks);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.btnOpenSelectedBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EBookControl";
            this.Size = new System.Drawing.Size(2232, 1596);
            this.Load += new System.EventHandler(this.EBookControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOpenSelectedBook;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewOrders;
        private Button btnPurchasedBooks;
    }
}
