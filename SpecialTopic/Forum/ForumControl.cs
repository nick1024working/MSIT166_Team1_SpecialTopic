using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialTopic.Forum
{
    public partial class ForumControl : UserControl
    {
        public ForumControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var board = new ForumPostControl(); // 例如 1 是「聊天室」
            this.Controls.Clear();
            this.Controls.Add(board);
            //FrmForumPostControl frmPost = new FrmForumPostControl();
            //frmPost.Show(); // 使用 ShowDialog 以模態方式顯示
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var board = new ForumPostCategory(); // 例如 1 是「聊天室」
            this.Controls.Clear();
            this.Controls.Add(board);
            //FrmForumPostControl frmPost = new FrmForumPostControl();
            //frmPost.Show(); // 使用 ShowDialog 以模態方式顯示
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var board = new ForumPostFilter(); // 例如 1 是「聊天室」
            this.Controls.Clear();
            this.Controls.Add(board);
            //FrmForumPostControl frmPost = new FrmForumPostControl();
            //frmPost.Show(); // 使用 ShowDialog 以模態方式顯示
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var board = new ForumPostComment(); // 例如 1 是「聊天室」
            this.Controls.Clear();
            this.Controls.Add(board);
            //FrmForumPostControl frmPost = new FrmForumPostControl();
            //frmPost.Show(); // 使用 ShowDialog 以模態方式顯示
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var board = new OldForumControl(); // 例如 1 是「聊天室」
            this.Controls.Clear();
            this.Controls.Add(board);
        }
    }
}
