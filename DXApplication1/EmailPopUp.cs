using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;


namespace DXApplication1
{
    public partial class EmailPopUp : DevExpress.XtraEditors.XtraForm
    {
        string email;
        string name;
        string filename;
        Form8 frm = new Form8();
        

        public EmailPopUp(Form8 incForm, string nm, string file)
        {
            frm = incForm;
            name = nm;
            filename = file;
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            email = textEdit1.Text;
        }
       
        private void emailButton_Click(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Staff Schedules\testAttatchment.txt";
            StreamWriter sw = File.CreateText(path);
            sw.Close();
            Attachment global = new Attachment(path);
            global.Dispose();

            try
            { 
            if (RegularExpression.checkForEmail(email))
            {
                
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);

                mail.From = new MailAddress("timeschedule54@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Academeic Year Time Schedule";
                mail.Body = "Dear " + name + "," + "\n\n\t\t Please find the attachment to view your respective Academic Year Time Schedule. \n\nThanks & Regards";

                SmtpServer.Credentials = new System.Net.NetworkCredential("timeschedule54@gmail.com", "ourfirstapp");
                SmtpServer.EnableSsl = true;

                
                Attachment data = new Attachment(filename);
                global = data;
                mail.Attachments.Add(data);

               
                splashScreenManager1.ShowWaitForm();
                SmtpServer.Send(mail);
                splashScreenManager1.CloseWaitForm();
                
                MessageBox.Show("Email Sent to " + name);
                data.Dispose();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Type a valid Email-Id");
            }

           }
            catch(SmtpException ex)
            {
                
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("No Internet Connection Detected !");
                global.Dispose();
                this.Close();

            }


        }

        private void EmailPopUp_Load(object sender, EventArgs e)
        {

        }

       
    }
}