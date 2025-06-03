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
    public partial class MemberUserRegister : UserControl
    {
        private Form1 _mainForm;

       
        public MemberUserRegister()
        {
            InitializeComponent();
        }

       
        public MemberUserRegister(Form1 mainForm) : this()
        {
            _mainForm = mainForm;
        }

        private void MemberUserRegister_Load(object sender, EventArgs e)
        {

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);

        }
    }
}