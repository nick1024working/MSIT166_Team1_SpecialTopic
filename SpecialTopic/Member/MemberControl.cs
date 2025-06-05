using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialTopic
{
    public partial class MemberControl : UserControl
    {
        private Form1 _mainForm;

        
        public MemberControl()
        {
            InitializeComponent();
        }

        public MemberControl(Form1 mainForm) : this()
        {
            _mainForm = mainForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            _mainForm.ShowControl(new MemberUserRegister(_mainForm));
        }

     
    }
}


