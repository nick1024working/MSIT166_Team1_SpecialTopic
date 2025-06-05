namespace SpecialTopic
{
    partial class MemberUserRegister
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label uIDLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label registerDateLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label levelLabel;
            this.uIDTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.registerDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowseAvatar = new System.Windows.Forms.Button();
            this.btnDeleteAvatar = new System.Windows.Forms.Button();
            this.btnSaveAvatar = new System.Windows.Forms.Button();
            this.labelGenderText = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamA_ProjectDataSet = new SpecialTopic.Member.TeamA_ProjectDataSet();
            this.usersTableAdapter = new SpecialTopic.Member.TeamA_ProjectDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new SpecialTopic.Member.TeamA_ProjectDataSetTableAdapters.TableAdapterManager();
            this.loginLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginLogsTableAdapter = new SpecialTopic.Member.TeamA_ProjectDataSetTableAdapters.LoginLogsTableAdapter();
            uIDLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            registerDateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamA_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uIDLabel
            // 
            uIDLabel.AutoSize = true;
            uIDLabel.Location = new System.Drawing.Point(257, 151);
            uIDLabel.Name = "uIDLabel";
            uIDLabel.Size = new System.Drawing.Size(50, 22);
            uIDLabel.TabIndex = 0;
            uIDLabel.Text = "UID:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(257, 203);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(60, 22);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "電話:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(257, 255);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 22);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "姓名:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(257, 307);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(70, 22);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(257, 361);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 22);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "性別:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(257, 405);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(60, 22);
            birthdayLabel.TabIndex = 12;
            birthdayLabel.Text = "生日:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(257, 457);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(60, 22);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "地址:";
            // 
            // registerDateLabel
            // 
            registerDateLabel.AutoSize = true;
            registerDateLabel.Location = new System.Drawing.Point(257, 509);
            registerDateLabel.Name = "registerDateLabel";
            registerDateLabel.Size = new System.Drawing.Size(100, 22);
            registerDateLabel.TabIndex = 16;
            registerDateLabel.Text = "註冊日期:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(257, 561);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(100, 22);
            statusLabel.TabIndex = 20;
            statusLabel.Text = "會員狀態:";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(257, 613);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(90, 22);
            levelLabel.TabIndex = 22;
            levelLabel.Text = "論壇等級";
            // 
            // uIDTextBox
            // 
            this.uIDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UID", true));
            this.uIDTextBox.Location = new System.Drawing.Point(369, 148);
            this.uIDTextBox.Name = "uIDTextBox";
            this.uIDTextBox.ReadOnly = true;
            this.uIDTextBox.Size = new System.Drawing.Size(347, 30);
            this.uIDTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(369, 200);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(347, 30);
            this.phoneTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(369, 252);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(347, 30);
            this.nameTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(369, 304);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(347, 30);
            this.emailTextBox.TabIndex = 9;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Enabled = false;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(369, 402);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(347, 30);
            this.birthdayDateTimePicker.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(369, 454);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(347, 30);
            this.addressTextBox.TabIndex = 15;
            // 
            // registerDateDateTimePicker
            // 
            this.registerDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "RegisterDate", true));
            this.registerDateDateTimePicker.Enabled = false;
            this.registerDateDateTimePicker.Location = new System.Drawing.Point(369, 506);
            this.registerDateDateTimePicker.Name = "registerDateDateTimePicker";
            this.registerDateDateTimePicker.Size = new System.Drawing.Size(347, 30);
            this.registerDateDateTimePicker.TabIndex = 17;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(369, 558);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(347, 30);
            this.statusTextBox.TabIndex = 21;
            // 
            // levelTextBox
            // 
            this.levelTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.levelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Level", true));
            this.levelTextBox.Location = new System.Drawing.Point(369, 610);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.ReadOnly = true;
            this.levelTextBox.Size = new System.Drawing.Size(347, 30);
            this.levelTextBox.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(739, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowseAvatar
            // 
            this.btnBrowseAvatar.Location = new System.Drawing.Point(1033, 121);
            this.btnBrowseAvatar.Name = "btnBrowseAvatar";
            this.btnBrowseAvatar.Size = new System.Drawing.Size(137, 38);
            this.btnBrowseAvatar.TabIndex = 32;
            this.btnBrowseAvatar.Text = "上傳大頭貼";
            this.btnBrowseAvatar.UseVisualStyleBackColor = true;
            this.btnBrowseAvatar.Click += new System.EventHandler(this.btnBrowseAvatar_Click);
            // 
            // btnDeleteAvatar
            // 
            this.btnDeleteAvatar.Location = new System.Drawing.Point(1033, 279);
            this.btnDeleteAvatar.Name = "btnDeleteAvatar";
            this.btnDeleteAvatar.Size = new System.Drawing.Size(137, 38);
            this.btnDeleteAvatar.TabIndex = 33;
            this.btnDeleteAvatar.Text = "刪除大頭貼";
            this.btnDeleteAvatar.UseVisualStyleBackColor = true;
            this.btnDeleteAvatar.Click += new System.EventHandler(this.btnDeleteAvatar_Click);
            // 
            // btnSaveAvatar
            // 
            this.btnSaveAvatar.Location = new System.Drawing.Point(1033, 200);
            this.btnSaveAvatar.Name = "btnSaveAvatar";
            this.btnSaveAvatar.Size = new System.Drawing.Size(137, 38);
            this.btnSaveAvatar.TabIndex = 34;
            this.btnSaveAvatar.Text = "保存大頭貼";
            this.btnSaveAvatar.UseVisualStyleBackColor = true;
            this.btnSaveAvatar.Click += new System.EventHandler(this.btnSaveAvatar_Click);
            // 
            // labelGenderText
            // 
            this.labelGenderText.AutoSize = true;
            this.labelGenderText.Location = new System.Drawing.Point(365, 361);
            this.labelGenderText.Name = "labelGenderText";
            this.labelGenderText.Size = new System.Drawing.Size(70, 22);
            this.labelGenderText.TabIndex = 35;
            this.labelGenderText.Text = "label1";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.teamA_ProjectDataSet;
            // 
            // teamA_ProjectDataSet
            // 
            this.teamA_ProjectDataSet.DataSetName = "TeamA_ProjectDataSet";
            this.teamA_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTopicsTableAdapter = null;
            this.tableAdapterManager.donateCategoriesTableAdapter = null;
            this.tableAdapterManager.donateImagesTableAdapter = null;
            this.tableAdapterManager.donateOrderItemsTableAdapter = null;
            this.tableAdapterManager.donateOrdersTableAdapter = null;
            this.tableAdapterManager.donatePlansTableAdapter = null;
            this.tableAdapterManager.donateProjectsTableAdapter = null;
            this.tableAdapterManager.eBookMainTableTableAdapter = null;
            this.tableAdapterManager.ebookOrderDetailTableAdapter = null;
            this.tableAdapterManager.ebookOrderMainTableAdapter = null;
            this.tableAdapterManager.ebookPurchasedTableAdapter = null;
            this.tableAdapterManager.ebookRecommendTableAdapter = null;
            this.tableAdapterManager.ForumPostsTableAdapter = null;
            this.tableAdapterManager.LoginLogsTableAdapter = null;
            this.tableAdapterManager.OrderFaceToFaceStatusesTableAdapter = null;
            this.tableAdapterManager.OrderStatusesTableAdapter = null;
            this.tableAdapterManager.PostBookmarksTableAdapter = null;
            this.tableAdapterManager.PostCategoryTableAdapter = null;
            this.tableAdapterManager.PostCommentsTableAdapter = null;
            this.tableAdapterManager.PostFilterTableAdapter = null;
            this.tableAdapterManager.PostImagesTableAdapter = null;
            this.tableAdapterManager.PostLikesTableAdapter = null;
            this.tableAdapterManager.SaleTagsTableAdapter = null;
            this.tableAdapterManager.SubscriberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SpecialTopic.Member.TeamA_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsedBookImagesTableAdapter = null;
            this.tableAdapterManager.UsedBookOrdersTableAdapter = null;
            this.tableAdapterManager.UsedBookSaleTagsTableAdapter = null;
            this.tableAdapterManager.UsedBooksTableAdapter = null;
            this.tableAdapterManager.UsedBookTopicsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.UserTrackedUsedBooksTableAdapter = null;
            // 
            // loginLogsBindingSource
            // 
            this.loginLogsBindingSource.DataMember = "LoginLogs";
            this.loginLogsBindingSource.DataSource = this.teamA_ProjectDataSet;
            // 
            // loginLogsTableAdapter
            // 
            this.loginLogsTableAdapter.ClearBeforeFill = true;
            // 
            // MemberUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.labelGenderText);
            this.Controls.Add(this.btnSaveAvatar);
            this.Controls.Add(this.btnDeleteAvatar);
            this.Controls.Add(this.btnBrowseAvatar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(uIDLabel);
            this.Controls.Add(this.uIDTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(registerDateLabel);
            this.Controls.Add(this.registerDateDateTimePicker);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(levelLabel);
            this.Controls.Add(this.levelTextBox);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MemberUserRegister";
            this.Size = new System.Drawing.Size(1384, 961);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamA_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SpecialTopic.Member.TeamA_ProjectDataSet teamA_ProjectDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private SpecialTopic.Member.TeamA_ProjectDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private SpecialTopic.Member.TeamA_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource loginLogsBindingSource;
        private Member.TeamA_ProjectDataSetTableAdapters.LoginLogsTableAdapter loginLogsTableAdapter;
        private System.Windows.Forms.TextBox uIDTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker registerDateDateTimePicker;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowseAvatar;
        private System.Windows.Forms.Button btnDeleteAvatar;
        private System.Windows.Forms.Button btnSaveAvatar;
        private System.Windows.Forms.Label labelGenderText;
    }
}
