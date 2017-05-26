using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
namespace DXApplication1
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public String val, t_path, s_path;
        public Form2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String FolderName = AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\";
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }
            

        }

        private void browseButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.teachersPathTextBox1.Text = openFileDialog1.FileName;

            }
        }

        private void browseButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.subPathTextBox2.Text = openFileDialog2.FileName;
            }
        }

        private void teachersPathTextBox1_TextChanged(object sender, EventArgs e)
        {
            t_path = openFileDialog1.FileName;
        }

        private void subPathTextBox2_TextChanged(object sender, EventArgs e)
        {
            s_path = openFileDialog2.FileName;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (((teachersPathTextBox1.Text != null) && (subPathTextBox2.Text != null)) && ((oddButton.Checked == true) || (evenButton.Checked == true)))
            {

                this.Visible = false;
                Form3 form3 = new Form3(this, t_path, s_path);
                form3.Show();
            }
            else
            {
                XtraMessageBox.Show("Fill values First !");
               

            }
        }

        private void oddButton_CheckedChanged(object sender, EventArgs e)
        {
            val = "odd";
        }

        private void evenButton_CheckedChanged(object sender, EventArgs e)
        {
            val = "even";
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}