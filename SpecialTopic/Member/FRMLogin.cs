using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SpecialTopic
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string password = txtPassword.Text.Trim();
            string coonStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(coonStr))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE Phone=@Phone AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Phone", account);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("登入成功");
                        this.Hide();
                        Form1 frm = new Form1();
                        frm.s = account; // 傳遞帳號到主窗體
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("帳號或密碼錯誤");
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMCreateAccount create = new FRMCreateAccount();
            create.Show();
        }
    }
}
