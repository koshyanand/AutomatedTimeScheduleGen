using System;
using System.Windows.Forms;
using System.Threading;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(4000);
        }

        private void tileControl1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Visible = false;
            frm2.Show();

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

        private void tileControl2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Visible = false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        
       
        

        
    }
}
