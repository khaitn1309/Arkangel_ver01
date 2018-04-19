using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keylog
{
    public partial class _Clipboard : UserControl
    {
        public _Clipboard()
        {
            InitializeComponent();
            bt_change2.Visible = false;
            tb2_clipboard.Text = Clipboard.GetText();
        }
        public System.IO.Stream SwapClipboardAudio(System.IO.Stream replacementAudioStream)
        {
            System.IO.Stream returnAudioStream = null;
            if (Clipboard.ContainsAudio())
            {
                returnAudioStream = Clipboard.GetAudioStream();
                Clipboard.SetAudio(replacementAudioStream);
            }
            return returnAudioStream;
        }


        // Demonstrates SetText, ContainsText, and GetText.
        public String SwapClipboardHtmlText(String replacementHtmlText)
        {
            String returnHtmlText = null;
            if (Clipboard.ContainsText(TextDataFormat.Html))
            {
                returnHtmlText = Clipboard.GetText(TextDataFormat.Html);
                Clipboard.SetText(replacementHtmlText, TextDataFormat.Html);
            }
            return returnHtmlText;
        }
        private void bt_change2_Click(object sender, EventArgs e)
        {
            if (tb2_clipboard.Text != "")
            {
                Clipboard.SetText(tb2_clipboard.Text);
                tb2_clipboard.ReadOnly = true;
                bt_change2.Visible = false;
                bt_change.Visible = true;
            }
        }

        private void bt_image_Click(object sender, EventArgs e)
        {
            CB_Image cB_Image = new CB_Image();
        }

        private void bt_file_Click(object sender, EventArgs e)
        {
            CB_Filecs cB_Filecs = new CB_Filecs();
        }

        private void bt_change_Click(object sender, EventArgs e)
        {
            if (tb2_clipboard.ReadOnly == true)
            {
                tb2_clipboard.ReadOnly = false;
                bt_change.Visible = false;
                bt_change2.Visible = true;
            }
        }
    }
}
