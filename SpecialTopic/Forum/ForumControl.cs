using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialTopic
{
    public partial class ForumControl : UserControl
    {
        public ForumControl()
        {
            InitializeComponent();
        }
        Form1 form1 = new Form1();
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string account = txtAccount.Text;
            string password = txtPassword.Text;

            using (SqlConnection conn = new SqlConnection("你的連線字串"))
            {
                conn.Open();
                string sql = "SELECT * FROM Members WHERE Account = @account AND Password = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("登入成功");
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤");
                }
            }
        }

        //public void Testing (Form1 mainForm):this()
        //{
        //    this.mainForm = mainForm;
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassword.Text;

            MessageBox.Show($"你輸入的帳號是：{account}\n密碼是：{password}", "登入資訊");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("請輸入搜尋關鍵字！");
                return;
            }

            // 顯示搜尋視窗
            FrmForumSearch frmSearch = new FrmForumSearch(keyword); // 傳入關鍵字
            frmSearch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var board = new ForumBoardControl(); // 例如 1 是「聊天室」
            this.Controls.Clear();
            this.Controls.Add(board);
        }
    }
}
