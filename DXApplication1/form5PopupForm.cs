using System;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class form5PopupForm : DevExpress.XtraEditors.XtraForm
    {
        public form5PopupForm()
        {
            InitializeComponent();
        }

        private void form5PopupForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void form5PopupForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}