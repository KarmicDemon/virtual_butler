namespace Butler_Settings
{
    partial class Butler
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.butlerSettings = new MetroFramework.Controls.MetroTabPage();
            this.desktopSettings = new MetroFramework.Controls.MetroTabPage();
            this.settings = new MetroFramework.Controls.MetroTabPage();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.butlerSettings);
            this.mainTabControl.Controls.Add(this.desktopSettings);
            this.mainTabControl.Controls.Add(this.settings);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(23, 63);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(730, 50);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.UseSelectable = true;
            // 
            // butlerSettings
            // 
            this.butlerSettings.HorizontalScrollbarBarColor = true;
            this.butlerSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.butlerSettings.HorizontalScrollbarSize = 20;
            this.butlerSettings.Location = new System.Drawing.Point(4, 38);
            this.butlerSettings.Name = "butlerSettings";
            this.butlerSettings.Size = new System.Drawing.Size(722, 8);
            this.butlerSettings.TabIndex = 0;
            this.butlerSettings.VerticalScrollbarBarColor = true;
            this.butlerSettings.VerticalScrollbarHighlightOnWheel = false;
            this.butlerSettings.VerticalScrollbarSize = 10;
            // 
            // desktopSettings
            // 
            this.desktopSettings.HorizontalScrollbarBarColor = true;
            this.desktopSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.desktopSettings.HorizontalScrollbarSize = 10;
            this.desktopSettings.Location = new System.Drawing.Point(4, 38);
            this.desktopSettings.Name = "desktopSettings";
            this.desktopSettings.Size = new System.Drawing.Size(1031, 8);
            this.desktopSettings.TabIndex = 1;
            this.desktopSettings.VerticalScrollbarBarColor = true;
            this.desktopSettings.VerticalScrollbarHighlightOnWheel = false;
            this.desktopSettings.VerticalScrollbarSize = 10;
            // 
            // settings
            // 
            this.settings.HorizontalScrollbarBarColor = true;
            this.settings.HorizontalScrollbarHighlightOnWheel = false;
            this.settings.HorizontalScrollbarSize = 10;
            this.settings.Location = new System.Drawing.Point(4, 38);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(1031, 8);
            this.settings.TabIndex = 2;
            this.settings.VerticalScrollbarBarColor = true;
            this.settings.VerticalScrollbarHighlightOnWheel = false;
            this.settings.VerticalScrollbarSize = 10;
            // 
            // Butler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 432);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Butler";
            this.Text = "Butler Settings";
            this.Load += new System.EventHandler(this.Butler_Load);
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTabPage butlerSettings;
        private MetroFramework.Controls.MetroTabPage desktopSettings;
        private MetroFramework.Controls.MetroTabPage settings;
    }
}

