using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            DSMessageBox messageBox = new DSMessageBox();
            var response = messageBox.ShowQuestionRtl("هل تريد الحذف", "تاكيد الحذف", "حذف الملف", "إلغاء الأمر");
            Text = response.ToString();

            if (response == DialogResult.OK)
            {
                Text = "تم الحذف";
            }
            else
            {
                Text = "ألغي الحذف";
            }
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            DSMessageBox messageBox = new DSMessageBox();
            var response = messageBox.ShowWarn("Thanks for watching!", "Thanks", "OK");

            Text = response.ToString();
        }
    }
}
