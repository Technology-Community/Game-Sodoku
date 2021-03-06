using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnCTSDK
{
    public partial class OptionPublish : Form
    {
        public bool willPublish = false;
        public bool rtf = true;
        public OptionPublish()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            willPublish = false;
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkHtml.Checked)
                DialogSave.Filter = "Html file (*.html)|*.html";
            else
                DialogSave.Filter = "Rich text format (*.rtf)|*.rtf";
            if (DialogSave.ShowDialog() != DialogResult.Cancel)
                txtPath.Text = DialogSave.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Length < 2)
            {
                MessageBox.Show("Chưa nhập đường dẫn !", "Sai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            rtf = checkRTF.Checked;
            willPublish = true;
            this.Close();
        }

        private void txtPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                button2_Click(sender, e);
            }
            else if (e.KeyCode.ToString() == "Escape") this.Close();
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape") this.Close();
        }
    }
}