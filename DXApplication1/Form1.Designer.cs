namespace DXApplication1
{
    partial class Form1
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DXApplication1.MainLogo), true, false);
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame7 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame8 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            this.label1 = new System.Windows.Forms.Label();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(456, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIME SCHEDULE GENERATOR";
            // 
            // tileControl1
            // 
            this.tileControl1.AppearanceText.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl1.AppearanceText.Options.UseFont = true;
            this.tileControl1.CausesValidation = false;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.ItemSize = 185;
            this.tileControl1.Location = new System.Drawing.Point(193, 306);
            this.tileControl1.MaxId = 4;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(396, 272);
            this.tileControl1.TabIndex = 4;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.Click += new System.EventHandler(this.tileControl1_Click_1);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = null;
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Purple;
            this.tileItem1.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem1.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.tileItem1.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileItem1.BackgroundImage = global::DXApplication1.Properties.Resources.d5177ba8_392c_48fe_adb2_397eb2b59084;
            this.tileItem1.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement13.Text = "Generate Schedule";
            tileItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            this.tileItem1.Elements.Add(tileItemElement13);
            this.tileItem1.FrameAnimationInterval = 2000;
            tileItemFrame7.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown;
            tileItemFrame7.BackgroundImage = global::DXApplication1.Properties.Resources.d5177ba8_392c_48fe_adb2_397eb2b59084;
            tileItemElement14.Text = "Generate Schedule";
            tileItemFrame7.Elements.Add(tileItemElement14);
            this.tileItem1.Frames.Add(tileItemFrame7);
            this.tileItem1.Id = 0;
            this.tileItem1.Name = "tileItem1";
            // 
            // tileControl2
            // 
            this.tileControl2.Groups.Add(this.tileGroup3);
            this.tileControl2.ItemSize = 165;
            this.tileControl2.Location = new System.Drawing.Point(824, 338);
            this.tileControl2.MaxId = 1;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Size = new System.Drawing.Size(444, 214);
            this.tileControl2.TabIndex = 5;
            this.tileControl2.Text = "tileControl2";
            this.tileControl2.Click += new System.EventHandler(this.tileControl2_Click);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem2);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = null;
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Hovered.BackColor = System.Drawing.Color.SeaShell;
            this.tileItem2.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.Indigo;
            this.tileItem2.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.AntiqueWhite;
            this.tileItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement15.Text = "View Summary";
            this.tileItem2.Elements.Add(tileItemElement15);
            this.tileItem2.FrameAnimationInterval = 1500;
            tileItemFrame8.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollRight;
            tileItemElement16.Text = "View Summary";
            tileItemFrame8.Elements.Add(tileItemElement16);
            this.tileItem2.Frames.Add(tileItemFrame8);
            this.tileItem2.Id = 0;
            this.tileItem2.IsLarge = true;
            this.tileItem2.Name = "tileItem2";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Harlow Solid Italic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.OldLace;
            this.Welcome.Location = new System.Drawing.Point(120, 164);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(240, 61);
            this.Welcome.TabIndex = 6;
            this.Welcome.Text = "Welcome ,";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1495, 695);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.tileControl2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Schedule Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private System.Windows.Forms.Label Welcome;
      





    }
}

