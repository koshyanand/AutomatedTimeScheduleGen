namespace DXApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.previousButton = new DevExpress.XtraEditors.SimpleButton();
            this.nextButton = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oddButton = new System.Windows.Forms.RadioButton();
            this.evenButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.teachersPathTextBox1 = new System.Windows.Forms.TextBox();
            this.subPathTextBox2 = new System.Windows.Forms.TextBox();
            this.browseButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.browseButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.exitButton.Appearance.Options.UseFont = true;
            this.exitButton.Appearance.Options.UseForeColor = true;
            this.exitButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(60, 539);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(188, 59);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.previousButton.Appearance.Options.UseFont = true;
            this.previousButton.Appearance.Options.UseForeColor = true;
            this.previousButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.previousButton.Location = new System.Drawing.Point(820, 539);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(170, 47);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "PREVIOUS";
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.nextButton.Appearance.Options.UseFont = true;
            this.nextButton.Appearance.Options.UseForeColor = true;
            this.nextButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.nextButton.Location = new System.Drawing.Point(1091, 539);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(159, 47);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "NEXT";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Location = new System.Drawing.Point(93, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Paths :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select path for Teacher\'s List  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select path for Subjects\'s List :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Location = new System.Drawing.Point(93, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select series of Semesters :";
            // 
            // oddButton
            // 
            this.oddButton.AutoSize = true;
            this.oddButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oddButton.Location = new System.Drawing.Point(269, 408);
            this.oddButton.Name = "oddButton";
            this.oddButton.Size = new System.Drawing.Size(181, 33);
            this.oddButton.TabIndex = 8;
            this.oddButton.TabStop = true;
            this.oddButton.Text = "Odd Semesters";
            this.oddButton.UseVisualStyleBackColor = true;
            this.oddButton.CheckedChanged += new System.EventHandler(this.oddButton_CheckedChanged);
            // 
            // evenButton
            // 
            this.evenButton.AutoSize = true;
            this.evenButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenButton.Location = new System.Drawing.Point(269, 470);
            this.evenButton.Name = "evenButton";
            this.evenButton.Size = new System.Drawing.Size(186, 33);
            this.evenButton.TabIndex = 9;
            this.evenButton.TabStop = true;
            this.evenButton.Text = "Even Semesters";
            this.evenButton.UseVisualStyleBackColor = true;
            this.evenButton.CheckedChanged += new System.EventHandler(this.evenButton_CheckedChanged);
            // 
            // teachersPathTextBox1
            // 
            this.teachersPathTextBox1.Location = new System.Drawing.Point(618, 152);
            this.teachersPathTextBox1.Name = "teachersPathTextBox1";
            this.teachersPathTextBox1.Size = new System.Drawing.Size(336, 23);
            this.teachersPathTextBox1.TabIndex = 10;
            this.teachersPathTextBox1.TextChanged += new System.EventHandler(this.teachersPathTextBox1_TextChanged);
            // 
            // subPathTextBox2
            // 
            this.subPathTextBox2.Location = new System.Drawing.Point(618, 243);
            this.subPathTextBox2.Name = "subPathTextBox2";
            this.subPathTextBox2.Size = new System.Drawing.Size(336, 23);
            this.subPathTextBox2.TabIndex = 11;
            this.subPathTextBox2.TextChanged += new System.EventHandler(this.subPathTextBox2_TextChanged);
            // 
            // browseButton1
            // 
            this.browseButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.browseButton1.Appearance.Options.UseFont = true;
            this.browseButton1.Appearance.Options.UseForeColor = true;
            this.browseButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.browseButton1.Location = new System.Drawing.Point(1055, 146);
            this.browseButton1.Name = "browseButton1";
            this.browseButton1.Size = new System.Drawing.Size(124, 41);
            this.browseButton1.TabIndex = 12;
            this.browseButton1.Text = "Browse";
            this.browseButton1.Click += new System.EventHandler(this.browseButton1_Click);
            // 
            // browseButton2
            // 
            this.browseButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton2.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.browseButton2.Appearance.Options.UseFont = true;
            this.browseButton2.Appearance.Options.UseForeColor = true;
            this.browseButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.browseButton2.Location = new System.Drawing.Point(1055, 237);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Size = new System.Drawing.Size(124, 41);
            this.browseButton2.TabIndex = 13;
            this.browseButton2.Text = "Browse";
            this.browseButton2.Click += new System.EventHandler(this.browseButton2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1312, 633);
            this.Controls.Add(this.browseButton2);
            this.Controls.Add(this.browseButton1);
            this.Controls.Add(this.subPathTextBox2);
            this.Controls.Add(this.teachersPathTextBox1);
            this.Controls.Add(this.evenButton);
            this.Controls.Add(this.oddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.exitButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Schedule Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.SimpleButton previousButton;
        private DevExpress.XtraEditors.SimpleButton nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton oddButton;
        private System.Windows.Forms.RadioButton evenButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox teachersPathTextBox1;
        private System.Windows.Forms.TextBox subPathTextBox2;
        private DevExpress.XtraEditors.SimpleButton browseButton1;
        private DevExpress.XtraEditors.SimpleButton browseButton2;
    }
}