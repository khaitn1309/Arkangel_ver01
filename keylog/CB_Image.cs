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
    public partial class CB_Image : MetroFramework.Forms.MetroForm
    {
        public CB_Image()
        {
            InitializeComponent();
            Image image = null;
            image = Clipboard.GetImage();
            if (image != null)
            {
                this.Show();
                Bitmap objBitmap = new Bitmap(image, new Size(627, 338));
                pictureBox1.Image = objBitmap;
                pictureBox1.Show();
            }
            else
            {
                MessageBox.Show("No Image in Clipboard");
                this.Close();
            }

        }
        // Demonstrates SetImage, ContainsImage, and GetImage.
        public System.Drawing.Image SwapClipboardImage(
            System.Drawing.Image replacementImage)
        {
            System.Drawing.Image returnImage = null;
            if (Clipboard.ContainsImage())
            {
                returnImage = Clipboard.GetImage();
                Clipboard.SetImage(replacementImage);
            }
            return returnImage;
        }

        private void bt_change_Click(object sender, EventArgs e)
        {
            Image image;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                image = new Bitmap(fileDialog.FileName);
                // image file path  
                SwapClipboardImage(image);
            }
            this.Close();
            MessageBox.Show("Change Already");
        }
    }
}
