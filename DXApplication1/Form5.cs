using System;
using System.IO;
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
using System.Diagnostics;


namespace DXApplication1
{
    public partial class Form5 : DevExpress.XtraEditors.XtraForm
    {
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        char s;
        String t_path, s_path;
        int theory, lab;
        int[] classes;
        int c1, c2, c3, c4;
        form5PopupForm popup = new form5PopupForm();
        int j;

        public Form5(Form2 incForm2, Form3 incForm3,int[]classes,String t,String s,int theo,int lab)
        {
            frm2 = incForm2;
            frm3 = incForm3;
            InitializeComponent();
            tabRename();
            j = 1;
            assignclass1();
            j = 1;
            assignclass2();
            j = 1;
            assignclass3();
            j = 1;
            assignclass4();
            this.t_path = t;
            this.s_path = s;
            this.theory = theo;
            this.lab = lab;
                this.classes=classes;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
        }

        public void tabRename()
        {

            if (frm2.val == "odd")
            {

                this.xtraTabPage1.Text = "Semester 1";

                this.xtraTabPage2.Text = "Semester 3";

                this.xtraTabPage3.Text = "Semester 5";

                this.xtraTabPage4.Text = "Semester 7";

            }
            else if (frm2.val == "even")
            {
                this.xtraTabPage1.Text = "Semester 2";
                this.xtraTabPage2.Text = "Semester 4";
                this.xtraTabPage3.Text = "Semester 6";
                this.xtraTabPage4.Text = "Semester 8";
            }
        }

        public void assignclass1()
        {
            
            for (int i = 65; i <= (64 + frm3.c1); i++)
            {
                s = Convert.ToChar(i);
                XtraTabPage test = new XtraTabPage();

                test.Text = "Class " + s;
                string strConnectionString = "";
                string sheetName = "Sheet"+j;
                String strFile = AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + 1;

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

                test.Controls.Add(gridControl);
                ++j;


                xtraTabControl2.TabPages.Add(test);



            }

        }
        

        public void assignclass2()
        {
            
            for (int i = 65; i <= (64 + frm3.c2); i++)
            {
                s = Convert.ToChar(i);
                XtraTabPage test = new XtraTabPage();

                test.Text = "Class " + s;
                string strConnectionString = "";
                string sheetName = "Sheet" + j;


                String strFile = AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + 2;

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

                test.Controls.Add(gridControl);
                ++j;


                xtraTabControl3.TabPages.Add(test);



            }

        }

        public void assignclass3()
        {
            
            for (int i = 65; i <= (64 + frm3.c3); i++)
            {
                s = Convert.ToChar(i);
                XtraTabPage test = new XtraTabPage();

                test.Text = "Class " + s;
                string strConnectionString = "";
                string sheetName = "Sheet" + j;


                String strFile = AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + 3;

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

                test.Controls.Add(gridControl);
                ++j;


                xtraTabControl4.TabPages.Add(test);



            }

        }

        public void assignclass4()
        {
           
            for (int i = 65; i <= (64 + frm3.c4); i++)
            {
                s = Convert.ToChar(i);
                XtraTabPage test = new XtraTabPage();

                test.Text = "Class " + s;
                string strConnectionString = "";
                string sheetName = "Sheet" + j;


                String strFile = AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + 4;

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

                test.Controls.Add(gridControl);
                ++j;


                xtraTabControl5.TabPages.Add(test);
                


            }

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
            int[] cl = new int[4] { frm3.c1, frm3.c2, frm3.c3, frm3.c4 };
            //if (!(System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList_copy")))
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule_copy");
            foreach (var file in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule"))
            File.Copy(file, Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule_copy", Path.GetFileName(file)));
            allocation al = new allocation();
            splashScreenManager3.ShowWaitForm();
            al.final_alloc(cl);
            splashScreenManager3.CloseWaitForm();
            Form6 frm = new Form6(frm2, frm3, cl);
            frm.Show();
            this.Visible = false;
        }

       
        
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void saveButton_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
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
                                    complink.ExportToXlsx(Directory.GetCurrentDirectory() + @"\Data\ClassList\" + sem + ".xlsx", new XlsxExportOptions() { ExportMode = XlsxExportMode.SingleFilePageByPage });

                                }
                            }
                        }


                    }

                }
                ++sem;
            }
            splashScreenManager2.CloseWaitForm();
            XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, "Saved Successfully");
                    
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 frm = new Form4(frm2, frm3, classes, t_path, s_path, theory, lab);
            frm.Show();
        }

        

      
    }
    
       

       

}