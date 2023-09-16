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

        private DialogResult Show(string text, Icon icon, string caption = "", string acceptText = "", string cancelText = "", bool isRTL = false)
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
            if (acceptText.Trim() == "" && cancelText.Trim() == "")
            {
                throw new Exception("");
            }
            else
            {
                if (acceptText != "")
                {
                    btnAccept.Text = acceptText;
                }
                else
                {
                    btnAccept.Visible = false;
                    btnCancel.Dock = DockStyle.None;
                    btnCancel.Left = Width / 2 - (btnCancel.Width / 2) - 10;
                    separator.Visible = false;
                }
                if (cancelText != "")
                {
                    btnCancel.Text = cancelText;
                }
                else
                {
                    btnCancel.Visible = false;
                    btnAccept.Dock = DockStyle.None;
                    btnAccept.Left = Width / 2 - (btnAccept.Width / 2) - 10;
                    separator.Visible = false;
                }
            }
            MinimumSize = new Size(67 + btnAccept.Width + btnCancel.Width, 175);
            ShowDialog();
            return _result;
        }

        public DialogResult ShowQuestion(string text, string caption, string acceptText, string cancelText)
        {
            return Show(text, SystemIcons.Question, caption, acceptText: acceptText, cancelText: cancelText);
        }

        public DialogResult ShowQuestionRtl(string text, string caption, string acceptText, string cancelText)
        {
            return Show(text, SystemIcons.Question, caption, acceptText: acceptText, cancelText: cancelText, isRTL: true);
        }

        public DialogResult ShowInfo(string text, string caption, string acceptText)
        {
            return Show(text, SystemIcons.Information, caption, acceptText: acceptText);
        }

        public DialogResult ShowInfoRtl(string text, string caption, string acceptText)
        {
            return Show(text, SystemIcons.Information, caption, acceptText: acceptText, isRTL: true);
        }

        public DialogResult ShowWarn(string text, string caption, string acceptText)
        {
            return Show(text, SystemIcons.Warning, caption, acceptText: acceptText);
        }

        public DialogResult ShowWarnRtl(string text, string caption, string acceptText)
        {
            return Show(text, SystemIcons.Warning, caption, acceptText: acceptText, isRTL: true);
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
