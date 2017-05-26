using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraGrid;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using DevExpress.XtraEditors;
using System.IO;

namespace DXApplication1
{
    public partial class Form6 : DevExpress.XtraEditors.XtraForm
    {

        Form2 form2 = new Form2();
        Form3 form3 = new Form3();


        char s;


        private int[] classes;
        
        public Form6(Form2 incomingForm,Form3 incForm3,int [] classes)
        {
            form2 = incomingForm;
            form3= incForm3;
            
            InitializeComponent();
            
            tabRename();
            this.classes = classes;
            
            assignclass1();
           
            assignclass2();
           
            assignclass3();
            
            assignclass4();
    
        }

        public void tabRename()
        {

            if (form2.val == "odd")
            {
                
                this.xtraTabPage1.Text = "Semester 1";
                
                this.xtraTabPage2.Text = "Semester 3";
                
                this.xtraTabPage3.Text = "Semester 5";
              
                this.xtraTabPage4.Text = "Semester 7";
                
            }
            else if (form2.val == "even")
            {
                this.xtraTabPage1.Text = "Semester 2";
                this.xtraTabPage2.Text = "Semester 4";
                this.xtraTabPage3.Text = "Semester 6";
                this.xtraTabPage4.Text = "Semester 8";
            }
        }

        public void assignclass1()
        {
            int j = 1;
            for (int i = 65; i <= (64 + form3.c1); i++)
            {
                s = Convert.ToChar(i);
                XtraTabPage test = new XtraTabPage();
               
                test.Text = "Class " + s;
                string strConnectionString = "";
                string sheetName = "Sheet" + j;


                String strFile = AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\1.xlsx";

                strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);

                OleDbConnection SQLConn = new OleDbConnection(strConnectionString);

                OleDbDataAdapter SQLAdapter = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$] ", SQLConn);

                DataTable dt1 = new DataTable(sheetName);
                SQLAdapter.Fill(dt1);
                
                GridControl gridControl = new GridControl();
                gridControl.DataSource = dt1;
                

