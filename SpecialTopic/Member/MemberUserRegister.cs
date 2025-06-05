using SpecialTopic.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpecialTopic;



namespace SpecialTopic
{
    public partial class MemberUserRegister : UserControl
    {
        private Form1 _mainForm;
        private string _loginPhone;

        public MemberUserRegister()
        {
            InitializeComponent();
        }
        public MemberUserRegister(string phone)
        {
            InitializeComponent();
            LoadMemberData(phone);
        }


        public MemberUserRegister(Form1 mainForm, string loginPhone) : this()
        {
            _mainForm = mainForm;
            _loginPhone = loginPhone;
        }
        public void loadPhoneDefault(string sss)
        {
            LoadMemberData(sss);
        }

        public MemberUserRegister(Form1 mainForm) : this()
        {
            _mainForm = mainForm;
        }

        private void MemberUserRegister_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(_loginPhone))

            {
                LoadMemberData(_loginPhone);
            }
        }

        private void LoadMemberData(string phone)
        {
            try
            {
                this.usersTableAdapter.FillByPhone(this.teamA_ProjectDataSet.Users, phone);

                if (this.teamA_ProjectDataSet.Users.Rows.Count > 0)
                {
                    int status =
                        this.teamA_ProjectDataSet.Users[0].IsStatusNull() ? -1 :
                        this.teamA_ProjectDataSet.Users[0].Status;

                    string statusText = "";
                    switch (status)
                    {
                        case 0:
                            statusText = "停權";
                            break;
                        case 1:
                            statusText = "一般會員";
                            break;
                        case 2:
                            statusText = "黑名單";
                            break;
                        default:
                            statusText = "未知狀態";
                            break;
                    }
                    statusTextBox.Text = statusText;

                    //以下性別顯示
                    object genderObj = this.teamA_ProjectDataSet.Users[0]["Gender"];
                    int gender = (genderObj == DBNull.Value) ? -1 : Convert.ToInt32(genderObj);

                    string genderText = "";
                    switch (gender)
                    {
                        case 0:
                            genderText = "男";
                            break;
                        case 1:
                            genderText = "女";
                            break;
                        default:
                            genderText = "未知";
                            break;
                    }
                    labelGenderText.Text = genderText;

                    string avatar =
                        this.teamA_ProjectDataSet.Users[0].IsAvatarUrlNull() ? "" :
                        this.teamA_ProjectDataSet.Users[0].AvatarUrl;
                    pictureBox1.ImageLocation = avatar;
                    MessageBox.Show("資料載入成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤 " + ex.Message);
            }
        }
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);

        }

        private void btnBrowseAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                // 更新資料庫中的圖片路徑
                this.teamA_ProjectDataSet.Users[0].AvatarUrl = ofd.FileName;
            }
        }

        private void btnDeleteAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.teamA_ProjectDataSet.Users.Rows.Count > 0)
                {
                    this.teamA_ProjectDataSet.Users[0].AvatarUrl = "";
                    pictureBox1.ImageLocation = null;
                    this.Validate();
                    this.usersBindingSource.EndEdit();

                    this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);
                    MessageBox.Show("大頭貼已刪除");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除失敗 " + ex.Message);
            }
        }

        private void btnSaveAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.teamA_ProjectDataSet.Users.Rows.Count > 0)
                {
                    this.teamA_ProjectDataSet.Users[0].AvatarUrl = pictureBox1.ImageLocation;
                    this.Validate();
                    this.usersBindingSource.EndEdit();

                    this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);
                    MessageBox.Show("大頭貼已儲存");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗 " + ex.Message);
            }
        }
    }
}
