using System;
using System.Diagnostics;

namespace DXApplication1
{
    public partial class form8PopupForm : DevExpress.XtraEditors.XtraForm
    {
        string path,name;

        public form8PopupForm(string incPath, string incName)
        {
            path=incPath;
            name = incName;

            InitializeComponent();
        }

        private void form8PopupForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Saved to " + path + @"\" + name + " _schedule.xlsx";

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFolderbutton_Click(object sender, EventArgs e)
        {
            Process.Start(path + @"\");
        }

    }
}