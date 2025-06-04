namespace SpecialTopic
{
    partial class FundControl
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
            System.Windows.Forms.Label donateCategories_idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label target_amountLabel;
            System.Windows.Forms.Label current_amountLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label end_dateLabel;
            System.Windows.Forms.Label donateCategories_idLabel1;
            System.Windows.Forms.Label donateProject_idLabel;
            System.Windows.Forms.Label titleLabel1;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label donateProject_idLabel2;
            System.Windows.Forms.Label donatePlan_idLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.donateCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamA_ProjectDataSet = new SpecialTopic.TeamA_ProjectDataSet();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.donateProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTargetAmount = new System.Windows.Forms.TextBox();
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPlanId = new System.Windows.Forms.TextBox();
            this.donatePlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.donateCategoriesTableAdapter = new SpecialTopic.TeamA_ProjectDataSetTableAdapters.donateCategoriesTableAdapter();
            this.tableAdapterManager = new SpecialTopic.TeamA_ProjectDataSetTableAdapters.TableAdapterManager();
            this.donateProjectsTableAdapter = new SpecialTopic.TeamA_ProjectDataSetTableAdapters.donateProjectsTableAdapter();
            this.donatePlansTableAdapter = new SpecialTopic.TeamA_ProjectDataSetTableAdapters.donatePlansTableAdapter();
            donateCategories_idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            target_amountLabel = new System.Windows.Forms.Label();
            current_amountLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            end_dateLabel = new System.Windows.Forms.Label();
            donateCategories_idLabel1 = new System.Windows.Forms.Label();
            donateProject_idLabel = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            donateProject_idLabel2 = new System.Windows.Forms.Label();
            donatePlan_idLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamA_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donatePlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // donateCategories_idLabel
            // 
            donateCategories_idLabel.AutoSize = true;
            donateCategories_idLabel.Font = new System.Drawing.Font("華康新特圓體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateCategories_idLabel.Location = new System.Drawing.Point(593, 688);
            donateCategories_idLabel.Name = "donateCategories_idLabel";
            donateCategories_idLabel.Size = new System.Drawing.Size(173, 43);
            donateCategories_idLabel.TabIndex = 2;
            donateCategories_idLabel.Text = "類別ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("華康新特圓體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            nameLabel.Location = new System.Drawing.Point(549, 613);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(217, 43);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "類別名稱:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            titleLabel.Location = new System.Drawing.Point(32, 131);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(94, 32);
            titleLabel.TabIndex = 17;
            titleLabel.Text = "標題:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            descriptionLabel.Location = new System.Drawing.Point(32, 214);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(94, 32);
            descriptionLabel.TabIndex = 19;
            descriptionLabel.Text = "說明:";
            // 
            // target_amountLabel
            // 
            target_amountLabel.AutoSize = true;
            target_amountLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            target_amountLabel.Location = new System.Drawing.Point(32, 560);
            target_amountLabel.Name = "target_amountLabel";
            target_amountLabel.Size = new System.Drawing.Size(158, 32);
            target_amountLabel.TabIndex = 21;
            target_amountLabel.Text = "目標金額:";
            // 
            // current_amountLabel
            // 
            current_amountLabel.AutoSize = true;
            current_amountLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            current_amountLabel.Location = new System.Drawing.Point(32, 471);
            current_amountLabel.Name = "current_amountLabel";
            current_amountLabel.Size = new System.Drawing.Size(158, 32);
            current_amountLabel.TabIndex = 23;
            current_amountLabel.Text = "目前金額:";
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            start_dateLabel.Location = new System.Drawing.Point(32, 658);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(158, 32);
            start_dateLabel.TabIndex = 25;
            start_dateLabel.Text = "開始日期:";
            // 
            // end_dateLabel
            // 
            end_dateLabel.AutoSize = true;
            end_dateLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            end_dateLabel.Location = new System.Drawing.Point(32, 754);
            end_dateLabel.Name = "end_dateLabel";
            end_dateLabel.Size = new System.Drawing.Size(158, 32);
            end_dateLabel.TabIndex = 27;
            end_dateLabel.Text = "結束日期:";
            // 
            // donateCategories_idLabel1
            // 
            donateCategories_idLabel1.AutoSize = true;
            donateCategories_idLabel1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateCategories_idLabel1.Location = new System.Drawing.Point(32, 381);
            donateCategories_idLabel1.Name = "donateCategories_idLabel1";
            donateCategories_idLabel1.Size = new System.Drawing.Size(158, 32);
            donateCategories_idLabel1.TabIndex = 28;
            donateCategories_idLabel1.Text = "所屬類別:";
            // 
            // donateProject_idLabel
            // 
            donateProject_idLabel.AutoSize = true;
            donateProject_idLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateProject_idLabel.Location = new System.Drawing.Point(32, 294);
            donateProject_idLabel.Name = "donateProject_idLabel";
            donateProject_idLabel.Size = new System.Drawing.Size(126, 32);
            donateProject_idLabel.TabIndex = 29;
            donateProject_idLabel.Text = "募資id:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            titleLabel1.Location = new System.Drawing.Point(565, 605);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(158, 32);
            titleLabel1.TabIndex = 3;
            titleLabel1.Text = "方案名稱:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            priceLabel.Location = new System.Drawing.Point(565, 728);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(94, 32);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "金額:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            descriptionLabel1.Location = new System.Drawing.Point(565, 789);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(94, 32);
            descriptionLabel1.TabIndex = 6;
            descriptionLabel1.Text = "說明:";
            // 
            // donateProject_idLabel2
            // 
            donateProject_idLabel2.AutoSize = true;
            donateProject_idLabel2.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateProject_idLabel2.Location = new System.Drawing.Point(533, 668);
            donateProject_idLabel2.Name = "donateProject_idLabel2";
            donateProject_idLabel2.Size = new System.Drawing.Size(190, 32);
            donateProject_idLabel2.TabIndex = 17;
            donateProject_idLabel2.Text = "所屬募資id:";
            // 
            // donatePlan_idLabel
            // 
            donatePlan_idLabel.AutoSize = true;
            donatePlan_idLabel.Location = new System.Drawing.Point(1358, 50);
            donatePlan_idLabel.Name = "donatePlan_idLabel";
            donatePlan_idLabel.Size = new System.Drawing.Size(144, 24);
            donatePlan_idLabel.TabIndex = 18;
            donatePlan_idLabel.Text = "donate Plan id:";
            donatePlan_idLabel.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1672, 1096);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(donateCategories_idLabel);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(nameLabel);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1656, 1049);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "donateCategories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoad.Location = new System.Drawing.Point(1215, 790);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(256, 96);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "讀取";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(872, 790);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(256, 96);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(527, 790);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(256, 96);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(188, 790);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 96);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateCategoriesBindingSource, "donateCategories_id", true));
            this.txtId.Font = new System.Drawing.Font("華康新特圓體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtId.Location = new System.Drawing.Point(772, 685);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(298, 50);
            this.txtId.TabIndex = 3;
            // 
            // donateCategoriesBindingSource
            // 
            this.donateCategoriesBindingSource.DataMember = "donateCategories";
            this.donateCategoriesBindingSource.DataSource = this.teamA_ProjectDataSet;
            // 
            // teamA_ProjectDataSet
            // 
            this.teamA_ProjectDataSet.DataSetName = "TeamA_ProjectDataSet";
            this.teamA_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateCategoriesBindingSource, "name", true));
            this.txtName.Font = new System.Drawing.Font("華康新特圓體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(772, 610);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 50);
            this.txtName.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(625, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 38;
            this.dataGridView1.Size = new System.Drawing.Size(410, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康新特圓體", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(586, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "募資分類管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(donateProject_idLabel);
            this.tabPage2.Controls.Add(this.txtProjectId);
            this.tabPage2.Controls.Add(this.txtCategoryId);
            this.tabPage2.Controls.Add(donateCategories_idLabel1);
            this.tabPage2.Controls.Add(titleLabel);
            this.tabPage2.Controls.Add(this.txtTitle);
            this.tabPage2.Controls.Add(descriptionLabel);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(target_amountLabel);
            this.tabPage2.Controls.Add(this.txtTargetAmount);
            this.tabPage2.Controls.Add(current_amountLabel);
            this.tabPage2.Controls.Add(this.txtCurrentAmount);
            this.tabPage2.Controls.Add(start_dateLabel);
            this.tabPage2.Controls.Add(this.dtpStartDate);
            this.tabPage2.Controls.Add(end_dateLabel);
            this.tabPage2.Controls.Add(this.dtpEndDate);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1656, 1049);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "donateProjects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtProjectId
            // 
            this.txtProjectId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "donateProject_id", true));
            this.txtProjectId.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProjectId.Location = new System.Drawing.Point(201, 294);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(295, 39);
            this.txtProjectId.TabIndex = 30;
            // 
            // donateProjectsBindingSource
            // 
            this.donateProjectsBindingSource.DataMember = "donateProjects";
            this.donateProjectsBindingSource.DataSource = this.teamA_ProjectDataSet;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "donateCategories_id", true));
            this.txtCategoryId.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCategoryId.Location = new System.Drawing.Point(201, 378);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(295, 39);
            this.txtCategoryId.TabIndex = 29;
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "title", true));
            this.txtTitle.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTitle.Location = new System.Drawing.Point(201, 128);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(295, 39);
            this.txtTitle.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "description", true));
            this.txtDescription.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(201, 211);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(295, 39);
            this.txtDescription.TabIndex = 20;
            // 
            // txtTargetAmount
            // 
            this.txtTargetAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "target_amount", true));
            this.txtTargetAmount.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTargetAmount.Location = new System.Drawing.Point(201, 557);
            this.txtTargetAmount.Name = "txtTargetAmount";
            this.txtTargetAmount.Size = new System.Drawing.Size(295, 39);
            this.txtTargetAmount.TabIndex = 22;
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "current_amount", true));
            this.txtCurrentAmount.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentAmount.Location = new System.Drawing.Point(201, 468);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.Size = new System.Drawing.Size(295, 39);
            this.txtCurrentAmount.TabIndex = 24;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donateProjectsBindingSource, "start_date", true));
            this.dtpStartDate.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStartDate.Location = new System.Drawing.Point(201, 654);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(295, 39);
            this.dtpStartDate.TabIndex = 26;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donateProjectsBindingSource, "end_date", true));
            this.dtpEndDate.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEndDate.Location = new System.Drawing.Point(201, 750);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(295, 39);
            this.dtpEndDate.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(1196, 855);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 96);
            this.button1.TabIndex = 13;
            this.button1.Text = "讀取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PjRead_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(853, 855);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 96);
            this.button2.TabIndex = 12;
            this.button2.Text = "刪除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PjDelete_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(508, 855);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 96);
            this.button3.TabIndex = 11;
            this.button3.Text = "更新";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PjUpdate_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(169, 855);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(256, 96);
            this.button4.TabIndex = 10;
            this.button4.Text = "新增";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PjCreate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(522, 180);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 38;
            this.dataGridView2.Size = new System.Drawing.Size(1113, 606);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("華康新特圓體", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(580, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 75);
            this.label2.TabIndex = 2;
            this.label2.Text = "募資項目管理";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(donatePlan_idLabel);
            this.tabPage3.Controls.Add(this.txtPlanId);
            this.tabPage3.Controls.Add(donateProject_idLabel2);
            this.tabPage3.Controls.Add(this.comboBoxProject);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(descriptionLabel1);
            this.tabPage3.Controls.Add(this.descriptionTextBox);
            this.tabPage3.Controls.Add(priceLabel);
            this.tabPage3.Controls.Add(this.txtPrice);
            this.tabPage3.Controls.Add(titleLabel1);
            this.tabPage3.Controls.Add(this.titleTextBox);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1656, 1049);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "donatePlans";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtPlanId
            // 
            this.txtPlanId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "donatePlan_id", true));
            this.txtPlanId.Location = new System.Drawing.Point(1508, 47);
            this.txtPlanId.Name = "txtPlanId";
            this.txtPlanId.Size = new System.Drawing.Size(100, 36);
            this.txtPlanId.TabIndex = 19;
            this.txtPlanId.Visible = false;
            // 
            // donatePlansBindingSource
            // 
            this.donatePlansBindingSource.DataMember = "donatePlans";
            this.donatePlansBindingSource.DataSource = this.teamA_ProjectDataSet;
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "donateProject_id", true));
            this.comboBoxProject.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(732, 665);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(333, 40);
            this.comboBoxProject.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(1221, 849);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(256, 96);
            this.button5.TabIndex = 17;
            this.button5.Text = "讀取";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(878, 849);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(256, 96);
            this.button6.TabIndex = 16;
            this.button6.Text = "刪除";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PlDelete_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(533, 849);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(256, 96);
            this.button7.TabIndex = 15;
            this.button7.Text = "更新";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PlUpdate_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(194, 849);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(256, 96);
            this.button8.TabIndex = 14;
            this.button8.Text = "新增";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PlCreate_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.descriptionTextBox.Location = new System.Drawing.Point(732, 782);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(333, 39);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "price", true));
            this.txtPrice.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(732, 725);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(333, 39);
            this.txtPrice.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "title", true));
            this.titleTextBox.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleTextBox.Location = new System.Drawing.Point(732, 602);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(333, 39);
            this.titleTextBox.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(75, 178);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 38;
            this.dataGridView3.Size = new System.Drawing.Size(1502, 398);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("華康新特圓體", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(577, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = "募資方案管理";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // donateCategoriesTableAdapter
            // 
            this.donateCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTopicsTableAdapter = null;
            this.tableAdapterManager.donateCategoriesTableAdapter = this.donateCategoriesTableAdapter;
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
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.UserTrackedUsedBooksTableAdapter = null;
            // 
            // donateProjectsTableAdapter
            // 
            this.donateProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // donatePlansTableAdapter
            // 
            this.donatePlansTableAdapter.ClearBeforeFill = true;
            // 
            // FundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FundControl";
            this.Size = new System.Drawing.Size(1672, 1096);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamA_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donatePlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private TeamA_ProjectDataSet teamA_ProjectDataSet;
        private System.Windows.Forms.BindingSource donateCategoriesBindingSource;
        private TeamA_ProjectDataSetTableAdapters.donateCategoriesTableAdapter donateCategoriesTableAdapter;
        private TeamA_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.BindingSource donateProjectsBindingSource;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTargetAmount;
        private System.Windows.Forms.TextBox txtCurrentAmount;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private TeamA_ProjectDataSetTableAdapters.donateProjectsTableAdapter donateProjectsTableAdapter;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource donatePlansBindingSource;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private TeamA_ProjectDataSetTableAdapters.donatePlansTableAdapter donatePlansTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtPlanId;
    }
}
