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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.teamA_ProjectDataSet = new SpecialTopic.TeamA_ProjectDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new SpecialTopic.TeamA_ProjectDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new SpecialTopic.TeamA_ProjectDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.teamA_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "電話；";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "密碼：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "地址；";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-mail：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "生日；";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(359, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 26);
            this.listBox1.TabIndex = 1;
            // 
            // teamA_ProjectDataSet
            // 
            this.teamA_ProjectDataSet.DataSetName = "TeamA_ProjectDataSet";
            this.teamA_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.teamA_ProjectDataSet;
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
            this.tableAdapterManager.UpdateOrder = SpecialTopic.TeamA_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsedBookImagesTableAdapter = null;
            this.tableAdapterManager.UsedBookOrdersTableAdapter = null;
            this.tableAdapterManager.UsedBookSaleTagsTableAdapter = null;
            this.tableAdapterManager.UsedBooksTableAdapter = null;
            this.tableAdapterManager.UsedBookTopicsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.UserTrackedUsedBooksTableAdapter = null;
            // 
            // MemberUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MemberUserRegister";
            this.Size = new System.Drawing.Size(1384, 961);
            this.Load += new System.EventHandler(this.MemberUserRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamA_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private TeamA_ProjectDataSet teamA_ProjectDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private TeamA_ProjectDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private TeamA_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
