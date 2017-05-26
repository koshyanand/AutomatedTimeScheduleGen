using System;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form3 : DevExpress.XtraEditors.XtraForm
    {
        public int c1 =0;
        public int c2 =0;
        public int c3 =0;
        public int c4 =0;
        public int theory = 0;
        public int lab = 0;
        String t_path, s_path;
        Form2 frm2 = new Form2();
        public Form3()
        {
           
        }

        public Form3(Form2 incForm2, String t_path,String s_path)
        {
            this.t_path = t_path;
            this.s_path = s_path;
            frm2 = incForm2;
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            /*
            String FolderName = AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\";
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }
            String FolderName2 = AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\";
            DirectoryInfo dir2 = new DirectoryInfo(FolderName2);

            foreach (FileInfo fi in dir2.GetFiles())
            {
                fi.Delete();
            }
            String FolderName3 = AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule_copy\";
            DirectoryInfo dir3 = new DirectoryInfo(FolderName3);

            foreach (FileInfo fi in dir3.GetFiles())
            {
                fi.Delete();
            }
             * */
            Application.Exit();
        }
 

        private void nextButton_Click(object sender, EventArgs e)
        {
           


            splashScreenManager1.ShowWaitForm();
            int[] classes = new int[] { c1, c2, c3, c4 };
            
            BackEnd be = new BackEnd();
            be.start(t_path);
            
            
                this.Visible = false;
                Form4 form4 = new Form4(frm2, this, classes,t_path,s_path,theory,lab);
                
                form4.Show();
                splashScreenManager1.CloseWaitForm();
            
   
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Visible = false;
            frm2.Show();


        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            c1 = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
            c2 = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged_1(object sender, EventArgs e)
        {
            c3 = (int)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged_1(object sender, EventArgs e)
        {
            c4 = (int)numericUpDown4.Value;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void externalSubLab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            theory = (int)numericUpDown6.Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            lab = (int)numericUpDown5.Value;
        }

          
    }
}