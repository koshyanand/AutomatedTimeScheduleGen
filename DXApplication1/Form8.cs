using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;





namespace DXApplication1
{
    public partial class Form8 : DevExpress.XtraEditors.XtraForm
    {
        String name;
        
        public Form8(string incomingString)
        {
            name = incomingString;
            InitializeComponent();
        }
        public Form8()
        {
            InitializeComponent();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Visible = false;

        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            String FolderName = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Staff Schedules\";
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }
            Application.Exit();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (!(System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Staff Schedules")))
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Staff Schedules");


            splashScreenManager1.ShowWaitForm();
            label1.Text = "Welcome "+name+" ,";
            string strConnectionString = "";
            string sheetName = "Sheet1";


            String strFile = AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + name + ".xlsx";

            strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);

            OleDbConnection SQLConn = new OleDbConnection(strConnectionString);

            OleDbDataAdapter SQLAdapter = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$] ", SQLConn);

            DataTable dt1 = new DataTable(sheetName);
            SQLAdapter.Fill(dt1);
            gridControl1.DataSource = dt1;
            gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 22);
            gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 15);
            gridView1.Appearance.HeaderPanel.ForeColor = Color.DarkOrange;
            splashScreenManager1.CloseWaitForm();

        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Staff Schedules\" + name +" _schedule.xlsx";
            gridControl1.ExportToXlsx(fileName);
            EmailPopUp eform = new EmailPopUp(this, name, fileName);
            eform.Show();
          
    }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                gridControl1.ExportToXlsx(path + @"\" + name + " _schedule.xlsx");
                form8PopupForm frm = new form8PopupForm(path,name);
                frm.Show();

            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();

        }

      
    }
}