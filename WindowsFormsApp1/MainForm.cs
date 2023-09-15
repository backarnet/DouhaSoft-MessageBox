using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DSMessageBox dSMessageBox = new DSMessageBox();
            var response = dSMessageBox.Show(
                "هل تريد تأكيد حذف البرنامج مع كل ملحقاته؟\nتجريب تعدد الأسطر\nتم تمديد حجم الأزرار والفورم تلقائيا بانسيابية ... التحجيم تلقائي طولا وعرضا.",
                //"تجريب الحجم",
                SystemIcons.Question,
                "تأكيد الحذف",
                "حذف البرنامج مع الملحقات",
                "إلغاء الحذف",
                true);

            if (response == DialogResult.OK)
            {
                Text = "تم الحذف";
            }
            else
            {
                Text = "ألغي الحذف";
            }
        }
    }
}
