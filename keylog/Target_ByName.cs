using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keylog
{
    public partial class Target_ByName : Form
    {
        private Target _form = null;
        public Target_ByName(Target form)
        {
            InitializeComponent();
            this._form = form;
        }

        private void btnAdd_TargetAddTitle_Click(object sender, EventArgs e)
        {
            this.Show();
            _form.AddListBoxItem(tbTitle_TargetAddTitle.Text,"Name");
            this.Close();
        }

        private void btnClose_TargetAddTitle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
