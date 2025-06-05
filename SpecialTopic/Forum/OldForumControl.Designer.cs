namespace SpecialTopic
{
    partial class OldForumControl
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
            this.linkMember = new System.Windows.Forms.LinkLabel();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkForget = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelHotBoards = new System.Windows.Forms.Label();
            this.flowHotTopics = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupChat = new System.Windows.Forms.GroupBox();
            this.flowChat = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupNovel = new System.Windows.Forms.GroupBox();
            this.flowNovel = new System.Windows.Forms.FlowLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.flowHotTopics.SuspendLayout();
            this.groupChat.SuspendLayout();
            this.flowChat.SuspendLayout();
            this.groupNovel.SuspendLayout();
            this.flowNovel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(81, 19);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "論壇首頁";
            // 
            // linkMember
            // 
            this.linkMember.AutoSize = true;
            this.linkMember.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMember.Location = new System.Drawing.Point(126, 20);
            this.linkMember.Name = "linkMember";
            this.linkMember.Size = new System.Drawing.Size(81, 19);
            this.linkMember.TabIndex = 1;
            this.linkMember.TabStop = true;
            this.linkMember.Text = "會員專區";
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHelp.Location = new System.Drawing.Point(213, 20);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(45, 19);
            this.linkHelp.TabIndex = 2;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "贊助";
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.Location = new System.Drawing.Point(264, 20);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(45, 19);
            this.linkRegister.TabIndex = 3;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "註冊";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccount.Location = new System.Drawing.Point(389, 20);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(45, 19);
            this.labelAccount.TabIndex = 4;
            this.labelAccount.Text = "帳號";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(389, 50);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 19);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "密碼";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(440, 20);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 22);
            this.txtAccount.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(440, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(550, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 29);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "登入";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkForget
            // 
            this.linkForget.AutoSize = true;
            this.linkForget.Location = new System.Drawing.Point(550, 50);
            this.linkForget.Name = "linkForget";
            this.linkForget.Size = new System.Drawing.Size(65, 12);
            this.linkForget.TabIndex = 9;
            this.linkForget.TabStop = true;
            this.linkForget.Text = "忘記密碼？";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(200, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 22);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(510, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelHotBoards
            // 
            this.labelHotBoards.AutoSize = true;
            this.labelHotBoards.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotBoards.Location = new System.Drawing.Point(30, 130);
            this.labelHotBoards.Name = "labelHotBoards";
            this.labelHotBoards.Size = new System.Drawing.Size(81, 19);
            this.labelHotBoards.TabIndex = 12;
            this.labelHotBoards.Text = "熱門版塊";
            // 
            // flowHotTopics
            // 
            this.flowHotTopics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowHotTopics.Controls.Add(this.button1);
            this.flowHotTopics.Controls.Add(this.button2);
            this.flowHotTopics.Controls.Add(this.button3);
            this.flowHotTopics.Controls.Add(this.button4);
            this.flowHotTopics.Location = new System.Drawing.Point(30, 150);
            this.flowHotTopics.Name = "flowHotTopics";
            this.flowHotTopics.Size = new System.Drawing.Size(600, 100);
            this.flowHotTopics.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 86);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 86);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 86);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupChat
            // 
            this.groupChat.AutoSize = true;
            this.groupChat.Controls.Add(this.flowChat);
            this.groupChat.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupChat.Location = new System.Drawing.Point(30, 270);
            this.groupChat.Name = "groupChat";
            this.groupChat.Size = new System.Drawing.Size(250, 200);
            this.groupChat.TabIndex = 14;
            this.groupChat.TabStop = false;
            this.groupChat.Text = "休閒聊天";
            // 
            // flowChat
            // 
            this.flowChat.Controls.Add(this.button5);
            this.flowChat.Controls.Add(this.button6);
            this.flowChat.Controls.Add(this.button7);
            this.flowChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowChat.Location = new System.Drawing.Point(3, 22);
            this.flowChat.Name = "flowChat";
            this.flowChat.Size = new System.Drawing.Size(244, 175);
            this.flowChat.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(238, 47);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(238, 47);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(238, 47);
            this.button7.TabIndex = 2;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupNovel
            // 
            this.groupNovel.AutoSize = true;
            this.groupNovel.Controls.Add(this.flowNovel);
            this.groupNovel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNovel.Location = new System.Drawing.Point(320, 270);
            this.groupNovel.Name = "groupNovel";
            this.groupNovel.Size = new System.Drawing.Size(250, 200);
            this.groupNovel.TabIndex = 15;
            this.groupNovel.TabStop = false;
            this.groupNovel.Text = "長篇小說";
            // 
            // flowNovel
            // 
            this.flowNovel.Controls.Add(this.button8);
            this.flowNovel.Controls.Add(this.button9);
            this.flowNovel.Controls.Add(this.button10);
            this.flowNovel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNovel.Location = new System.Drawing.Point(3, 22);
            this.flowNovel.Name = "flowNovel";
            this.flowNovel.Size = new System.Drawing.Size(244, 175);
            this.flowNovel.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(238, 47);
            this.button8.TabIndex = 0;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 56);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(238, 47);
            this.button9.TabIndex = 1;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 109);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(238, 47);
            this.button10.TabIndex = 2;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // ForumControl
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.linkMember);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkForget);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelHotBoards);
            this.Controls.Add(this.flowHotTopics);
            this.Controls.Add(this.groupChat);
            this.Controls.Add(this.groupNovel);
            this.Name = "ForumControl";
            this.Size = new System.Drawing.Size(700, 500);
            this.flowHotTopics.ResumeLayout(false);
            this.groupChat.ResumeLayout(false);
            this.flowChat.ResumeLayout(false);
            this.groupNovel.ResumeLayout(false);
            this.flowNovel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.LinkLabel linkMember;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkForget;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelHotBoards;
        private System.Windows.Forms.FlowLayoutPanel flowHotTopics;
        private System.Windows.Forms.GroupBox groupChat;
        private System.Windows.Forms.FlowLayoutPanel flowChat;
        private System.Windows.Forms.GroupBox groupNovel;
        private System.Windows.Forms.FlowLayoutPanel flowNovel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}
