using System;
using System.Windows.Forms;

namespace DXApplication1
{
   
    public partial class Form7 : DevExpress.XtraEditors.XtraForm
    {
        string teacher_name;
        public Form7()
        {
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.Text != "Select Staff Name" && comboBoxEdit1.Text !="")
            {
                Summary s = new Summary();
                s.summary(teacher_name);
                Form8 frm = new Form8(teacher_name);
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("No Name Selected !");
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Visible = false;

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacher_name = comboBoxEdit1.SelectedText;

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}