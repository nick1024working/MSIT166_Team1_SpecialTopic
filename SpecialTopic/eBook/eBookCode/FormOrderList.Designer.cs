namespace SpecialTopic.eBook.eBookCode
{
    partial class FormOrderList
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

        #region Windows Form 設計工具產生的程式碼
        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.lblTotalDetail = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDSOD = new System.Windows.Forms.Button();
            this.comboBoxUID = new System.Windows.Forms.ComboBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(26, 26);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 29;
            this.dgvOrders.Size = new System.Drawing.Size(638, 159);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(26, 230);
            this.dgvOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 29;
            this.dgvOrderDetails.Size = new System.Drawing.Size(638, 142);
            this.dgvOrderDetails.TabIndex = 1;
            this.dgvOrderDetails.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderDetails_CellMouseClick);
            // 
            // lblTotalDetail
            // 
            this.lblTotalDetail.AutoSize = true;
            this.lblTotalDetail.Location = new System.Drawing.Point(24, 391);
            this.lblTotalDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDetail.Name = "lblTotalDetail";
            this.lblTotalDetail.Size = new System.Drawing.Size(68, 12);
            this.lblTotalDetail.TabIndex = 3;
            this.lblTotalDetail.Text = "本訂單總計:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(701, 421);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(70, 23);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "儲存變更";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDSOD
            // 
            this.btnDSOD.Location = new System.Drawing.Point(590, 421);
            this.btnDSOD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDSOD.Name = "btnDSOD";
            this.btnDSOD.Size = new System.Drawing.Size(92, 23);
            this.btnDSOD.TabIndex = 5;
            this.btnDSOD.Text = "刪除選中明細";
            this.btnDSOD.UseVisualStyleBackColor = true;
            this.btnDSOD.Click += new System.EventHandler(this.btnDSOD_Click);
            // 
            // comboBoxUID
            // 
            this.comboBoxUID.FormattingEnabled = true;
            this.comboBoxUID.Location = new System.Drawing.Point(237, 423);
            this.comboBoxUID.Name = "comboBoxUID";
            this.comboBoxUID.Size = new System.Drawing.Size(121, 20);
            this.comboBoxUID.TabIndex = 6;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(396, 421);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.Text = "新增主訂單";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(485, 423);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(86, 21);
            this.btnDeleteOrder.TabIndex = 8;
            this.btnDeleteOrder.Text = "刪除1主訂單";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.comboBoxUID);
            this.Controls.Add(this.btnDSOD);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblTotalDetail);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.dgvOrders);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOrderList";
            this.Text = "訂單管理";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label lblTotalDetail;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDSOD;
        private System.Windows.Forms.ComboBox comboBoxUID;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
    }
}