namespace SpecialTopic.Forum
{
    partial class FrmCommentDetail
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
            this.lblPostID = new System.Windows.Forms.Label();
            this.cmbPostID = new System.Windows.Forms.ComboBox();
            this.lblParentCommentID = new System.Windows.Forms.Label();
            this.cmbParentCommentID = new System.Windows.Forms.ComboBox();
            this.lblUID = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPostID
            // 
            this.lblPostID.AutoSize = true;
            this.lblPostID.Location = new System.Drawing.Point(12, 20);
            this.lblPostID.Name = "lblPostID";
            this.lblPostID.Size = new System.Drawing.Size(58, 13);
            this.lblPostID.TabIndex = 0;
            this.lblPostID.Text = "文章ID：";
            // 
            // cmbPostID
            // 
            this.cmbPostID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPostID.FormattingEnabled = true;
            this.cmbPostID.Location = new System.Drawing.Point(100, 17);
            this.cmbPostID.Name = "cmbPostID";
            this.cmbPostID.Size = new System.Drawing.Size(200, 21);
            this.cmbPostID.TabIndex = 1;
            // 
            // lblParentCommentID
            // 
            this.lblParentCommentID.AutoSize = true;
            this.lblParentCommentID.Location = new System.Drawing.Point(12, 50);
            this.lblParentCommentID.Name = "lblParentCommentID";
            this.lblParentCommentID.Size = new System.Drawing.Size(82, 13);
            this.lblParentCommentID.TabIndex = 2;
            this.lblParentCommentID.Text = "父評論ID：";
            // 
            // cmbParentCommentID
            // 
            this.cmbParentCommentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParentCommentID.FormattingEnabled = true;
            this.cmbParentCommentID.Location = new System.Drawing.Point(100, 47);
            this.cmbParentCommentID.Name = "cmbParentCommentID";
            this.cmbParentCommentID.Size = new System.Drawing.Size(200, 21);
            this.cmbParentCommentID.TabIndex = 3;
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Location = new System.Drawing.Point(12, 80);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(58, 13);
            this.lblUID.TabIndex = 4;
            this.lblUID.Text = "用戶ID：";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(100, 77);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(200, 20);
            this.txtUID.TabIndex = 5;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(12, 110);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(58, 13);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = "評論內容：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(100, 107);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(300, 100);
            this.txtContent.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmCommentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.lblUID);
            this.Controls.Add(this.cmbParentCommentID);
            this.Controls.Add(this.lblParentCommentID);
            this.Controls.Add(this.cmbPostID);
            this.Controls.Add(this.lblPostID);
            this.Name = "FrmCommentDetail";
            this.Text = "評論詳情";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPostID;
        private System.Windows.Forms.ComboBox cmbPostID;
        private System.Windows.Forms.Label lblParentCommentID;
        private System.Windows.Forms.ComboBox cmbParentCommentID;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}