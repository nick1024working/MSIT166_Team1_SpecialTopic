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
using System.Text.RegularExpressions;

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
                string.IsNullOrEmpty(address))

            {
                MessageBox.Show("請填寫所有欄位");
                return;
            }


            if (!ValidatePhone(phone)) return;
            if (!ValidatePassword(password)) return;
            if (!ValidateName(name)) return;
            if (!ValidateEmail(email)) return;
            if (!ValidateAddress(address)) return;

            // 所有驗證通過，執行註冊
            RegisterUser(phone, password, email, name, address, gender, birthday);
        }

      

    
       // 驗證電話號碼：十碼且開頭為09
       
        private bool ValidatePhone(string phone)
        {
            if (phone.Length != 10 || !phone.StartsWith("09"))
            {
                MessageBox.Show("請輸入正確電話號碼");
                return false;
            }

            // 檢查是否全為數字
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("請輸入正確電話號碼");
                return false;
            }

            return true;
        }

     
        // 驗證密碼：至少5碼
        private bool ValidatePassword(string password)
        {
            if (password.Length < 5)
            {
                MessageBox.Show("至少五碼");
                return false;
            }
            return true;
        }

      // 驗證姓名：必須是中文字，不可有英文

        private bool ValidateName(string name)
        {
            // 檢查是否包含英文字母
            if (Regex.IsMatch(name, @"[a-zA-Z]"))
            {
                MessageBox.Show("請填入中文全名");
                return false;
            }

            // 檢查是否為中文字符
            if (!Regex.IsMatch(name, @"^[\u4e00-\u9fa5]+$"))
            {
                MessageBox.Show("請填入中文全名");
                return false;
            }

            return true;
        }

       
        // 驗證Email：必須包含@
       
        private bool ValidateEmail(string email)
        {
            if (!email.Contains("@"))
            {
                MessageBox.Show("填入正確EMAIL");
                return false;
            }
            return true;
        }

        
        // 驗證地址：必須是中文可有數字，不可只有數字，中文須六個字以上
       
        private bool ValidateAddress(string address)
        {
            // 統計中文字符數量
            int chineseCount = 0;
            foreach (char c in address)
            {
                if (c >= 0x4e00 && c <= 0x9fa5) // 中文字符範圍
                {
                    chineseCount++;
                }
            }

            // 檢查中文字數是否足夠
            if (chineseCount < 6)
            {
                MessageBox.Show("錯誤的地址規格");
                return false;
            }

            // 檢查是否只有數字（不允許）
            if (Regex.IsMatch(address, @"^\d+$"))
            {
                MessageBox.Show("錯誤的地址規格");
                return false;
            }

            // 檢查是否包含非中文非數字字符（如英文）
            if (Regex.IsMatch(address, @"[a-zA-Z]"))
            {
                MessageBox.Show("錯誤的地址規格");
                return false;
            }

            return true;
        }

     


        // 執行使用者註冊

        private void RegisterUser(string phone, string password, string email, string name, string address, bool gender, DateTime birthday)
        {


            string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True;";
            string sql = "INSERT INTO Users (Phone, Password, Email, Name, Address, Gender, Birthday,AuthorStatus) " +
                 "VALUES (@Phone, @Password, @Email, @Name, @Address ,@Gender, @Birthday, @AuthorStatus)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Gender", gender);
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
            catch (Exception ex)
            {
                MessageBox.Show($"資料庫連線失敗，請檢查連線設定\n錯誤訊息:{ex.Message}");
            }

        }
    }
}

 