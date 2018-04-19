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
    public partial class CB_Filecs : MetroFramework.Forms.MetroForm
    {
        public CB_Filecs()
        {
            InitializeComponent();

            System.Collections.Specialized.StringCollection listFile = null;
            listFile = Clipboard.GetFileDropList();
            //  Console.WriteLine(listFile.ToString());
            if (listFile.Count != 0)
            {
                this.Show();
                string[] array = new string[1000];

                listFile.CopyTo(array, 0);
                //   listFile.CopyTo(array, 1);
                int n = listFile.Count;
                for (int i = 0; i < n; i++)
                {
                    listBox1.Items.Add(array[i]);
                }
            }
            else
            {
                MessageBox.Show("No file in Clipboard");
            }
        }

        // Demonstrates SetFileDropList, ContainsFileDroList, and GetFileDropList
        public System.Collections.Specialized.StringCollection SwapClipboardFileDropList(
            System.Collections.Specialized.StringCollection replacementList)
        {
            System.Collections.Specialized.StringCollection returnList = null;
            if (Clipboard.ContainsFileDropList())
            {
                returnList = Clipboard.GetFileDropList();
                Clipboard.SetFileDropList(replacementList);
            }
            return returnList;
        }

        private void bt_change_Click(object sender, EventArgs e)
        {
            System.Collections.Specialized.StringCollection listFile = new System.Collections.Specialized.StringCollection();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in fileDialog.FileNames)
                {
                    listFile.Add(file);
                }
                SwapClipboardFileDropList(listFile);
                this.Close();
                MessageBox.Show("Change Already");
            }
        }
    }
}
