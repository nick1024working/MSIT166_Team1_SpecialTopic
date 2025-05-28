namespace SpecialTopic
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Fund = new System.Windows.Forms.Button();
            this.Ebook = new System.Windows.Forms.Button();
            this.Book = new System.Windows.Forms.Button();
            this.Forum = new System.Windows.Forms.Button();
            this.Member = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fund);
            this.panel1.Controls.Add(this.Ebook);
            this.panel1.Controls.Add(this.Book);
            this.panel1.Controls.Add(this.Forum);
            this.panel1.Controls.Add(this.Member);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 961);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "線上書城";
            // 
            // Fund
            // 
            this.Fund.BackColor = System.Drawing.Color.Snow;
            this.Fund.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.Fund.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Fund.Location = new System.Drawing.Point(3, 525);
            this.Fund.Name = "Fund";
            this.Fund.Size = new System.Drawing.Size(192, 68);
            this.Fund.TabIndex = 4;
            this.Fund.Text = "募資";
            this.Fund.UseVisualStyleBackColor = false;
            this.Fund.Click += new System.EventHandler(this.Fund_Click);
            // 
            // Ebook
            // 
            this.Ebook.BackColor = System.Drawing.Color.Snow;
            this.Ebook.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.Ebook.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Ebook.Location = new System.Drawing.Point(3, 424);
            this.Ebook.Name = "Ebook";
            this.Ebook.Size = new System.Drawing.Size(192, 68);
            this.Ebook.TabIndex = 3;
            this.Ebook.Text = "電子書專區";
            this.Ebook.UseVisualStyleBackColor = false;
            this.Ebook.Click += new System.EventHandler(this.Ebook_Click);
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.Color.Snow;
            this.Book.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.Book.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Book.Location = new System.Drawing.Point(3, 323);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(192, 68);
            this.Book.TabIndex = 2;
            this.Book.Text = "二手書交流";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Forum
            // 
            this.Forum.BackColor = System.Drawing.Color.Snow;
            this.Forum.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.Forum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Forum.Location = new System.Drawing.Point(3, 222);
            this.Forum.Name = "Forum";
            this.Forum.Size = new System.Drawing.Size(192, 68);
            this.Forum.TabIndex = 1;
            this.Forum.Text = "論壇";
            this.Forum.UseVisualStyleBackColor = false;
            this.Forum.Click += new System.EventHandler(this.Forum_Click);
            // 
            // Member
            // 
            this.Member.BackColor = System.Drawing.Color.Snow;
            this.Member.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Member.Location = new System.Drawing.Point(3, 121);
            this.Member.Name = "Member";
            this.Member.Size = new System.Drawing.Size(192, 68);
            this.Member.TabIndex = 0;
            this.Member.Text = "會員專區";
            this.Member.UseVisualStyleBackColor = false;
            this.Member.Click += new System.EventHandler(this.Member_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.GhostWhite;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1384, 961);
            this.panelMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 961);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Fund;
        private System.Windows.Forms.Button Ebook;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Button Forum;
        private System.Windows.Forms.Button Member;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
    }
}

