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
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Location = new System.Drawing.Point(23, 63);
            this.mainTabControl.Name = "metroTabControl1";
            this.mainTabControl.Size = new System.Drawing.Size(1039, 50);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.UseSelectable = true;
            // 
            // Butler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 495);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Butler Settings";
            this.Text = "Butler Settings";
            this.Load += new System.EventHandler(this.Butler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTabControl mainTabControl;
    }
}