                GridView view = new GridView();
                gridControl.ViewCollection.Add(view);
                gridControl.MainView = view;
                view.GridControl = gridControl;
                view.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 22);
                view.OptionsView.ShowGroupPanel = false;
                view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 15);
                view.Appearance.HeaderPanel.ForeColor = Color.DarkOrange;
                
                

                gridControl.Size = new System.Drawing.Size(1000, 600);
                gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Bottom)
                                 | System.Windows.Forms.AnchorStyles.Right)));
                gridControl.Dock = DockStyle.Fill;
               
                SQLConn.Close();
                ++j;
                test.Controls.Add(gridControl);
                
               
                xtraTabControl2.TabPages.Add(test);
                


            }

        }

         public void assignclass2()
        {
             int j=1;

            for (int i = 65; i <= (64 + form3.c2); i++)
            {
                s = Convert.ToChar(i);
                XtraTabPage test = new XtraTabPage();

                test.Text = "Class " + s;
                string strConnectionString = "";
                string sheetName = "Sheet" + j;


                String strFile = AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\2.xlsx";

                strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);

                OleDbConnection SQLConn = new OleDbConnection(strConnectionString);

                OleDbDataAdapter SQLAdapter = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$] ", SQLConn);

                DataTable dt1 = new DataTable(sheetName);
                SQLAdapter.Fill(dt1);

                GridControl gridControl = new GridControl();
                gridControl.DataSource = dt1;


                GridView view = new GridView();
                gridControl.ViewCollection.Add(view);
                gridControl.MainView = view;
                view.GridControl = gridControl;
                view.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 22);
                view.OptionsView.ShowGroupPanel = false;
                view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 15);
                view.Appearance.HeaderPanel.ForeColor = Color.DarkOrange;

                gridControl.Size = new System.Drawing.Size(1000, 600);
                gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Bottom)
                                 | System.Windows.Forms.AnchorStyles.Right)));
                gridControl.Dock = DockStyle.Fill;

                SQLConn.Close();
                ++j;
                test.Controls.Add(gridControl);
                

                xtraTabControl3.TabPages.Add(test);
                

            }
           
        }
        public void assignclass3()
        {
            int j = 1;
            for (int i = 65; i <= (64 + form3.c3); i++)
            {
                s = Convert.ToChar(i);
                XtraTabPage test = new XtraTabPage();

                test.Text = "Class " + s;
                string strConnectionString = "";
                string sheetName = "Sheet" + j;


                String strFile = AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\3.xlsx";

                strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);

                OleDbConnection SQLConn = new OleDbConnection(strConnectionString);

                OleDbDataAdapter SQLAdapter = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$] ", SQLConn);

                DataTable dt1 = new DataTable(sheetName);
                SQLAdapter.Fill(dt1);

                GridControl gridControl = new GridControl();
                gridControl.DataSource = dt1;


                GridView view = new GridView();
                gridControl.ViewCollection.Add(view);
                gridControl.MainView = view;
                view.GridControl = gridControl;
                view.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 22);
                view.OptionsView.ShowGroupPanel = false;
                view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 15);
                view.Appearance.HeaderPanel.ForeColor = Color.DarkOrange;

                gridControl.Size = new System.Drawing.Size(1000, 600);
                gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Bottom)
                                 | System.Windows.Forms.AnchorStyles.Right)));
                gridControl.Dock = DockStyle.Fill;

                SQLConn.Close();
                ++j;
                test.Controls.Add(gridControl);
               

                xtraTabControl4.TabPages.Add(test);
                

            }
        }
        public void assignclass4()
        {
            int j = 1;
            for (int i = 65; i <= (64 + form3.c4); i++)
            {
                s = Convert.ToChar(i);
                XtraTabPage test = new XtraTabPage();

                test.Text = "Class " + s;
                string strConnectionString = "";
                string sheetName = "Sheet" +j;


                String strFile = AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\4.xlsx";

                strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);

                OleDbConnection SQLConn = new OleDbConnection(strConnectionString);

                OleDbDataAdapter SQLAdapter = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$] ", SQLConn);

                DataTable dt1 = new DataTable(sheetName);
                SQLAdapter.Fill(dt1);

                GridControl gridControl = new GridControl();
                gridControl.DataSource = dt1;


                GridView view = new GridView();
                gridControl.ViewCollection.Add(view);
                gridControl.MainView = view;
                view.GridControl = gridControl;
                view.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 22);
                view.OptionsView.ShowGroupPanel = false;
                view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 18);
                view.Appearance.HeaderPanel.ForeColor = Color.DarkOrange;

                gridControl.Size = new System.Drawing.Size(1000, 600);
                gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Bottom)
                                 | System.Windows.Forms.AnchorStyles.Right)));
                gridControl.Dock = DockStyle.Fill;

                SQLConn.Close();
                ++j;

                test.Controls.Add(gridControl);
                

                xtraTabControl5.TabPages.Add(test);
                

            }

        }

        

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
                if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowserDialog1.SelectedPath;
                
  
                splashScreenManager1.ShowWaitForm();
                int sem = 1;
                foreach (XtraTabPage tb in xtraTabControl1.TabPages)
                {

                    foreach (Control ct in tb.Controls)
                    {

                        if (ct is XtraTabControl)
                        {
                            XtraTabControl tc = (XtraTabControl)ct;
                            CompositeLink complink = new CompositeLink(new PrintingSystem());
                            foreach (XtraTabPage tp in tc.TabPages)
                            {

                                foreach (Control ctrl in tp.Controls)
                                {
                                    if (ctrl is GridControl)
                                    {

                                        GridControl gc = (GridControl)ctrl;

                                        PrintableComponentLink link = new PrintableComponentLink();
                                        link.Component = gc;
                                        complink.Links.Add(link);

                                        complink.CreatePageForEachLink();
                                        complink.ExportToXlsx(path + @"\Year" + sem + ".xlsx", new XlsxExportOptions() { ExportMode = XlsxExportMode.SingleFilePageByPage });

                                    }
                                }
                            }


                        }

                    }
                    ++sem;
                }
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, "Saved Successfully");
                    
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Visible = false;

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

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void regenerateButton_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            //if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
                this.DeleteDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule");
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule");
                foreach (var file in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule_copy"))
                    File.Copy(file, Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule", Path.GetFileName(file)));
                //this.DeleteDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule_copy");
                this.Dispose();
                //System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule_copy");
               
                allocation al = new allocation();
                //splashScreenManager3.ShowWaitForm();
                al.final_alloc(classes);
                Form6 frm = new Form6(form2, form3, classes);
                splashScreenManager2.CloseWaitForm();   
                frm.Show();
        }
        public void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, true);
        }

        private void xtraTabControl2_Click(object sender, EventArgs e)
        {

        }

       
    }
}