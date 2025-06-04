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
    public partial class FRMCreateAccount : Form
    {
        public FRMCreateAccount()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string phone = textBoxPhone.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string name = textBoxName.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            bool gender = rbMale.Checked;
            DateTime birthday = dateTimePickerBirthday.Value;
            if (string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(address) )
               
            {
                MessageBox.Show("請填寫所有欄位");
                return;
            }
            string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True;";
            string sql = "INSERT INTO Users (Phone, Password, Email, Name, Address, Gender, Birthday,AuthorStatus) " +
                 "VALUES (@Phone, @Password, @Email, @Name, @Address ,@Gender, @Birthday, @AuthorStatus)";
            try
            {
                using(SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Gender",gender);
                        cmd.Parameters.AddWithValue("@Birthday", birthday);
                        cmd.Parameters.AddWithValue("@AuthorStatus", 0);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("註冊成功");
                            this.Close(); // 關閉註冊視窗
                        }
                        else
                        {
                            MessageBox.Show("註冊失敗，請稍後再試");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"資料庫連線失敗，請檢查連線設定\n錯誤訊息:{ex.Message}");
            }


        }
    }
}
