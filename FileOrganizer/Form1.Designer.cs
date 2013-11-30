namespace FileOrganizer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toBox = new System.Windows.Forms.TextBox();
            this.MonitorBox = new System.Windows.Forms.TextBox();
            this.BrowseMonitor = new System.Windows.Forms.Button();
            this.ToButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.StartMonitor = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.autoStart = new System.Windows.Forms.CheckBox();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(83, 89);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(100, 20);
            this.toBox.TabIndex = 1;
            // 
            // MonitorBox
            // 
            this.MonitorBox.Location = new System.Drawing.Point(83, 37);
            this.MonitorBox.Name = "MonitorBox";
            this.MonitorBox.Size = new System.Drawing.Size(100, 20);
            this.MonitorBox.TabIndex = 0;
            // 
            // BrowseMonitor
            // 
            this.BrowseMonitor.Location = new System.Drawing.Point(197, 37);
            this.BrowseMonitor.Name = "BrowseMonitor";
            this.BrowseMonitor.Size = new System.Drawing.Size(75, 23);
            this.BrowseMonitor.TabIndex = 2;
            this.BrowseMonitor.Text = "Browse";
            this.BrowseMonitor.UseVisualStyleBackColor = true;
            this.BrowseMonitor.Click += new System.EventHandler(this.OpenFileDlg_Click);
            // 
            // ToButton
            // 
            this.ToButton.Location = new System.Drawing.Point(197, 89);
            this.ToButton.Name = "ToButton";
            this.ToButton.Size = new System.Drawing.Size(75, 23);
            this.ToButton.TabIndex = 3;
            this.ToButton.Text = "Browse";
            this.ToButton.UseVisualStyleBackColor = true;
            this.ToButton.Click += new System.EventHandler(this.OpenFileDlg_Click);
            // 
            // StartMonitor
            // 
            this.StartMonitor.Location = new System.Drawing.Point(197, 196);
            this.StartMonitor.Name = "StartMonitor";
            this.StartMonitor.Size = new System.Drawing.Size(75, 23);
            this.StartMonitor.TabIndex = 4;
            this.StartMonitor.Text = "Start";
            this.StartMonitor.UseVisualStyleBackColor = true;
            this.StartMonitor.Click += new System.EventHandler(this.StartMonitor_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.Location = new System.Drawing.Point(83, 196);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(108, 17);
            this.autoStart.TabIndex = 5;
            this.autoStart.Text = "Run On StartUp?";
            this.autoStart.UseVisualStyleBackColor = true;
            this.autoStart.CheckedChanged += new System.EventHandler(this.autoStart_CheckedChanged);
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(190, 226);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(82, 23);
            this.SaveSettings.TabIndex = 6;
            this.SaveSettings.Text = "Save Settings";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveSettings_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.autoStart);
            this.Controls.Add(this.StartMonitor);
            this.Controls.Add(this.ToButton);
            this.Controls.Add(this.BrowseMonitor);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.MonitorBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox MonitorBox;
        private System.Windows.Forms.Button BrowseMonitor;
        private System.Windows.Forms.Button ToButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button StartMonitor;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox autoStart;
        private System.Windows.Forms.Button SaveSettings;

    }
}

