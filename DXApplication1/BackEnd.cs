using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytescout.Spreadsheet;
using System.IO;
using Bytescout.Spreadsheet.BaseClasses;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    class BackEnd
    {
        int theory, lab;
        String staff_file, sub_file;
        int[] classes = new int[4];
        public BackEnd(String t_path, String s_path, int[] c,int theory,int lab)
        {
            //if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
            //    this.DeleteDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data");
            //if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
            //    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\");
            //if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
            //    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\");
            this.staff_file = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Teachers_copy.xlsx";
            this.sub_file = s_path;
            this.classes = c;
            this.theory = theory;
            this.lab = lab;
        }
        public void start(String t_path)
        {
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
                this.DeleteDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data");
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\");
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data"))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\");
            allocation al = new allocation();
            al.createBlank_schedule();
            if (!(System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule")))
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule");
            File.Copy(t_path, AppDomain.CurrentDomain.BaseDirectory + @"\Data\Teachers_copy.xlsx");
            this.staff_file = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Teachers_copy.xlsx";

            
        }
        public BackEnd()
        {
            // TODO: Complete member initialization
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
        public void beginPhase1()
        {
            int i, j = 0, k = 0;
            float t_credit, credit;
            double hours;
            String subject;
            int[] year = new int[4] { 1, 2, 3, 4 };
            Spreadsheet document = new Spreadsheet();
            Spreadsheet Phase2 = new Spreadsheet();
            phase2 p2 = new phase2(this.staff_file,this.theory,this.lab);
            this.shuffle(ref year, ref classes, 4);
            document.LoadFromFile(sub_file);
           
            if (!(System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList")))
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList");

            for (i = 0; i < 4; i++)
            {
                Worksheet AddWorksheet = Phase2.Workbook.Worksheets.Add(year[i].ToString());
                Worksheet UseWorksheet = Phase2.Workbook.Worksheets.ByName(year[i].ToString());
                Worksheet worksheet = document.Workbook.Worksheets.ByName(year[i].ToString());
                t_credit = worksheet.Cell(0, 2).ValueAsInteger;
                while (String.IsNullOrEmpty(worksheet.Cell(k, 0).ValueAsString) != true)
                {
                    credit = worksheet.Cell(k, 1).ValueAsInteger;
                    hours = Math.Round((credit * 35) / t_credit);
                    subject = worksheet.Cell(k, 0).ValueAsString;
                    String[] result = new String[classes[i]];
                    result = p2.extract(subject, classes[i]);
                    UseWorksheet.Cell(k, 0).Value = hours;
                    UseWorksheet.Cell(k, 1).Value = subject;
                    for (j = 1; j <= classes[i]; j++)
                    {
                        UseWorksheet.Cell(k, j + 1).Value = result[j - 1];
                    }
                    k++;
                }
                k = 0;


                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Phase2.xlsx"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Phase2.xlsx");
                Phase2.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Phase2.xlsx");
            }
            phase3 p3 = new phase3(classes, year,theory,lab);
            p3.extract();



        }
        public void shuffle(ref int[] year, ref int[] classes, int size)
        {
            int temp, i, var, temp2;
            Random rnd = new Random();
            for (i = 0; i < size; i++)
            {   
                var = rnd.Next(0, 4);
                temp = year[i];
                year[i] = year[var];
                year[var] = temp;
                temp2 = classes[i];
                classes[i] = classes[var];
                classes[var] = temp2;

            }

        }
    }
    class phase2
    {
        String staff_path;
        Spreadsheet document;
        Worksheet worksheet;
        int theory, lab;
        public void shuffle(ref int[] sub_staff, int size)
        {
            int temp, i, var;
            Random rnd = new Random();
            for (i = 0; i < size; i++)
            {
                var = rnd.Next(0, size);
                temp = sub_staff[i];
                sub_staff[i] = sub_staff[var];
                sub_staff[var] = temp;
            }

        }
        public phase2(String path,int theory,int lab)
        {
            this.theory = theory;
            this.lab=lab;
            this.staff_path = path;
            this.document = new Spreadsheet();
            this.document.LoadFromFile(this.staff_path);
            worksheet = document.Workbook.Worksheets.ByName("Sheet1");
        }
        public String[] extract(String subject, int times)
        {
            int count = 0, scount = 0, i = 1, j = 2, m = 0, k, l = 0, r, c;
            String[] result = new String[times];
            int[] rand_sel = new int[15];
            while (j <= 5)
            {

                if (subject == worksheet.Cell(i, j).ValueAsString)
                {
                    rand_sel[l] = i * 10 + j;
                    l++;
                }

                if (String.IsNullOrEmpty(worksheet.Cell(i + 1, j).ValueAsString))
                {
                    i = 0;
                    j++;

                }
                i++;
            }
            shuffle(ref rand_sel, l);
            for (i = 0; i < l; i++)
            {
                if (count < times)
                {
                    c = rand_sel[i] % 10;
                    r = rand_sel[i] / 10;
                    if (worksheet.Cell(r, c).ValueAsString.IndexOf("Lab") >= 0)
                    {

                        result[m] = worksheet.Cell(r, 1).ValueAsString;
                        worksheet.Cell(r, c).Value = "X";
                        m++;
                        count++;
                        if (lab == 2 && times - count >= 1)
                        {
                            result[m] = worksheet.Cell(r, 1).ValueAsString;
                            worksheet.Cell(r, c).Value = "XX";
                            m++;
                            count++;
                        }
                        if (lab == 3 && times - count >= 2)
                        {
                            result[m] = worksheet.Cell(r, 1).ValueAsString;
                            m++;
                            result[m] = worksheet.Cell(r, 1).ValueAsString;
                            worksheet.Cell(r, c).Value = "XXX";
                            m++;
                            count+=2;
                        }
                        continue;
                    }
                    else
                    {
                        for (k = 2; k < 5; k++)
                        {
                            if (worksheet.Cell(r, k).ValueAsString == "X")
                            {
                                scount++;
                            }
                            if (worksheet.Cell(r, k).ValueAsString == "XX")
                            {
                                scount += 2;
                                
                            }
                            if (worksheet.Cell(r, k).ValueAsString == "XXX")
                            {
                                scount += 3;
                                
                            }
                            if (worksheet.Cell(r, k).ValueAsString == "XXXX")
                            {
                                scount += 4;
                                
                            }
                        }
                    }
                    if(scount<theory)
                    worksheet.Cell(r, c).Value = "";
                    while (scount < theory && times-count>=1)
                    {
                        result[m] = worksheet.Cell(r, 1).ValueAsString;
                        m++;
                        worksheet.Cell(r, c).Value =worksheet.Cell(r, c).ValueAsString+ "X";
                        scount++;
                        count++;
                    }
                }

                else
                {
                    break;
                }
                scount = 0;
            }
            while (count < (times))
            {
                result[m] = "Shortage";
                m++;
                count++;
            }
            if (File.Exists(staff_path))
                File.Delete(staff_path);
            document.SaveAs(staff_path);
            return result;
        }
    }
    //C:\Users\akaKoshy\Desktop\ATSG\Teachers.xlsx
    class phase3
    {
        private int[] classes;
        private int[] year;
        int theory, lab;

        public phase3(int[] classes, int[] year,int theory,int lab)
        {
            this.classes = classes;
            this.year = year;
            this.theory = theory;
            this.lab = lab;
        }
        public void extract()
        {
            int i, j, k = 0, lab_flag = 0;
            Spreadsheet phase2 = new Spreadsheet();
            Spreadsheet phase3 = new Spreadsheet();
            Spreadsheet register = new Spreadsheet();
            Spreadsheet ts = new Spreadsheet();
            //allocation al = new allocation();
            Worksheet AddReg = register.Workbook.Worksheets.Add("Sheet1");
            register.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
            phase2.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Phase2.xlsx");
            //al.createBlank_schedule();
            for (i = 0; i < 4; i++)
            {
                phase3 = new Spreadsheet();
                Worksheet p2 = phase2.Workbook.Worksheets.ByName(year[i].ToString());
                for (j = 0; j < classes[i]; j++)
                {
                    Worksheet Addp3 = phase3.Workbook.Worksheets.Add("Sheet" + (j + 1).ToString());
                    Worksheet Usep3 = phase3.Workbook.Worksheets.ByName("Sheet" + (j + 1).ToString());
                    Usep3.Cell(0, 0).Value = "Subject";
                    Usep3.Cell(0, 1).Value = "Staff";
                    while (String.IsNullOrEmpty(p2.Cell(k, 1).ValueAsString) != true)
                    {

                        Usep3.Cell(k + 1, 0).Value = p2.Cell(k, 1).ValueAsString;
                        Usep3.Cell(k + 1, 1).Value = p2.Cell(k, j + 2).ValueAsString;

                        if (p2.Cell(k, 1).ValueAsString.IndexOf("Lab") >= 0)
                        {
                            lab_flag = 1;
                        }
                        if (p2.Cell(k, j + 2).ValueAsString != "Shortage")
                        {
                            updateReg(p2.Cell(k, j + 2).ValueAsString, p2.Cell(k, 1).ValueAsString, year[i], (j + 1), lab_flag);
                        }
                        lab_flag = 0;
                        k++;

                    }


                    k = 0;
                }

                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year[i].ToString() + ".xlsx"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year[i].ToString() + ".xlsx");
                phase3.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year[i].ToString() + ".xlsx");

            }
        }
        public void updateReg(String teach, String subject, int year, int section, int flag)
        {
            int k = 0, a = theory * 2 + 1, b = 1,f=0;
            Spreadsheet register = new Spreadsheet();
            register.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
            Worksheet reg = register.Workbook.Worksheets.ByName("Sheet1");
            while (true)
            {
                if (reg.Cell(k, 0).ValueAsString == teach)
                {
                    if (flag == 1)
                    {
                        while (true)
                        {
                            if (String.IsNullOrEmpty(reg.Cell(k, a).ValueAsString))
                            {
                                reg.Cell(k, a).Value = subject;
                                reg.Cell(k, a + 1).Value = year.ToString() + section.ToString();
                                f = 1;
                                break;
                            }
                            else a += 2;
                        }
                        if (f == 1) break;
                    }
                    else
                    {
                        while (true)
                        {
                            if (String.IsNullOrEmpty(reg.Cell(k, b).ValueAsString) && b <= theory * 2 - 1)
                            {
                                reg.Cell(k, b).Value = subject;
                                reg.Cell(k, b + 1).Value = year.ToString() + section.ToString();
                                f = 1;
                                break;
                            }
                            else
                            {
                                if (b <= theory * 2 - 1)
                                    b += 2;
                                else break;
                            }
                        }
                        if (f == 1) break;
                    } 
                }
                if (String.IsNullOrEmpty(reg.Cell(k + 1, 0).ValueAsString))
                {
                    reg.Cell(k + 1, 0).Value = teach;
                    if (flag == 1)
                    {
                        reg.Cell(k + 1, a).Value = subject;
                        reg.Cell(k + 1, a+1).Value = year.ToString() + section.ToString();
                        break;
                    }
                    else
                    {
                        reg.Cell(k + 1, 1).Value = subject;
                        reg.Cell(k + 1, 2).Value = year.ToString() + section.ToString();
                        break;
                    }
                }
                k++;
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
            register.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
        }
    }
    class compare
    {
        String resp;
        Form2 frm = new Form2();
        string a = "";
        int sem;
        int c, v, s, value;
        char cls;

        private void radioLab_CheckedChanged(object sender, EventArgs e)
        {
            resp = "y";
        }

        private void radioSub1_CheckedChanged(object sender, EventArgs e)
        {
            resp = "1";
        }
        private void radioSub2_CheckedChanged(object sender, EventArgs e)
        {
            resp = "2";
        }
        private void radioCancel_CheckedChanged(object sender, EventArgs e)
        {
            resp = "n";

        }
        public void comp(int year, int noc, Form2 incfrm2, form5PopupForm popup)
        {
            frm = incfrm2;

            int i, j = 1, k = 1, l, m = 1, a = 0, loc, n = 1, flag = 0, f;

            Spreadsheet orignal = new Spreadsheet();
            Spreadsheet copy = new Spreadsheet();
            Spreadsheet register = new Spreadsheet();
            Spreadsheet tempo = new Spreadsheet();

            register.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
            orignal.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx");
            copy.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList_copy\" + year + ".xlsx");
            Worksheet reg = register.Workbook.Worksheets.ByName("Sheet1");

            for (i = 1; i <= noc; i++)
            {
                Worksheet or = orignal.Workbook.Worksheets.ByName("Sheet" + i.ToString());
                Worksheet cy = copy.Workbook.Worksheets.ByName("Sheet" + i.ToString());
                j = 1;
                //Console.WriteLine(or.Cell(j, 1).ValueAsString);
                //Console.WriteLine(cy.Cell(j, 1).ValueAsString);
                while (!String.IsNullOrEmpty(or.Cell(j, 0).ValueAsString))
                {
                    //resp=or.Cell(j, 1).ValueAsString;
                    //resp1 = cy.Cell(j, 1).ValueAsString;

                    //Console.WriteLine(cy.Cell(j, 1).ValueAsString);
                    if (or.Cell(j, 1).ValueAsString == cy.Cell(j, 1).ValueAsString)
                    {
                        j++;
                    }
                    else
                    {
                        k = 1;
                        while (!String.IsNullOrEmpty(reg.Cell(k, 0).ValueAsString))
                        {
                            if (reg.Cell(k, 0).ValueAsString == cy.Cell(j, 1).ValueAsString)
                            {
                                if (cy.Cell(j, 0).ValueAsString.IndexOf("Lab") >= 0)
                                {
                                    if (!String.IsNullOrEmpty(reg.Cell(k, 5).ValueAsString))
                                    {
                                        RadioButton radiolab = new RadioButton();

                                        if (frm.val == "odd")
                                        {
                                            value = reg.Cell(k, 6).ValueAsInteger;

                                            v = value / 10;
                                            c = (value % 10) + 64;
                                            cls = Convert.ToChar(c);
                                            switch (v)
                                            {
                                                case 1:
                                                    sem = 1;
                                                    break;

                                                case 2:
                                                    sem = 3;
                                                    break;
                                                case 3:
                                                    sem = 5;
                                                    break;
                                                case 4:
                                                    sem = 7;
                                                    break;
                                            }
                                            radiolab.Left = 30;
                                            radiolab.Top = 120;
                                            radiolab.Width = 320;
                                            radiolab.Height = 70;

                                            radiolab.Text = "Subject : " + reg.Cell(k, 5).ValueAsString + " Semester: " + sem + " Class: " + cls;

                                        }
                                        if (frm.val == "even")
                                        {
                                            value = reg.Cell(k, 6).ValueAsInteger;
                                            v = value / 10;
                                            c = (value % 10) + 64;
                                            cls = Convert.ToChar(c);
                                            switch (v)
                                            {
                                                case 1:
                                                    sem = 2;
                                                    break;

                                                case 2:
                                                    sem = 4;
                                                    break;
                                                case 3:
                                                    sem = 6;
                                                    break;
                                                case 4:
                                                    sem = 8;
                                                    break;
                                            }
                                            radiolab.Left = 20;
                                            radiolab.Top = 100;
                                            radiolab.Width = 300;
                                            radiolab.Height = 30;

                                            radiolab.Text = "Subject: " + reg.Cell(k, 5).ValueAsString + "Semester: " + sem + " Class: " + cls;

                                        }

                                        radiolab.Location = new Point(205, 185);

                                        radiolab.CheckedChanged += new System.EventHandler(this.radioLab_CheckedChanged);
                                        popup.Controls.Add(radiolab);

                                        popup.ShowDialog();
                                        //Console.WriteLine("Delete (y/n):" + reg.Cell(k, 5).ValueAsString + "/t" + reg.Cell(k, 6).ValueAsString);
                                        //resp = Console.ReadLine();
                                        if (resp == "n")
                                        {
                                            return;

                                        }
                                        if (resp == "y")
                                        {
                                            n = 1;
                                            while (!String.IsNullOrEmpty(reg.Cell(n, 0).ValueAsString))
                                            {
                                                if (reg.Cell(n, 0).ValueAsString == or.Cell(j, 1).ValueAsString)
                                                {

                                                    reg.Cell(n, 5).Value = "";
                                                    reg.Cell(n, 6).Value = "";
                                                    flag = 1;
                                                    break;
                                                }
                                                else
                                                {
                                                    n++;
                                                }
                                            }
                                            or.Cell(j, 1).Value = cy.Cell(j, 1).Value;
                                            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx"))
                                                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx");
                                            orignal.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx");
                                            orignal.Close();
                                            tempo.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + reg.Cell(k, 6).ValueAsInteger / 10 + ".xlsx");
                                            Worksheet temp = tempo.Workbook.Worksheets.ByName("Sheet" + reg.Cell(k, 6).ValueAsInteger % 10);
                                            while (!String.IsNullOrEmpty(temp.Cell(m, 0).ValueAsString))
                                            {
                                                if (temp.Cell(m, 0).ValueAsString == reg.Cell(k, 5).ValueAsString)
                                                {
                                                    temp.Cell(m, 1).Value = "Shortage";
                                                    break;
                                                }
                                                else m++;
                                            }
                                            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + reg.Cell(k, 6).ValueAsInteger / 10 + ".xlsx"))
                                                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + reg.Cell(k, 6).ValueAsInteger / 10 + ".xlsx");
                                            tempo.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + reg.Cell(k, 6).ValueAsInteger / 10 + ".xlsx");
                                        }

                                    }
                                    reg.Cell(k, 5).Value = cy.Cell(j, 0).ValueAsString;
                                    reg.Cell(k, 6).Value = year.ToString() + i.ToString();
                                    if (resp != "y")
                                    {
                                        or.Cell(j, 1).Value = cy.Cell(j, 1).ValueAsString;
                                        if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx"))
                                            File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx");
                                        orignal.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx");
                                    }

                                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx"))
                                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
                                    register.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");

                                    return;
                                }
                                else
                                {
                                    for (l = 1; l <= 3; l += 2)
                                    {
                                        if (String.IsNullOrEmpty(reg.Cell(k, l).ValueAsString))
                                        {
                                            reg.Cell(k, l).Value = cy.Cell(j, 0).ValueAsString;
                                            reg.Cell(k, l + 1).Value = year.ToString() + i.ToString();
                                            n = 1;
                                            while (!String.IsNullOrEmpty(reg.Cell(n, 0).ValueAsString))
                                            {
                                                if (reg.Cell(n, 0).ValueAsString == or.Cell(j, 1).ValueAsString)
                                                {
                                                    for (f = 1; f <= 3; f += 2)
                                                    {
                                                        if (reg.Cell(n, f).ValueAsString == or.Cell(j, 0).ValueAsString && reg.Cell(n, f + 1).ValueAsString == year.ToString() + i.ToString())
                                                        {
                                                            reg.Cell(n, f).Value = "";
                                                            reg.Cell(n, f + 1).Value = "";
                                                            flag = 1;
                                                            break;
                                                        }
                                                    }
                                                    if (flag == 1) break;
                                                }
                                                else
                                                {

                                                    n++;
                                                }
                                            }
                                            or.Cell(j, 1).Value = cy.Cell(j, 1).ValueAsString;
                                            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx"))
                                                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
                                            register.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
                                            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx"))
                                                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx");
                                            orignal.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx");
                                            return;
                                        }
                                    }
                                    RadioButton radiosub1 = new RadioButton();
                                    RadioButton radiosub2 = new RadioButton();
                                    RadioButton radiocancel = new RadioButton();

                                    if (frm.val == "odd")
                                    {
                                        value = reg.Cell(k, 2).ValueAsInteger;

                                        v = value / 10;
                                        c = (value % 10) + 64;
                                        cls = Convert.ToChar(c);
                                        switch (v)
                                        {
                                            case 1:
                                                sem = 1;
                                                break;

                                            case 2:
                                                sem = 3;
                                                break;
                                            case 3:
                                                sem = 5;
                                                break;
                                            case 4:
                                                sem = 7;
                                                break;
                                        }
                                        radiosub1.Left = 3;
                                        radiosub1.Top = 3;
                                        radiosub1.Width = 320;
                                        radiosub1.Height = 70;

                                        radiosub1.Text = "Subject : " + reg.Cell(k, 1).ValueAsString + " Semester: " + sem + " Class: " + cls;

                                    }

                                    if (frm.val == "odd")
                                    {
                                        value = reg.Cell(k, 4).ValueAsInteger;

                                        v = value / 10;
                                        c = (value % 10) + 64;
                                        cls = Convert.ToChar(c);
                                        switch (v)
                                        {
                                            case 1:
                                                sem = 1;
                                                break;

                                            case 2:
                                                sem = 3;
                                                break;
                                            case 3:
                                                sem = 5;
                                                break;
                                            case 4:
                                                sem = 7;
                                                break;
                                        }
                                        radiosub2.Left = 3;
                                        radiosub2.Top = 3;
                                        radiosub2.Width = 320;
                                        radiosub2.Height = 70;

                                        radiosub2.Text = "Subject : " + reg.Cell(k, 3).ValueAsString + " Semester: " + sem + " Class: " + cls;

                                    }
                                    if (frm.val == "even")
                                    {
                                        value = reg.Cell(k, 2).ValueAsInteger;
                                        v = value / 10;
                                        c = (value % 10) + 64;
                                        cls = Convert.ToChar(c);
                                        switch (v)
                                        {
                                            case 1:
                                                sem = 2;
                                                break;

                                            case 2:
                                                sem = 4;
                                                break;
                                            case 3:
                                                sem = 6;
                                                break;
                                            case 4:
                                                sem = 8;
                                                break;
                                        }
                                        radiosub1.Left = 30;
                                        radiosub1.Top = 120;
                                        radiosub1.Width = 320;
                                        radiosub1.Height = 70;

                                        radiosub1.Text = "Subject: " + reg.Cell(k, 1).ValueAsString + "Semester: " + sem + " Class: " + cls;

                                    }

                                    if (frm.val == "even")
                                    {
                                        value = reg.Cell(k, 4).ValueAsInteger;
                                        v = value / 10;
                                        c = (value % 10) + 64;
                                        cls = Convert.ToChar(c);
                                        switch (v)
                                        {
                                            case 1:
                                                sem = 2;
                                                break;

                                            case 2:
                                                sem = 4;
                                                break;
                                            case 3:
                                                sem = 6;
                                                break;
                                            case 4:
                                                sem = 8;
                                                break;
                                        }
                                        radiosub2.Left = 30;
                                        radiosub2.Top = 120;
                                        radiosub2.Width = 320;
                                        radiosub2.Height = 70;

                                        radiosub1.Text = "Subject: " + reg.Cell(k, 3).ValueAsString + "Semester: " + sem + " Class: " + cls;

                                    }


                                    radiosub1.Location = new Point(80, 180);
                                    radiosub2.Location = new Point(80, 240);
                                    radiosub1.CheckedChanged += new System.EventHandler(this.radioSub1_CheckedChanged);
                                    radiosub2.CheckedChanged += new System.EventHandler(this.radioSub2_CheckedChanged);
                                    radiocancel.Text = "Cancel";
                                    radiocancel.CheckedChanged += new System.EventHandler(this.radioCancel_CheckedChanged);
                                    radiocancel.Location = new Point(580, 230);


                                    popup.Controls.Add(radiosub1);
                                    popup.Controls.Add(radiosub2);
                                    popup.Controls.Add(radiocancel);
                                    popup.ShowDialog();

                                    switch (resp)
                                    {
                                        case "1":
                                            a = 1;
                                            break;
                                        case "2":
                                            a = 3;
                                            break;
                                        case "n":
                                            return;

                                    }
                                    n = 1;
                                    while (!String.IsNullOrEmpty(reg.Cell(n, 0).ValueAsString))
                                    {
                                        if (reg.Cell(n, 0).ValueAsString == or.Cell(j, 1).ValueAsString)
                                        {
                                            for (l = 1; l <= 3; l += 2)
                                            {
                                                if (reg.Cell(n, l).ValueAsString == or.Cell(j, 0).ValueAsString && reg.Cell(n, l + 1).ValueAsString == year.ToString() + i.ToString())
                                                {
                                                    reg.Cell(n, l).Value = null;
                                                    reg.Cell(n, l + 1).Value = null;
                                                    flag = 1;
                                                    break;
                                                }
                                            }
                                            if (flag == 1) break;
                                        }
                                        else
                                        {

                                            n++;
                                        }
                                    }
                                    or.Cell(j, 1).Value = cy.Cell(j, 1).Value;
                                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx"))
                                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx");
                                    orignal.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year + ".xlsx");
                                    orignal.Close();
                                    loc = (reg.Cell(k, a + 1).ValueAsInteger) / 10;
                                    tempo.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + loc + ".xlsx");
                                    Worksheet temp = tempo.Workbook.Worksheets.ByName("Sheet" + reg.Cell(k, a + 1).ValueAsInteger % 10);
                                    while (!String.IsNullOrEmpty(temp.Cell(m, 0).ValueAsString))
                                    {
                                        if (temp.Cell(m, 0).ValueAsString == reg.Cell(k, a).ValueAsString)
                                        {
                                            temp.Cell(m, 1).Value = "Shortage";
                                            break;
                                        }
                                        else m++;
                                    }
                                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + reg.Cell(k, a + 1).ValueAsInteger / 10 + ".xlsx"))
                                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + reg.Cell(k, a + 1).ValueAsInteger / 10 + ".xlsx");
                                    tempo.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + reg.Cell(k, a + 1).ValueAsInteger / 10 + ".xlsx");
                                    reg.Cell(k, a).Value = cy.Cell(j, 0).ValueAsString;
                                    reg.Cell(k, a + 1).Value = year.ToString() + i.ToString();
                                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx"))
                                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
                                    register.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\register.xlsx");
                                    return;
                                }


                            }
                            if (String.IsNullOrEmpty(reg.Cell(k, 0).ValueAsString)) 
                            {
                                or.Cell(j,1).Value = cy.Cell(j,1).ValueAsString;
                            }
                            k++;
                        }
                    }

                }

            }
        }
    }
    class allocation
    {
        public void createBlank_schedule()
        {
            int i, m = 1;
            String[] days = new String[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            Spreadsheet document = new Spreadsheet();

            Worksheet bs = document.Workbook.Worksheets.Add("Sheet1");
            bs.Cell(0, 0).Value = "Days";
            for (i = 0; i < 5; i++)
            {
                bs.Cell(m, 0).Value = days[i];
                bs.Cell(m + 1, 0).Value = "Staff";
                m += 2;
            }
            m = 1;
            for (i = 1; i <= 7; i++)
            {
                bs.Cell(0, m).Value = i;
                m += 1;
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\blank_schedule.xlsx"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\blank_schedule.xlsx");
            document.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\blank_schedule.xlsx");


        }
        public void final_alloc(int[] classes)
        {

            int i, j, m = 1, k, l, flag = 0, temp, loc, a, hours, t, avail, r=0, sec, n=0, elab = 0, x, b;
            //int[] classes=new int[4]{3,4,5,2};
            int[] year = new int[4] { 1, 2, 3, 4 };
            int[] day = new int[] { 1, 3, 5, 7, 9 };
            int[] hour = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] labs = new int[5] { 1156, 3176, 5196, 7116, 9136 };
            allocation pr = new allocation();
            teach_time teach_t = new teach_time();
            pr.shuffle(ref labs, 5);
            string sub, teach;
            Spreadsheet tlist = new Spreadsheet();
            Worksheet t_tab = tlist.Workbook.Worksheets.Add("Sheet1");
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx");
            tlist.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx");
            //pr.shuffle(ref year, ref classes, 4);
            Spreadsheet credit = new Spreadsheet();
            //Worksheet t_table=tlist.Workbook.Worksheets.ByName("Sheet1");
            credit.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Phase2.xlsx");

            for (i = 0; i < 4; i++)
            {
                //Worksheet cr = credit.Workbook.Worksheets.ByName(year[i].ToString());
                Spreadsheet class_list = new Spreadsheet();
                Spreadsheet tts = new Spreadsheet();
                int[] section = new int[classes[i]];
                a = 0;
                //int[] labs = new int[classes[i] * 2];
                for (j = 0; j < classes[i]; j++)
                {
                    section[j] = j + 1;
                }
                pr.shuffle(ref section, classes[i]);
                class_list.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year[i] + ".xlsx");
                tts.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i] + ".xlsx");
                for (j = 0; j < classes[i]; j++)
                {
                    Worksheet cl = class_list.Workbook.Worksheets.ByName("Sheet" + section[j].ToString());
                    Worksheet tt = tts.Workbook.Worksheets.ByName("Sheet" + section[j].ToString());
                    temp = 0;
                    m = 1;
                    elab = 0;
                    while (!String.IsNullOrEmpty(cl.Cell(m, 0).ValueAsString))
                    {
                        sub = cl.Cell(m, 0).ValueAsString;
                        teach = cl.Cell(m, 1).ValueAsString;
                        flag = 0;
                        for (k = 1; k <= 9; k += 2)
                        {
                            for (l = 1; l <= 7; l += 1)
                            {
                                if (sub == tt.Cell(k, l).ValueAsString)
                                {
                                    tt.Cell(k + 1, l).Value = teach;
                                    flag = 1;
                                    if (sub.IndexOf("Lab") >= 0)
                                    {
                                        elab = k * 10 + l;
                                    }
                                }
                            }
                        }
                        if (flag == 1)
                        {
                            m++;
                            if (sub.IndexOf("Lab") >= 0)
                            {
                                elab -= 1;
                                if (sub.IndexOf("Programming in ‘C’ Lab") >= 0) elab -= 1;
                                for (k = 0; k < 5; k++)
                                {
                                    if (labs[k] / 100 == elab)
                                    {
                                        elab = labs[k] % 100;
                                        break;
                                    }
                                    if (labs[k] % 100 == elab)
                                    {
                                        elab = labs[k] / 100;
                                        break;
                                    }
                                }
                            }
                            continue;
                        }
                        else
                        {
                            if (sub.IndexOf("Lab") >= 0)
                            {
                                if (elab > 0)
                                {
                                    tt.Cell(elab / 10, elab % 10).Value = sub;
                                    tt.Cell(elab / 10, elab % 10 + 1).Value = sub;
                                    tt.Cell(elab / 10 + 1, elab % 10).Value = teach;
                                    teach_t.available(teach, sub, elab, year[i] * 10 + section[j]);
                                    teach_t.available(teach, sub, elab + 1, year[i] * 10 + section[j]);
                                    if (sub.IndexOf("Programming in ‘C’ Lab") >= 0)
                                    {
                                        tt.Cell(elab / 10, elab % 10 + 2).Value = sub;
                                        teach_t.available(teach, sub, elab + 2, year[i] * 10 + section[j]);

                                    }
                                    m++;
                                    continue;
                                }
                                if (a > 5) a = 0;
                                if (temp <= 0)
                                {
                                    temp = labs[a];
                                    loc = temp % 100;
                                    temp = temp / 100;
                                    tt.Cell(loc / 10, loc % 10).Value = sub;
                                    tt.Cell(loc / 10, loc % 10 + 1).Value = sub;
                                    tt.Cell(loc / 10 + 1, loc % 10).Value = teach;
                                    teach_t.available(teach, sub, loc, year[i] * 10 + section[j]);
                                    teach_t.available(teach, sub, loc + 1, year[i] * 10 + section[j]);
                                    if (sub.IndexOf("Programming in ‘C’ Lab") >= 0)
                                    {
                                        tt.Cell(loc / 10, loc % 10 - 1).Value = sub;
                                        teach_t.available(teach, sub, loc - 1, year[i] * 10 + section[j]);

                                    }
                                    a++;
                                    m++;
                                    continue;
                                }
                                tt.Cell(temp / 10, temp % 10).Value = sub;
                                tt.Cell(temp / 10, temp % 10 + 1).Value = sub;
                                tt.Cell(temp / 10 + 1, temp % 10).Value = teach;
                                teach_t.available(teach, sub, temp, year[i] * 10 + section[j]);
                                teach_t.available(teach, sub, temp + 1, year[i] * 10 + section[j]);
                                if (sub.IndexOf("Programming in ‘C’ Lab") >= 0)
                                {
                                    tt.Cell(temp / 10, temp % 10 + 2).Value = sub;
                                    teach_t.available(teach, sub, temp + 2, year[i] * 10 + section[j]);
                                }
                            }
                            m++;
                        }

                    }
                }
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx");
                tts.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx");
            }

            for (i = 0; i < 4; i++)
            {
                Spreadsheet class_list = new Spreadsheet();
                Spreadsheet tts = new Spreadsheet();
                int[] section = new int[classes[i]];
                Worksheet cr = credit.Workbook.Worksheets.ByName(year[i].ToString());
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i] + "_copy.xlsx"))
                {
                    System.IO.File.Copy(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i] + ".xlsx", AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i] + "_copy.xlsx");
                    System.IO.File.Copy(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx", AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable_copy.xlsx");
                }

                if (r > 10 || n > 10)
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx");
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx");
                    System.IO.File.Move(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i] + "_copy.xlsx", AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i] + ".xlsx");
                    System.IO.File.Move(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable_copy.xlsx", AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx");
                }
                for (j = 0; j < classes[i]; j++)
                {
                    section[j] = j + 1;
                }
                pr.shuffle(ref section, classes[i]);
                class_list.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\ClassList\" + year[i] + ".xlsx");
                tts.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i] + ".xlsx");

                for (j = 0; j < classes[i]; j++)
                {

                    Worksheet cl = class_list.Workbook.Worksheets.ByName("Sheet" + section[j].ToString());
                    Worksheet tt = tts.Workbook.Worksheets.ByName("Sheet" + section[j].ToString());
                    for (x = 1; x <= 10; x += 1)
                    {
                        for (b = 1; b <= 7; b++)
                        {
                            if (tt.Cell(x, b).ValueAsString == "0")
                            {
                                tt.Cell(x, b).Value = "";
                            }
                        }
                    }

                    temp = 0;
                    m = 1;
                    while (!String.IsNullOrEmpty(cl.Cell(m, 0).ValueAsString))
                    {
                        sub = cl.Cell(m, 0).ValueAsString;
                        if (sub.IndexOf("Lab") >= 0)
                        {
                            m++;
                            continue;
                        }

                        teach = cl.Cell(m, 1).ValueAsString;

                        flag = 0;
                        for (k = 1; k <= 9; k += 2)
                        {
                            for (l = 1; l <= 7; l += 1)
                            {
                                if (sub == tt.Cell(k, l).ValueAsString)
                                {
                                    tt.Cell(k + 1, l).Value = teach;
                                    flag = 1;
                                }
                            }
                        }
                        if (flag == 1)
                        {
                            m++;
                            continue;
                        }
                        else
                        {
                            hours = cr.Cell(m - 1, 0).ValueAsInteger;
                            pr.shuffle(ref day, 5);
                            pr.shuffle(ref hour, 7);
                            r = 0;
                            n = 0;
                            for (t = 0; t < hours; t++)
                            {
                                loc = day[t] * 10 + hour[t];
                                //sflag = 0;
                                while (true)
                                {
                                    if ((!String.IsNullOrEmpty(tt.Cell(loc / 10, loc % 10).ValueAsString)))
                                    {
                                        if (loc % 10 >= 7)
                                        {
                                            loc = loc - 6;
                                            r += 1;
                                            if (r >= 2)
                                            {
                                                if (loc / 10 == 9) loc = 11;
                                                else loc += 20;
                                                if (r > 20)
                                                {
                                                    i--;
                                                    break;
                                                }
                                            }


                                        }

                                        else
                                        {
                                            loc += 1;
                                        }
                                        //loc += 1;
                                    }
                                    else
                                    {
                                        sec = year[i] * 10 + section[j];
                                        avail = teach_t.available(teach, sub, loc, sec);
                                        if (avail == 1)
                                        {

                                            tt.Cell(loc / 10, loc % 10).Value = sub;
                                            tt.Cell((loc / 10) + 1, loc % 10).Value = teach;
                                            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx"))
                                                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx");
                                            tts.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx");

                                            break;
                                        }
                                        else
                                        {
                                            if (loc % 10 >= 7)
                                            {
                                                loc = loc - 6;
                                                n += 1;
                                                if (n >= 2)
                                                {
                                                    if (loc / 10 == 9) loc = 11;
                                                    else loc += 20;
                                                    if (n > 20)
                                                    {
                                                        i--;
                                                        break;
                                                    }
                                                }

                                            }

                                            else
                                            {
                                                loc += 1;
                                            }
                                        }

                                    }
                                }
                                if (r > 20 || n > 20)
                                {
                                    break;
                                }
                            }
                            m++;
                            if (r > 20 || n > 20)
                            {
                                break;
                            }
                        }
                    }
                    if (r > 20 || n > 20)
                    {
                        break;
                    }
                }
                if (r > 20 || n > 20)
                {
                    tts.Close();
                }
                else
                {
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx"))
                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx");
                    tts.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + ".xlsx");
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TimeSchedule\" + year[i].ToString() + "_copy.xlsx");
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable_copy.xlsx");

                }

            }

        }
        public void shuffle(ref int[] section, int size)
        {
            int temp, i, var;
            Random rnd = new Random();
            for (i = 0; i < size; i++)
            {
                var = rnd.Next(0, size);
                temp = section[i];
                section[i] = section[var];
                section[var] = temp;

            }
        }
    }
    class teach_time
    {

        public int available(String teach, String sub, int loc, int section)
        {
            int j = 0, m, flag = 1;
            Spreadsheet t_list = new Spreadsheet();
            t_list.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx");
            Worksheet t = t_list.Workbook.Worksheets.ByName("Sheet1");
            while (true)
            {
                if (t.Cell(j, 0).ValueAsString == teach)
                {
                    m = 1;
                    while (!String.IsNullOrEmpty(t.Cell(j, m).ValueAsString))
                    {
                        if (t.Cell(j, m).ValueAsInteger == loc)
                        {
                            flag = 0;
                            break;
                        }
                        else m += 3;
                    }
                    if (flag == 1)
                    {
                        t.Cell(j, m).Value = loc;
                        t.Cell(j, m + 1).Value = sub;
                        t.Cell(j, m + 2).Value = section;
                        break;
                    }
                    else break;

                }
                if (String.IsNullOrEmpty(t.Cell(j, 0).ValueAsString))
                {
                    t.Cell(j, 0).Value = teach;
                    t.Cell(j, 1).Value = loc;
                    t.Cell(j, 2).Value = sub;
                    t.Cell(j, 3).Value = section;
                    flag = 1;
                    break;
                }
                j++;
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx");
            t_list.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx");
            return flag;
        }
    }
    class Summary
    {
        public void summary(String teach)
        {

            int m = 0, i = 1, loc, v, c;
            String sub, sem = "";
            Char cls;

            Spreadsheet t_table = new Spreadsheet();
            Spreadsheet b_table = new Spreadsheet();
            t_table.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\TeachersTable.xlsx");
            b_table.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Data\blank_schedule.xlsx");

            Worksheet tt = t_table.Workbook.Worksheets.ByName("Sheet1");
            Worksheet bt = b_table.Workbook.Worksheets.ByName("Sheet1");

            while (!String.IsNullOrEmpty(tt.Cell(m, 0).ValueAsString))
            {
                if (tt.Cell(m, 0).ValueAsString == teach)
                {
                    while (!String.IsNullOrEmpty(tt.Cell(m, i).ValueAsString))
                    {
                        loc = tt.Cell(m, i).ValueAsInteger;
                        sub = tt.Cell(m, i + 1).ValueAsString;
                        v = tt.Cell(m, i + 2).ValueAsInteger / 10;
                        switch (v)
                        {
                            case 1:
                                sem = "1st Year";
                                break;

                            case 2:
                                sem = "2nd Year";
                                break;
                            case 3:
                                sem = "3rd Year";
                                break;
                            case 4:
                                sem = "4th Year";
                                break;
                        }
                        c = (tt.Cell(m, i + 2).ValueAsInteger % 10) + 64;
                        cls = Convert.ToChar(c);
                        bt.Cell(loc / 10, loc % 10).Value = sub;
                        bt.Cell(loc / 10 + 1, loc % 10).Value = sem + ":Section " + cls;
                        i+=3;
                    }
                }
                m++;
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + teach + ".xlsx"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + teach + ".xlsx");
            b_table.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + teach + ".xlsx");

        }
    }
}
