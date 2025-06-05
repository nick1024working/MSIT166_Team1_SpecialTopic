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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label target_amountLabel;
            System.Windows.Forms.Label current_amountLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label end_dateLabel;
            System.Windows.Forms.Label titleLabel1;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label donateProject_idLabel2;
            System.Windows.Forms.Label donateCategories_idLabel2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label donateProject_idLabel1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.donateCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamA_ProjectDataSet = new SpecialTopic.Fund.TeamA_ProjectDataSet();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dnCtComboBoxforPj = new System.Windows.Forms.ComboBox();
            this.donateProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnProject = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.CBSearchCategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTargetAmount = new System.Windows.Forms.TextBox();
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSearchByProject = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.CBSearchProject = new System.Windows.Forms.ComboBox();
            this.donatePlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPlans = new System.Windows.Forms.Button();
            this.txtPlanId = new System.Windows.Forms.TextBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.donateCategoriesTableAdapter = new SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donateCategoriesTableAdapter();
            this.tableAdapterManager = new SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.TableAdapterManager();
            this.donateProjectsTableAdapter = new SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donateProjectsTableAdapter();
            this.donatePlansTableAdapter = new SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donatePlansTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            target_amountLabel = new System.Windows.Forms.Label();
            current_amountLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            end_dateLabel = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            donateProject_idLabel2 = new System.Windows.Forms.Label();
            donateCategories_idLabel2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            donateProject_idLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamA_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donatePlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("華康新特圓體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            nameLabel.Location = new System.Drawing.Point(562, 609);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(217, 43);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "類別名稱:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            titleLabel.Location = new System.Drawing.Point(28, 105);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(94, 32);
            titleLabel.TabIndex = 17;
            titleLabel.Text = "標題:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            descriptionLabel.Location = new System.Drawing.Point(28, 188);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(94, 32);
            descriptionLabel.TabIndex = 19;
            descriptionLabel.Text = "說明:";
            // 
            // target_amountLabel
            // 
            target_amountLabel.AutoSize = true;
            target_amountLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            target_amountLabel.Location = new System.Drawing.Point(28, 455);
            target_amountLabel.Name = "target_amountLabel";
            target_amountLabel.Size = new System.Drawing.Size(158, 32);
            target_amountLabel.TabIndex = 21;
            target_amountLabel.Text = "目標金額:";
            // 
            // current_amountLabel
            // 
            current_amountLabel.AutoSize = true;
            current_amountLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            current_amountLabel.Location = new System.Drawing.Point(28, 366);
            current_amountLabel.Name = "current_amountLabel";
            current_amountLabel.Size = new System.Drawing.Size(158, 32);
            current_amountLabel.TabIndex = 23;
            current_amountLabel.Text = "目前金額:";
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            start_dateLabel.Location = new System.Drawing.Point(28, 553);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(158, 32);
            start_dateLabel.TabIndex = 25;
            start_dateLabel.Text = "開始日期:";
            // 
            // end_dateLabel
            // 
            end_dateLabel.AutoSize = true;
            end_dateLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            end_dateLabel.Location = new System.Drawing.Point(28, 649);
            end_dateLabel.Name = "end_dateLabel";
            end_dateLabel.Size = new System.Drawing.Size(158, 32);
            end_dateLabel.TabIndex = 27;
            end_dateLabel.Text = "結束日期:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            titleLabel1.Location = new System.Drawing.Point(21, 214);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(158, 32);
            titleLabel1.TabIndex = 3;
            titleLabel1.Text = "方案名稱:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            priceLabel.Location = new System.Drawing.Point(21, 274);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(94, 32);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "金額:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            descriptionLabel1.Location = new System.Drawing.Point(21, 335);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(94, 32);
            descriptionLabel1.TabIndex = 6;
            descriptionLabel1.Text = "說明:";
            // 
            // donateProject_idLabel2
            // 
            donateProject_idLabel2.AutoSize = true;
            donateProject_idLabel2.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateProject_idLabel2.Location = new System.Drawing.Point(21, 154);
            donateProject_idLabel2.Name = "donateProject_idLabel2";
            donateProject_idLabel2.Size = new System.Drawing.Size(158, 32);
            donateProject_idLabel2.TabIndex = 17;
            donateProject_idLabel2.Text = "募資項目:";
            // 
            // donateCategories_idLabel2
            // 
            donateCategories_idLabel2.AutoSize = true;
            donateCategories_idLabel2.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateCategories_idLabel2.Location = new System.Drawing.Point(28, 277);
            donateCategories_idLabel2.Name = "donateCategories_idLabel2";
            donateCategories_idLabel2.Size = new System.Drawing.Size(158, 32);
            donateCategories_idLabel2.TabIndex = 35;
            donateCategories_idLabel2.Text = "所屬類別:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(35, 124);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(366, 32);
            label5.TabIndex = 10;
            label5.Text = "(donateCaategories_id)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("華康新特圓體", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(613, 349);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(298, 29);
            label6.TabIndex = 37;
            label6.Text = "(donateProjects_id)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("華康新特圓體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label7.ForeColor = System.Drawing.Color.Red;
            label7.Location = new System.Drawing.Point(647, 417);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(236, 27);
            label7.TabIndex = 38;
            label7.Text = "(donatePlans_id)";
            // 
            // donateProject_idLabel1
            // 
            donateProject_idLabel1.AutoSize = true;
            donateProject_idLabel1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateProject_idLabel1.Location = new System.Drawing.Point(348, 27);
            donateProject_idLabel1.Name = "donateProject_idLabel1";
            donateProject_idLabel1.Size = new System.Drawing.Size(254, 32);
            donateProject_idLabel1.TabIndex = 38;
            donateProject_idLabel1.Text = "依募資項目搜尋:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("華康新特明體(P)", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1672, 1096);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnRead);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(nameLabel);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("華康新特明體(P)", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(8, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1656, 1046);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "募資分類";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRead.Image = global::SpecialTopic.Properties.Resources.重整1;
            this.btnRead.Location = new System.Drawing.Point(1123, 156);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(80, 80);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "重整";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(126, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 64);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(860, 695);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 64);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(608, 695);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 64);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateCategoriesBindingSource, "donateCategories_id", true));
            this.txtId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtId.ForeColor = System.Drawing.Color.Silver;
            this.txtId.Location = new System.Drawing.Point(56, 72);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(324, 46);
            this.txtId.TabIndex = 3;
            this.txtId.Text = "輸入預刪除類別id...";
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
            this.txtName.Location = new System.Drawing.Point(785, 606);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 50);
            this.txtName.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(557, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 38;
            this.dataGridView1.Size = new System.Drawing.Size(546, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康新特圓體", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(585, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "募資分類管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(donateCategories_idLabel2);
            this.tabPage2.Controls.Add(this.dnCtComboBoxforPj);
            this.tabPage2.Controls.Add(this.btnProject);
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
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("華康新特明體(P)", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(8, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1656, 1046);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "募資項目";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dnCtComboBoxforPj
            // 
            this.dnCtComboBoxforPj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "donateCategories_id", true));
            this.dnCtComboBoxforPj.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dnCtComboBoxforPj.FormattingEnabled = true;
            this.dnCtComboBoxforPj.Location = new System.Drawing.Point(197, 274);
            this.dnCtComboBoxforPj.Name = "dnCtComboBoxforPj";
            this.dnCtComboBoxforPj.Size = new System.Drawing.Size(295, 40);
            this.dnCtComboBoxforPj.TabIndex = 36;
            // 
            // donateProjectsBindingSource
            // 
            this.donateProjectsBindingSource.DataMember = "donateProjects";
            this.donateProjectsBindingSource.DataSource = this.teamA_ProjectDataSet;
            // 
            // btnProject
            // 
            this.btnProject.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProject.Image = global::SpecialTopic.Properties.Resources.重整1;
            this.btnProject.Location = new System.Drawing.Point(1570, 26);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(80, 80);
            this.btnProject.TabIndex = 35;
            this.btnProject.Text = "重整";
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(10, 67);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 82;
            this.dataGridView4.RowTemplate.Height = 38;
            this.dataGridView4.Size = new System.Drawing.Size(1113, 195);
            this.dataGridView4.TabIndex = 34;
            // 
            // CBSearchCategory
            // 
            this.CBSearchCategory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.CBSearchCategory.Location = new System.Drawing.Point(1001, 18);
            this.CBSearchCategory.Name = "CBSearchCategory";
            this.CBSearchCategory.Size = new System.Drawing.Size(122, 43);
            this.CBSearchCategory.TabIndex = 33;
            this.CBSearchCategory.Text = "搜尋";
            this.CBSearchCategory.UseVisualStyleBackColor = true;
            this.CBSearchCategory.Click += new System.EventHandler(this.CategoriesSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(580, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "依類別搜尋:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(776, 18);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(212, 40);
            this.comboBoxCategory.TabIndex = 31;
            // 
            // txtProjectId
            // 
            this.txtProjectId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "donateProject_id", true));
            this.txtProjectId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProjectId.ForeColor = System.Drawing.Color.Silver;
            this.txtProjectId.Location = new System.Drawing.Point(638, 276);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(312, 46);
            this.txtProjectId.TabIndex = 30;
            this.txtProjectId.Text = "輸入預刪除項目id...";
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "title", true));
            this.txtTitle.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTitle.Location = new System.Drawing.Point(197, 102);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(295, 39);
            this.txtTitle.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "description", true));
            this.txtDescription.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(197, 185);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(295, 39);
            this.txtDescription.TabIndex = 20;
            // 
            // txtTargetAmount
            // 
            this.txtTargetAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "target_amount", true));
            this.txtTargetAmount.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTargetAmount.Location = new System.Drawing.Point(197, 452);
            this.txtTargetAmount.Name = "txtTargetAmount";
            this.txtTargetAmount.Size = new System.Drawing.Size(295, 39);
            this.txtTargetAmount.TabIndex = 22;
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "current_amount", true));
            this.txtCurrentAmount.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentAmount.Location = new System.Drawing.Point(197, 363);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.Size = new System.Drawing.Size(295, 39);
            this.txtCurrentAmount.TabIndex = 24;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donateProjectsBindingSource, "start_date", true));
            this.dtpStartDate.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStartDate.Location = new System.Drawing.Point(197, 549);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(295, 39);
            this.dtpStartDate.TabIndex = 26;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donateProjectsBindingSource, "end_date", true));
            this.dtpEndDate.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEndDate.Location = new System.Drawing.Point(197, 645);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(295, 39);
            this.dtpEndDate.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(969, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "刪除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PjDelete_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(272, 716);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 54);
            this.button3.TabIndex = 11;
            this.button3.Text = "更新";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PjUpdate_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(89, 716);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 54);
            this.button4.TabIndex = 10;
            this.button4.Text = "新增";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PjCreate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(522, 112);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 38;
            this.dataGridView2.Size = new System.Drawing.Size(1128, 519);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("華康新特圓體", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(544, -121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "募資項目管理";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.btnPlans);
            this.tabPage3.Controls.Add(donateProject_idLabel2);
            this.tabPage3.Controls.Add(this.comboBoxProject);
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
            this.tabPage3.Font = new System.Drawing.Font("華康新特明體(P)", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(8, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1656, 1046);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "募資方案";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSearchByProject
            // 
            this.btnSearchByProject.Font = new System.Drawing.Font("新細明體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchByProject.Location = new System.Drawing.Point(977, 21);
            this.btnSearchByProject.Name = "btnSearchByProject";
            this.btnSearchByProject.Size = new System.Drawing.Size(133, 43);
            this.btnSearchByProject.TabIndex = 41;
            this.btnSearchByProject.Text = "搜尋";
            this.btnSearchByProject.UseVisualStyleBackColor = true;
            this.btnSearchByProject.Click += new System.EventHandler(this.btnSearchByProject_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(23, 85);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 82;
            this.dataGridView5.RowTemplate.Height = 38;
            this.dataGridView5.Size = new System.Drawing.Size(1089, 265);
            this.dataGridView5.TabIndex = 40;
            // 
            // CBSearchProject
            // 
            this.CBSearchProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "donateProject_id", true));
            this.CBSearchProject.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBSearchProject.FormattingEnabled = true;
            this.CBSearchProject.Location = new System.Drawing.Point(608, 24);
            this.CBSearchProject.Name = "CBSearchProject";
            this.CBSearchProject.Size = new System.Drawing.Size(347, 40);
            this.CBSearchProject.TabIndex = 39;
            // 
            // donatePlansBindingSource
            // 
            this.donatePlansBindingSource.DataMember = "donatePlans";
            this.donatePlansBindingSource.DataSource = this.teamA_ProjectDataSet;
            // 
            // btnPlans
            // 
            this.btnPlans.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlans.Image = global::SpecialTopic.Properties.Resources.重整1;
            this.btnPlans.Location = new System.Drawing.Point(1570, 57);
            this.btnPlans.Name = "btnPlans";
            this.btnPlans.Size = new System.Drawing.Size(80, 80);
            this.btnPlans.TabIndex = 36;
            this.btnPlans.Text = "重整";
            this.btnPlans.UseVisualStyleBackColor = true;
            this.btnPlans.Click += new System.EventHandler(this.btnPlans_Click);
            // 
            // txtPlanId
            // 
            this.txtPlanId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "donatePlan_id", true));
            this.txtPlanId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPlanId.ForeColor = System.Drawing.Color.Silver;
            this.txtPlanId.Location = new System.Drawing.Point(596, 375);
            this.txtPlanId.Name = "txtPlanId";
            this.txtPlanId.Size = new System.Drawing.Size(339, 46);
            this.txtPlanId.TabIndex = 19;
            this.txtPlanId.Text = "輸入預刪除方案id...";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "donateProject_id", true));
            this.comboBoxProject.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(190, 151);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(333, 40);
            this.comboBoxProject.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(963, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 54);
            this.button6.TabIndex = 16;
            this.button6.Text = "刪除";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PlDelete_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(307, 393);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 68);
            this.button7.TabIndex = 15;
            this.button7.Text = "更新";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PlUpdate_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(86, 393);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 68);
            this.button8.TabIndex = 14;
            this.button8.Text = "新增";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PlCreate_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.descriptionTextBox.Location = new System.Drawing.Point(188, 328);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(333, 39);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "price", true));
            this.txtPrice.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(188, 271);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(333, 39);
            this.txtPrice.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "title", true));
            this.titleTextBox.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleTextBox.Location = new System.Drawing.Point(188, 211);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(333, 39);
            this.titleTextBox.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(545, 143);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 38;
            this.dataGridView3.Size = new System.Drawing.Size(1105, 294);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("華康新特圓體", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(633, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "募資方案管理";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(8, 42);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1656, 1046);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "donateImages";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.UpdateOrder = SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(1147, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 257);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtProjectId);
            this.panel2.Controls.Add(this.comboBoxCategory);
            this.panel2.Controls.Add(this.CBSearchCategory);
            this.panel2.Controls.Add(this.dataGridView4);
            this.panel2.Location = new System.Drawing.Point(519, 649);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 344);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(donateProject_idLabel1);
            this.panel3.Controls.Add(this.btnSearchByProject);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.dataGridView5);
            this.panel3.Controls.Add(this.txtPlanId);
            this.panel3.Controls.Add(label7);
            this.panel3.Controls.Add(this.CBSearchProject);
            this.panel3.Location = new System.Drawing.Point(522, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 470);
            this.panel3.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("華康新特圓體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 37);
            this.label8.TabIndex = 42;
            this.label8.Text = "刪除資料";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("華康新特圓體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(13, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 37);
            this.label9.TabIndex = 43;
            this.label9.Text = "刪除資料";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("華康新特圓體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(11, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 37);
            this.label10.TabIndex = 43;
            this.label10.Text = "刪除資料";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donatePlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private SpecialTopic.Fund.TeamA_ProjectDataSet teamA_ProjectDataSet;
        private System.Windows.Forms.BindingSource donateCategoriesBindingSource;
        private SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donateCategoriesTableAdapter donateCategoriesTableAdapter;
        private SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
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
        private SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donateProjectsTableAdapter donateProjectsTableAdapter;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource donatePlansBindingSource;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donatePlansTableAdapter donatePlansTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtPlanId;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button CBSearchCategory;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnPlans;
        private System.Windows.Forms.ComboBox dnCtComboBoxforPj;
        private System.Windows.Forms.Button btnSearchByProject;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.ComboBox CBSearchProject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
    }
}
