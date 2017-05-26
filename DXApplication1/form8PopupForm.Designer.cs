namespace DXApplication1
{
    partial class form8PopupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.openFolderbutton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Location = new System.Drawing.Point(42, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 23;
            // 
            // okButton
            // 
            this.okButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.okButton.Appearance.Options.UseFont = true;
            this.okButton.Appearance.Options.UseForeColor = true;
            this.okButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.okButton.Location = new System.Drawing.Point(586, 282);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(140, 50);
            this.okButton.TabIndex = 25;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // openFolderbutton
            // 
            this.openFolderbutton.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolderbutton.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.openFolderbutton.Appearance.Options.UseFont = true;
            this.openFolderbutton.Appearance.Options.UseForeColor = true;
            this.openFolderbutton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.openFolderbutton.Location = new System.Drawing.Point(347, 282);
            this.openFolderbutton.Name = "openFolderbutton";
            this.openFolderbutton.Size = new System.Drawing.Size(178, 50);
            this.openFolderbutton.TabIndex = 26;
            this.openFolderbutton.Text = "OPEN FOLDER";
            this.openFolderbutton.Click += new System.EventHandler(this.openFolderbutton_Click);
            // 
            // form8PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 371);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.openFolderbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form8PopupForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saved !";
            this.Load += new System.EventHandler(this.form8PopupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton openFolderbutton;
    }
}