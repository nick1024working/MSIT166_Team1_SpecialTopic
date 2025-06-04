namespace SpecialTopic.eBook.eBookCode
{
    partial class FormSubscriber
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
            this.dgvSubscribers = new System.Windows.Forms.DataGridView();
            this.comboUID = new System.Windows.Forms.ComboBox();
            this.dtpDueTime = new System.Windows.Forms.DateTimePicker();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.dtpLastPayTime = new System.Windows.Forms.DateTimePicker();
            this.dtpNextPayTime = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubscribers
            // 
            this.dgvSubscribers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscribers.Location = new System.Drawing.Point(47, 47);
            this.dgvSubscribers.Name = "dgvSubscribers";
            this.dgvSubscribers.RowHeadersWidth = 51;
            this.dgvSubscribers.RowTemplate.Height = 27;
            this.dgvSubscribers.Size = new System.Drawing.Size(655, 234);
            this.dgvSubscribers.TabIndex = 0;
            // 
            // comboUID
            // 
            this.comboUID.FormattingEnabled = true;
            this.comboUID.Location = new System.Drawing.Point(95, 323);
            this.comboUID.Name = "comboUID";
            this.comboUID.Size = new System.Drawing.Size(198, 31);
            this.comboUID.TabIndex = 1;
            // 
            // dtpDueTime
            // 
            this.dtpDueTime.Location = new System.Drawing.Point(93, 439);
            this.dtpDueTime.Name = "dtpDueTime";
            this.dtpDueTime.Size = new System.Drawing.Size(200, 31);
            this.dtpDueTime.TabIndex = 2;
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(95, 379);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(198, 31);
            this.comboStatus.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(574, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增訂閱者";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(574, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(574, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "刪除選取訂閱者";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(673, 491);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(597, 543);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(124, 35);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "重新載入";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dtpLastPayTime
            // 
            this.dtpLastPayTime.Location = new System.Drawing.Point(93, 489);
            this.dtpLastPayTime.Name = "dtpLastPayTime";
            this.dtpLastPayTime.Size = new System.Drawing.Size(200, 31);
            this.dtpLastPayTime.TabIndex = 9;
            // 
            // dtpNextPayTime
            // 
            this.dtpNextPayTime.Location = new System.Drawing.Point(93, 526);
            this.dtpNextPayTime.Name = "dtpNextPayTime";
            this.dtpNextPayTime.Size = new System.Drawing.Size(200, 31);
            this.dtpNextPayTime.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(500, 495);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 31);
            this.txtSearch.TabIndex = 11;
            // 
            // FormSubscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtpNextPayTime);
            this.Controls.Add(this.dtpLastPayTime);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.dtpDueTime);
            this.Controls.Add(this.comboUID);
            this.Controls.Add(this.dgvSubscribers);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSubscriber";
            this.Text = "FormSubscriber";
            this.Load += new System.EventHandler(this.FormSubscriber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubscribers;
        private System.Windows.Forms.ComboBox comboUID;
        private System.Windows.Forms.DateTimePicker dtpDueTime;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DateTimePicker dtpLastPayTime;
        private System.Windows.Forms.DateTimePicker dtpNextPayTime;
        private System.Windows.Forms.TextBox txtSearch;
    }
}