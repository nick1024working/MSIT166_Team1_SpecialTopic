namespace SpecialTopic
{
    partial class OldForumBoardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelNotice = new System.Windows.Forms.Panel();
            this.labelNotice = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnRepost = new System.Windows.Forms.Button();
            this.btnDiscuss = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.flowPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPagination = new System.Windows.Forms.Label();
            this.panelNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "論壇版塊";
            // 
            // panelNotice
            // 
            this.panelNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotice.Controls.Add(this.labelNotice);
            this.panelNotice.Location = new System.Drawing.Point(30, 80);
            this.panelNotice.Name = "panelNotice";
            this.panelNotice.Size = new System.Drawing.Size(808, 80);
            this.panelNotice.TabIndex = 1;
            // 
            // labelNotice
            // 
            this.labelNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNotice.Location = new System.Drawing.Point(0, 0);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(806, 78);
            this.labelNotice.TabIndex = 0;
            this.labelNotice.Text = "公告/版規";
            this.labelNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(30, 170);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "全部";
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(100, 170);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnOriginal.TabIndex = 3;
            this.btnOriginal.Text = "原創";
            // 
            // btnRepost
            // 
            this.btnRepost.Location = new System.Drawing.Point(170, 170);
            this.btnRepost.Name = "btnRepost";
            this.btnRepost.Size = new System.Drawing.Size(75, 23);
            this.btnRepost.TabIndex = 4;
            this.btnRepost.Text = "轉載";
            // 
            // btnDiscuss
            // 
            this.btnDiscuss.Location = new System.Drawing.Point(240, 170);
            this.btnDiscuss.Name = "btnDiscuss";
            this.btnDiscuss.Size = new System.Drawing.Size(75, 23);
            this.btnDiscuss.TabIndex = 5;
            this.btnDiscuss.Text = "討論";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(530, 170);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "發表";
            // 
            // flowPosts
            // 
            this.flowPosts.AutoScroll = true;
            this.flowPosts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPosts.Location = new System.Drawing.Point(30, 210);
            this.flowPosts.Name = "flowPosts";
            this.flowPosts.Size = new System.Drawing.Size(808, 349);
            this.flowPosts.TabIndex = 7;
            this.flowPosts.WrapContents = false;
            // 
            // labelPagination
            // 
            this.labelPagination.Location = new System.Drawing.Point(364, 562);
            this.labelPagination.Name = "labelPagination";
            this.labelPagination.Size = new System.Drawing.Size(100, 23);
            this.labelPagination.TabIndex = 8;
            this.labelPagination.Text = "1 2 3 4 5 6 ...";
            // 
            // OldForumBoardControl
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelNotice);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.btnRepost);
            this.Controls.Add(this.btnDiscuss);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.flowPosts);
            this.Controls.Add(this.labelPagination);
            this.Name = "OldForumBoardControl";
            this.Size = new System.Drawing.Size(884, 647);
            this.panelNotice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelNotice;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnRepost;
        private System.Windows.Forms.Button btnDiscuss;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.FlowLayoutPanel flowPosts;
        private System.Windows.Forms.Label labelPagination;
    }
}
