namespace SpecialTopic.eBook.eBookCode
{
    partial class FormRecommend
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
            this.comboBook = new System.Windows.Forms.ComboBox();
            this.dgvRecommend = new System.Windows.Forms.DataGridView();
            this.txtTypeM = new System.Windows.Forms.TextBox();
            this.txtTypeS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommend)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBook
            // 
            this.comboBook.FormattingEnabled = true;
            this.comboBook.Location = new System.Drawing.Point(687, 47);
            this.comboBook.Name = "comboBook";
            this.comboBook.Size = new System.Drawing.Size(226, 31);
            this.comboBook.TabIndex = 0;
            // 
            // dgvRecommend
            // 
            this.dgvRecommend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecommend.Location = new System.Drawing.Point(42, 22);
            this.dgvRecommend.Name = "dgvRecommend";
            this.dgvRecommend.RowHeadersWidth = 51;
            this.dgvRecommend.RowTemplate.Height = 27;
            this.dgvRecommend.Size = new System.Drawing.Size(459, 656);
            this.dgvRecommend.TabIndex = 1;
            // 
            // txtTypeM
            // 
            this.txtTypeM.Location = new System.Drawing.Point(687, 118);
            this.txtTypeM.Name = "txtTypeM";
            this.txtTypeM.Size = new System.Drawing.Size(212, 31);
            this.txtTypeM.TabIndex = 2;
            // 
            // txtTypeS
            // 
            this.txtTypeS.Location = new System.Drawing.Point(687, 167);
            this.txtTypeS.Name = "txtTypeS";
            this.txtTypeS.Size = new System.Drawing.Size(212, 31);
            this.txtTypeS.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "電子書";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "主推薦類別";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "次推薦類別";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(766, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "新增推薦";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(766, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "刪除推薦";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(573, 375);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 31);
            this.txtSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(766, 375);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 47);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "搜尋推薦";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(766, 470);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(115, 34);
            this.btnReload.TabIndex = 10;
            this.btnReload.Text = "重新載入";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormRecommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeS);
            this.Controls.Add(this.txtTypeM);
            this.Controls.Add(this.dgvRecommend);
            this.Controls.Add(this.comboBook);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRecommend";
            this.Text = "FormRecommend";
            this.Load += new System.EventHandler(this.FormRecommend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBook;
        private System.Windows.Forms.DataGridView dgvRecommend;
        private System.Windows.Forms.TextBox txtTypeM;
        private System.Windows.Forms.TextBox txtTypeS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReload;
    }
}