using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DSMessageBox : Form
    {
        DialogResult _result;
        bool canClose = false;

        public DSMessageBox()
        {
            InitializeComponent();
        }

        public DialogResult Show(string text, Icon icon, string caption = "", string acceptText = "Accept", string cancelText = "Cancel", bool isRTL = false)
        {
            if (isRTL)
            {
                RightToLeft = RightToLeft.Yes;
                RightToLeftLayout = true;
                btnAccept.Dock = btnCancel.Dock = separator.Dock = DockStyle.Left;
                labelText.Padding = new Padding(25, 28, 0, 20);
            }
            pictureIcon.Image = icon.ToBitmap();
            labelText.Text = text;
            Text = caption;
            btnAccept.Text = acceptText;
            btnCancel.Text = cancelText;
            MinimumSize = new Size(60 + btnAccept.Width + btnCancel.Width, 175);
            ShowDialog();
            return _result;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            canClose = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            canClose = true;
            Close();
        }

        private void DSMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !canClose;
        }
    }
}
