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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void ShowControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void Member_Click(object sender, EventArgs e)
        {
            ShowControl(new MemberUserRegister(this));
        }

        private void Forum_Click(object sender, EventArgs e)
        {
            ShowControl(new ForumControl());
        }

        private void Book_Click(object sender, EventArgs e)
        {
            ShowControl(new UsedBookControl());
        }

        private void Ebook_Click(object sender, EventArgs e)
        {
            ShowControl(new EBookControl());
        }

        private void Fund_Click(object sender, EventArgs e)
        {
            ShowControl(new FundControl());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
