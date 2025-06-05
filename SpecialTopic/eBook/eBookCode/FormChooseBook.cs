using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialTopic.eBook.eBookCode
{
    public partial class FormChooseBook : Form
    {
        public long SelectedBookID { get; private set; }
        public string SelectedBookName { get; private set; }
        public decimal SelectedPrice { get; private set; }
        public FormChooseBook()
        {
            InitializeComponent();
            LoadBookList();   // 載入電子書清單
        }

        private void LoadBookList()
        {
            string sql = "SELECT ebookID, ebookName, fixedPrice FROM eBookMainTable";

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // 讀出書名、ID、價格
                        long id = Convert.ToInt64(reader["ebookID"]);
                        string name = reader["ebookName"].ToString();
                        // ✅ 安全轉型 decimal，避免 DBNull 錯誤
                        decimal price = reader["fixedPrice"] != DBNull.Value
                            ? Convert.ToDecimal(reader["fixedPrice"])
                            : 0;

                        // 建立自訂的項目類別，顯示書名 (ID)，但實際包含更多資訊
                        var item = new ComboBoxItem($"{name} ({id})", id, name, price);
                        comboBoxBooks.Items.Add(item);
                    }
                }
            }
        }

        // ✅ 使用者按下確定時取出 ComboBox 的值
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboBoxBooks.SelectedItem is ComboBoxItem selected)
            {
                SelectedBookID = selected.ID;
                SelectedBookName = selected.Name;
                SelectedPrice = selected.Price;
                DialogResult = DialogResult.OK; // 回傳 OK 讓呼叫者知道成功選擇
                Close();
            }
            else
            {
                MessageBox.Show("請先選擇一本電子書！");
            }

        }

        // ✅ 自訂的 ComboBox 顯示項目物件，儲存書名、ID、價格
        private class ComboBoxItem
        {
            public string Display { get; }
            public long ID { get; }
            public string Name { get; }
            public decimal Price { get; }

            public ComboBoxItem(string display, long id, string name, decimal price)
            {
                Display = display;
                ID = id;
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return Display; // ComboBox 顯示內容用這個
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // ✅ 傳回取消狀態給呼叫者
            Close(); // ✅ 關閉表單
        }
    }
}
