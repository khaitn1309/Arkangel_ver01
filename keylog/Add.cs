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
    public partial class Add : MetroFramework.Forms.MetroForm
    {
        private Alert _form = null;
        public Add(Alert form)
        {
            InitializeComponent();
            this._form = form;

        }


        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Show();
            _form.AddListBoxItem(tb_keyword.text);
            this.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

