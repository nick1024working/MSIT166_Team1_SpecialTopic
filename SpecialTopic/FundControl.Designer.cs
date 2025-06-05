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
            System.Windows.Forms.Label donateImage_urlLabel;
            System.Windows.Forms.Label donateProject_idLabel;
            System.Windows.Forms.Label is_mainLabel;
            System.Windows.Forms.Label donateProject_idLabel3;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.donateCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamA_ProjectDataSet = new SpecialTopic.Fund.TeamA_ProjectDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.donateProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.CBSearchCategory = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dnCtComboBoxforPj = new System.Windows.Forms.ComboBox();
            this.btnProject = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTargetAmount = new System.Windows.Forms.TextBox();
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchByProject = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.txtPlanId = new System.Windows.Forms.TextBox();
            this.donatePlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CBSearchProject = new System.Windows.Forms.ComboBox();
            this.btnPlans = new System.Windows.Forms.Button();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearchByProjectImg = new System.Windows.Forms.Button();
            this.donateProject_idComboBox1 = new System.Windows.Forms.ComboBox();
            this.donateImagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.donateImage_urlTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnReadImages = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnUpdateImage = new System.Windows.Forms.Button();
            this.btnCreateImage = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.is_mainCheckBox = new System.Windows.Forms.CheckBox();
            this.donateProject_idComboBox = new System.Windows.Forms.ComboBox();
            this.image_idTextBox = new System.Windows.Forms.TextBox();
            this.donateCategoriesTableAdapter = new SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donateCategoriesTableAdapter();
            this.tableAdapterManager = new SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.TableAdapterManager();
            this.donateProjectsTableAdapter = new SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donateProjectsTableAdapter();
            this.donatePlansTableAdapter = new SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donatePlansTableAdapter();
            this.donateImagesTableAdapter = new SpecialTopic.Fund.TeamA_ProjectDataSetTableAdapters.donateImagesTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
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
            donateImage_urlLabel = new System.Windows.Forms.Label();
            donateProject_idLabel = new System.Windows.Forms.Label();
            is_mainLabel = new System.Windows.Forms.Label();
            donateProject_idLabel3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamA_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donatePlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donateImagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("華康新特圓體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            nameLabel.Location = new System.Drawing.Point(225, 230);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(217, 43);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "類別名稱:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            titleLabel.Location = new System.Drawing.Point(28, 86);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(94, 32);
            titleLabel.TabIndex = 17;
            titleLabel.Text = "標題:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            descriptionLabel.Location = new System.Drawing.Point(28, 169);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(94, 32);
            descriptionLabel.TabIndex = 19;
            descriptionLabel.Text = "說明:";
            // 
            // target_amountLabel
            // 
            target_amountLabel.AutoSize = true;
            target_amountLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            target_amountLabel.Location = new System.Drawing.Point(28, 436);
            target_amountLabel.Name = "target_amountLabel";
            target_amountLabel.Size = new System.Drawing.Size(158, 32);
            target_amountLabel.TabIndex = 21;
            target_amountLabel.Text = "目標金額:";
            // 
            // current_amountLabel
            // 
            current_amountLabel.AutoSize = true;
            current_amountLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            current_amountLabel.Location = new System.Drawing.Point(28, 347);
            current_amountLabel.Name = "current_amountLabel";
            current_amountLabel.Size = new System.Drawing.Size(158, 32);
            current_amountLabel.TabIndex = 23;
            current_amountLabel.Text = "目前金額:";
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            start_dateLabel.Location = new System.Drawing.Point(28, 534);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(158, 32);
            start_dateLabel.TabIndex = 25;
            start_dateLabel.Text = "開始日期:";
            // 
            // end_dateLabel
            // 
            end_dateLabel.AutoSize = true;
            end_dateLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            end_dateLabel.Location = new System.Drawing.Point(28, 630);
            end_dateLabel.Name = "end_dateLabel";
            end_dateLabel.Size = new System.Drawing.Size(158, 32);
            end_dateLabel.TabIndex = 27;
            end_dateLabel.Text = "結束日期:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            titleLabel1.Location = new System.Drawing.Point(5, 214);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(158, 32);
            titleLabel1.TabIndex = 3;
            titleLabel1.Text = "方案名稱:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            priceLabel.Location = new System.Drawing.Point(5, 274);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(94, 32);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "金額:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            descriptionLabel1.Location = new System.Drawing.Point(5, 335);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(94, 32);
            descriptionLabel1.TabIndex = 6;
            descriptionLabel1.Text = "說明:";
            // 
            // donateProject_idLabel2
            // 
            donateProject_idLabel2.AutoSize = true;
            donateProject_idLabel2.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateProject_idLabel2.Location = new System.Drawing.Point(5, 154);
            donateProject_idLabel2.Name = "donateProject_idLabel2";
            donateProject_idLabel2.Size = new System.Drawing.Size(158, 32);
            donateProject_idLabel2.TabIndex = 17;
            donateProject_idLabel2.Text = "募資項目:";
            // 
            // donateCategories_idLabel2
            // 
            donateCategories_idLabel2.AutoSize = true;
            donateCategories_idLabel2.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateCategories_idLabel2.Location = new System.Drawing.Point(28, 258);
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
            label5.Location = new System.Drawing.Point(36, 160);
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
            label6.Location = new System.Drawing.Point(648, 327);
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
            label7.Location = new System.Drawing.Point(647, 424);
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
            // donateImage_urlLabel
            // 
            donateImage_urlLabel.AutoSize = true;
            donateImage_urlLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateImage_urlLabel.Location = new System.Drawing.Point(38, 237);
            donateImage_urlLabel.Name = "donateImage_urlLabel";
            donateImage_urlLabel.Size = new System.Drawing.Size(158, 32);
            donateImage_urlLabel.TabIndex = 4;
            donateImage_urlLabel.Text = "圖片連結:";
            // 
            // donateProject_idLabel
            // 
            donateProject_idLabel.AutoSize = true;
            donateProject_idLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateProject_idLabel.Location = new System.Drawing.Point(38, 170);
            donateProject_idLabel.Name = "donateProject_idLabel";
            donateProject_idLabel.Size = new System.Drawing.Size(158, 32);
            donateProject_idLabel.TabIndex = 5;
            donateProject_idLabel.Text = "募資項目:";
            // 
            // is_mainLabel
            // 
            is_mainLabel.AutoSize = true;
            is_mainLabel.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            is_mainLabel.Location = new System.Drawing.Point(6, 338);
            is_mainLabel.Name = "is_mainLabel";
            is_mainLabel.Size = new System.Drawing.Size(190, 32);
            is_mainLabel.TabIndex = 6;
            is_mainLabel.Text = "是否為主圖:";
            // 
            // donateProject_idLabel3
            // 
            donateProject_idLabel3.AutoSize = true;
            donateProject_idLabel3.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            donateProject_idLabel3.Location = new System.Drawing.Point(288, 25);
            donateProject_idLabel3.Name = "donateProject_idLabel3";
            donateProject_idLabel3.Size = new System.Drawing.Size(254, 32);
            donateProject_idLabel3.TabIndex = 16;
            donateProject_idLabel3.Text = "依募資項目搜尋:";
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
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnRead);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(273, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 330);
            this.panel1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(419, 37);
            this.label12.TabIndex = 44;
            this.label12.Text = "輸入預修改、刪除類別id";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateCategoriesBindingSource, "donateCategories_id", true));
            this.txtId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtId.ForeColor = System.Drawing.Color.Silver;
            this.txtId.Location = new System.Drawing.Point(57, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(324, 46);
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
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(13, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 64);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(236, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 64);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRead.Image = global::SpecialTopic.Properties.Resources.重整1;
            this.btnRead.Location = new System.Drawing.Point(1388, 230);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(80, 80);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "重整";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(393, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 64);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateCategoriesBindingSource, "name", true));
            this.txtName.Font = new System.Drawing.Font("華康新特圓體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(448, 227);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 50);
            this.txtName.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(822, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 38;
            this.dataGridView1.Size = new System.Drawing.Size(546, 515);
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
            this.tabPage2.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage2.Controls.Add(this.label11);
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
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("華康新特圓體", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(600, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(488, 75);
            this.label11.TabIndex = 39;
            this.label11.Text = "募資項目管理";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtProjectId);
            this.panel2.Controls.Add(this.comboBoxCategory);
            this.panel2.Controls.Add(this.CBSearchCategory);
            this.panel2.Controls.Add(this.dataGridView4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(508, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 391);
            this.panel2.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(419, 37);
            this.label10.TabIndex = 45;
            this.label10.Text = "輸入預修改、刪除項目id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(586, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "依類別搜尋:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(975, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "刪除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PjDelete_Click);
            // 
            // txtProjectId
            // 
            this.txtProjectId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "donateProject_id", true));
            this.txtProjectId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProjectId.ForeColor = System.Drawing.Color.Silver;
            this.txtProjectId.Location = new System.Drawing.Point(644, 276);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(312, 46);
            this.txtProjectId.TabIndex = 30;
            // 
            // donateProjectsBindingSource
            // 
            this.donateProjectsBindingSource.DataMember = "donateProjects";
            this.donateProjectsBindingSource.DataSource = this.teamA_ProjectDataSet;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(782, 18);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(212, 40);
            this.comboBoxCategory.TabIndex = 31;
            // 
            // CBSearchCategory
            // 
            this.CBSearchCategory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.CBSearchCategory.Location = new System.Drawing.Point(1007, 18);
            this.CBSearchCategory.Name = "CBSearchCategory";
            this.CBSearchCategory.Size = new System.Drawing.Size(122, 43);
            this.CBSearchCategory.TabIndex = 33;
            this.CBSearchCategory.Text = "搜尋";
            this.CBSearchCategory.UseVisualStyleBackColor = true;
            this.CBSearchCategory.Click += new System.EventHandler(this.CategoriesSearch_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(16, 67);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 82;
            this.dataGridView4.RowTemplate.Height = 38;
            this.dataGridView4.Size = new System.Drawing.Size(1113, 195);
            this.dataGridView4.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(975, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 54);
            this.button3.TabIndex = 11;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PjUpdate_Click);
            // 
            // dnCtComboBoxforPj
            // 
            this.dnCtComboBoxforPj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "donateCategories_id", true));
            this.dnCtComboBoxforPj.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dnCtComboBoxforPj.FormattingEnabled = true;
            this.dnCtComboBoxforPj.Location = new System.Drawing.Point(197, 255);
            this.dnCtComboBoxforPj.Name = "dnCtComboBoxforPj";
            this.dnCtComboBoxforPj.Size = new System.Drawing.Size(295, 40);
            this.dnCtComboBoxforPj.TabIndex = 36;
            // 
            // btnProject
            // 
            this.btnProject.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProject.Image = global::SpecialTopic.Properties.Resources.重整1;
            this.btnProject.Location = new System.Drawing.Point(1570, 7);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(80, 80);
            this.btnProject.TabIndex = 35;
            this.btnProject.Text = "重整";
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "title", true));
            this.txtTitle.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTitle.Location = new System.Drawing.Point(197, 83);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(295, 39);
            this.txtTitle.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "description", true));
            this.txtDescription.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(197, 166);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(295, 39);
            this.txtDescription.TabIndex = 20;
            // 
            // txtTargetAmount
            // 
            this.txtTargetAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "target_amount", true));
            this.txtTargetAmount.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTargetAmount.Location = new System.Drawing.Point(197, 433);
            this.txtTargetAmount.Name = "txtTargetAmount";
            this.txtTargetAmount.Size = new System.Drawing.Size(295, 39);
            this.txtTargetAmount.TabIndex = 22;
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateProjectsBindingSource, "current_amount", true));
            this.txtCurrentAmount.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentAmount.Location = new System.Drawing.Point(197, 344);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.Size = new System.Drawing.Size(295, 39);
            this.txtCurrentAmount.TabIndex = 24;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donateProjectsBindingSource, "start_date", true));
            this.dtpStartDate.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStartDate.Location = new System.Drawing.Point(197, 530);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(295, 39);
            this.dtpStartDate.TabIndex = 26;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donateProjectsBindingSource, "end_date", true));
            this.dtpEndDate.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEndDate.Location = new System.Drawing.Point(197, 626);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(295, 39);
            this.dtpEndDate.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(172, 697);
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
            this.dataGridView2.Location = new System.Drawing.Point(508, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 38;
            this.dataGridView2.Size = new System.Drawing.Size(1142, 434);
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
            this.tabPage3.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.btnPlans);
            this.tabPage3.Controls.Add(donateProject_idLabel2);
            this.tabPage3.Controls.Add(this.comboBoxProject);
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(donateProject_idLabel1);
            this.panel3.Controls.Add(this.btnSearchByProject);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.dataGridView5);
            this.panel3.Controls.Add(this.txtPlanId);
            this.panel3.Controls.Add(label7);
            this.panel3.Controls.Add(this.CBSearchProject);
            this.panel3.Location = new System.Drawing.Point(522, 470);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 489);
            this.panel3.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(419, 37);
            this.label8.TabIndex = 46;
            this.label8.Text = "輸入預修改、刪除方案id";
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
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(959, 424);
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
            this.button7.Location = new System.Drawing.Point(959, 363);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 54);
            this.button7.TabIndex = 15;
            this.button7.Text = "修改";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PlUpdate_Click);
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
            // txtPlanId
            // 
            this.txtPlanId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "donatePlan_id", true));
            this.txtPlanId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPlanId.ForeColor = System.Drawing.Color.Silver;
            this.txtPlanId.Location = new System.Drawing.Point(596, 375);
            this.txtPlanId.Name = "txtPlanId";
            this.txtPlanId.Size = new System.Drawing.Size(339, 46);
            this.txtPlanId.TabIndex = 19;
            // 
            // donatePlansBindingSource
            // 
            this.donatePlansBindingSource.DataMember = "donatePlans";
            this.donatePlansBindingSource.DataSource = this.teamA_ProjectDataSet;
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
            // comboBoxProject
            // 
            this.comboBoxProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "donateProject_id", true));
            this.comboBoxProject.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(174, 151);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(333, 40);
            this.comboBoxProject.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(172, 402);
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
            this.descriptionTextBox.Location = new System.Drawing.Point(172, 328);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(333, 39);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "price", true));
            this.txtPrice.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(172, 271);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(333, 39);
            this.txtPrice.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donatePlansBindingSource, "title", true));
            this.titleTextBox.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleTextBox.Location = new System.Drawing.Point(172, 211);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(333, 39);
            this.titleTextBox.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(522, 151);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 38;
            this.dataGridView3.Size = new System.Drawing.Size(1128, 294);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("華康新特圓體", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(609, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = "募資方案管理";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.donateImage_urlTextBox);
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Controls.Add(this.btnReadImages);
            this.tabPage4.Controls.Add(this.btnCreateImage);
            this.tabPage4.Controls.Add(this.dataGridView6);
            this.tabPage4.Controls.Add(is_mainLabel);
            this.tabPage4.Controls.Add(this.is_mainCheckBox);
            this.tabPage4.Controls.Add(donateProject_idLabel);
            this.tabPage4.Controls.Add(this.donateProject_idComboBox);
            this.tabPage4.Controls.Add(donateImage_urlLabel);
            this.tabPage4.Location = new System.Drawing.Point(8, 42);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1656, 1046);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "募資圖片";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("華康新特圓體", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(585, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(488, 75);
            this.label9.TabIndex = 20;
            this.label9.Text = "募資圖片管理";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1030, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnSearchByProjectImg
            // 
            this.btnSearchByProjectImg.Location = new System.Drawing.Point(867, 22);
            this.btnSearchByProjectImg.Name = "btnSearchByProjectImg";
            this.btnSearchByProjectImg.Size = new System.Drawing.Size(127, 40);
            this.btnSearchByProjectImg.TabIndex = 18;
            this.btnSearchByProjectImg.Text = "搜尋";
            this.btnSearchByProjectImg.UseVisualStyleBackColor = true;
            this.btnSearchByProjectImg.Click += new System.EventHandler(this.btnSearchByProjectImg_Click);
            // 
            // donateProject_idComboBox1
            // 
            this.donateProject_idComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateImagesBindingSource, "donateProject_id", true));
            this.donateProject_idComboBox1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.donateProject_idComboBox1.FormattingEnabled = true;
            this.donateProject_idComboBox1.Location = new System.Drawing.Point(548, 22);
            this.donateProject_idComboBox1.Name = "donateProject_idComboBox1";
            this.donateProject_idComboBox1.Size = new System.Drawing.Size(303, 40);
            this.donateProject_idComboBox1.TabIndex = 17;
            // 
            // donateImagesBindingSource
            // 
            this.donateImagesBindingSource.DataMember = "donateImages";
            this.donateImagesBindingSource.DataSource = this.teamA_ProjectDataSet;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(49, 77);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 82;
            this.dataGridView7.RowTemplate.Height = 38;
            this.dataGridView7.Size = new System.Drawing.Size(945, 258);
            this.dataGridView7.TabIndex = 16;
            this.dataGridView7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView7_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(559, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // donateImage_urlTextBox
            // 
            this.donateImage_urlTextBox.Location = new System.Drawing.Point(44, 286);
            this.donateImage_urlTextBox.Name = "donateImage_urlTextBox";
            this.donateImage_urlTextBox.Size = new System.Drawing.Size(489, 34);
            this.donateImage_urlTextBox.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.Location = new System.Drawing.Point(202, 237);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 32);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "瀏覽...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnReadImages
            // 
            this.btnReadImages.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.btnReadImages.Location = new System.Drawing.Point(1543, 19);
            this.btnReadImages.Name = "btnReadImages";
            this.btnReadImages.Size = new System.Drawing.Size(80, 80);
            this.btnReadImages.TabIndex = 12;
            this.btnReadImages.Text = "重整";
            this.btnReadImages.UseVisualStyleBackColor = true;
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteImage.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteImage.Location = new System.Drawing.Point(767, 407);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(151, 45);
            this.btnDeleteImage.TabIndex = 11;
            this.btnDeleteImage.Text = "刪除";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateImage.Location = new System.Drawing.Point(767, 347);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(151, 45);
            this.btnUpdateImage.TabIndex = 10;
            this.btnUpdateImage.Text = "修改";
            this.btnUpdateImage.UseVisualStyleBackColor = true;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // btnCreateImage
            // 
            this.btnCreateImage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateImage.Location = new System.Drawing.Point(186, 415);
            this.btnCreateImage.Name = "btnCreateImage";
            this.btnCreateImage.Size = new System.Drawing.Size(207, 65);
            this.btnCreateImage.TabIndex = 9;
            this.btnCreateImage.Text = "新增";
            this.btnCreateImage.UseVisualStyleBackColor = true;
            this.btnCreateImage.Click += new System.EventHandler(this.btnCreateImage_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(861, 105);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 82;
            this.dataGridView6.RowTemplate.Height = 38;
            this.dataGridView6.Size = new System.Drawing.Size(762, 375);
            this.dataGridView6.TabIndex = 8;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // is_mainCheckBox
            // 
            this.is_mainCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.donateImagesBindingSource, "is_main", true));
            this.is_mainCheckBox.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.is_mainCheckBox.Location = new System.Drawing.Point(202, 321);
            this.is_mainCheckBox.Name = "is_mainCheckBox";
            this.is_mainCheckBox.Size = new System.Drawing.Size(28, 69);
            this.is_mainCheckBox.TabIndex = 7;
            this.is_mainCheckBox.UseVisualStyleBackColor = true;
            // 
            // donateProject_idComboBox
            // 
            this.donateProject_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateImagesBindingSource, "donateProject_id", true));
            this.donateProject_idComboBox.Font = new System.Drawing.Font("華康新特圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.donateProject_idComboBox.FormattingEnabled = true;
            this.donateProject_idComboBox.Location = new System.Drawing.Point(202, 167);
            this.donateProject_idComboBox.Name = "donateProject_idComboBox";
            this.donateProject_idComboBox.Size = new System.Drawing.Size(284, 40);
            this.donateProject_idComboBox.TabIndex = 6;
            // 
            // image_idTextBox
            // 
            this.image_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donateImagesBindingSource, "image_id", true));
            this.image_idTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.image_idTextBox.Location = new System.Drawing.Point(465, 357);
            this.image_idTextBox.Name = "image_idTextBox";
            this.image_idTextBox.Size = new System.Drawing.Size(284, 46);
            this.image_idTextBox.TabIndex = 1;
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
            // donateImagesTableAdapter
            // 
            this.donateImagesTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("華康新特明體(P)", 13.875F);
            this.label13.Location = new System.Drawing.Point(40, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(419, 37);
            this.label13.TabIndex = 47;
            this.label13.Text = "輸入預修改、刪除方案id";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.donateProject_idComboBox1);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.image_idTextBox);
            this.panel4.Controls.Add(this.btnUpdateImage);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.btnDeleteImage);
            this.panel4.Controls.Add(this.btnSearchByProjectImg);
            this.panel4.Controls.Add(this.dataGridView7);
            this.panel4.Controls.Add(donateProject_idLabel3);
            this.panel4.Location = new System.Drawing.Point(146, 503);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1352, 470);
            this.panel4.TabIndex = 48;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamA_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donatePlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donateImagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource donateImagesBindingSource;
        private System.Windows.Forms.TextBox image_idTextBox;
        private Fund.TeamA_ProjectDataSetTableAdapters.donateImagesTableAdapter donateImagesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.CheckBox is_mainCheckBox;
        private System.Windows.Forms.ComboBox donateProject_idComboBox;
        private System.Windows.Forms.Button btnReadImages;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnUpdateImage;
        private System.Windows.Forms.Button btnCreateImage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox donateImage_urlTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearchByProjectImg;
        private System.Windows.Forms.ComboBox donateProject_idComboBox1;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
    }
}
