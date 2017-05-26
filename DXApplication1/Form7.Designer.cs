namespace DXApplication1
{
    partial class Form7
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
            this.label2 = new System.Windows.Forms.Label();
            this.viewButton = new DevExpress.XtraEditors.SimpleButton();
            this.returnButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(552, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUMMARY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Location = new System.Drawing.Point(86, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Staff Name To View Individual Time Schedule :";
            // 
            // viewButton
            // 
            this.viewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.viewButton.Appearance.Options.UseFont = true;
            this.viewButton.Appearance.Options.UseForeColor = true;
            this.viewButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.viewButton.Location = new System.Drawing.Point(924, 497);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(272, 61);
            this.viewButton.TabIndex = 19;
            this.viewButton.Text = "VIEW SCHEDULE";
            this.viewButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // returnButton1
            // 
            this.returnButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.returnButton1.Appearance.Options.UseFont = true;
            this.returnButton1.Appearance.Options.UseForeColor = true;
            this.returnButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.returnButton1.Location = new System.Drawing.Point(51, 497);
            this.returnButton1.Name = "returnButton1";
            this.returnButton1.Size = new System.Drawing.Size(261, 61);
            this.returnButton1.TabIndex = 21;
            this.returnButton1.Text = "RETURN HOME";
            this.returnButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Select Staff Name";
            this.comboBoxEdit1.Location = new System.Drawing.Point(560, 245);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.AllowFocused = false;
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.comboBoxEdit1.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.comboBoxEdit1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxEdit1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxEdit1.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.comboBoxEdit1.Properties.HideSelection = false;
            this.comboBoxEdit1.Properties.HotTrackItems = false;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Albert",
            "Andrews",
            "Ankayarkanni",
            "Anusha",
            "Aroul",
            "Asha",
            "Ashok",
            "Bharathi",
            "Chandu",
            "Dhamodaran",
            "Godlin",
            "Jany",
            "Joshila",
            "Kamlesh",
            "Kavitha",
            "Lakshmanan",
            "Lakshmi",
            "Lydia",
            "Manju",
            "Mary",
            "Mercy",
            "Mohana",
            "Nagarajan",
            "Pravin",
            "Prayla",
            "Prem",
            "Prince",
            "Rajeesh",
            "Safiya",
            "Saravanan",
            "Sarika",
            "Shanthi",
            "Srinivasan",
            "Thenmozhi",
            "Ulagamuthalvi",
            "Usha",
            "Vigneswari",
            "Viji"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(378, 40);
            this.comboBoxEdit1.TabIndex = 22;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // Form7
            // 
            this.AcceptButton = this.viewButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 593);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.returnButton1);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Form7";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Schedule Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton viewButton;
        private DevExpress.XtraEditors.SimpleButton returnButton1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}