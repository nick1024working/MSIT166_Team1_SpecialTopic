namespace SpecialTopic.UsedBooks.Frontend.Views.Body
{
    partial class UserCenterBody
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lbxFunctions = new System.Windows.Forms.ListBox();
            this.pnlContentArea = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pnlSidebar);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlContentArea);
            this.splitContainer2.Size = new System.Drawing.Size(1946, 1066);
            this.splitContainer2.SplitterDistance = 203;
            this.splitContainer2.SplitterWidth = 9;
            this.splitContainer2.TabIndex = 5;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoSize = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSidebar.Controls.Add(this.lbxFunctions);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnlSidebar.MaximumSize = new System.Drawing.Size(650, 0);
            this.pnlSidebar.MinimumSize = new System.Drawing.Size(217, 400);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(217, 1064);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lbxFunctions
            // 
            this.lbxFunctions.BackColor = System.Drawing.SystemColors.Control;
            this.lbxFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxFunctions.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxFunctions.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbxFunctions.FormattingEnabled = true;
            this.lbxFunctions.ItemHeight = 38;
            this.lbxFunctions.Items.AddRange(new object[] {
            "管理書本",
            "管理訂單",
            "追蹤清單"});
            this.lbxFunctions.Location = new System.Drawing.Point(0, 0);
            this.lbxFunctions.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lbxFunctions.Name = "lbxFunctions";
            this.lbxFunctions.Size = new System.Drawing.Size(217, 1064);
            this.lbxFunctions.TabIndex = 3;
            this.lbxFunctions.SelectedIndexChanged += new System.EventHandler(this.lbxFunctions_SelectedIndexChanged);
            // 
            // pnlContentArea
            // 
            this.pnlContentArea.AutoSize = true;
            this.pnlContentArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentArea.Location = new System.Drawing.Point(0, 0);
            this.pnlContentArea.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnlContentArea.Name = "pnlContentArea";
            this.pnlContentArea.Size = new System.Drawing.Size(1732, 1064);
            this.pnlContentArea.TabIndex = 1;
            // 
            // UserCenterBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserCenterBody";
            this.Size = new System.Drawing.Size(1946, 1066);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.ListBox lbxFunctions;
        private System.Windows.Forms.Panel pnlContentArea;
    }
}
