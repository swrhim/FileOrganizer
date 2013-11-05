using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOrganizer
{
    public partial class Form1 : Form
    {
        #region global constants

        const string MONITOR_BROWSE_BUTTON = "BrowseMonitor";
        const string TO_BROWSE_BUTTON = "ToButton";

        #endregion 

        #region globals

        FileSystemWatcher watcher;

        #endregion

        public Form1()
        {
            InitializeComponent();

            //initialize the filesystem watcher
            watcher = new FileSystemWatcher();
            
            //TODO: Remember to dispose of the object when it is done.
            
#if DEBUG
            this.MonitorBox.Text = @"C:\Users\Daniel\Downloads\TEST";
            this.toBox.Text = @"C:\Users\Daniel\Desktop\Testmove";
#endif
            
        }

        /// <summary>
        /// event handler for the browse button for monitor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileDlg_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    var button = (Button)sender;
                    switch(button.Name)
                    {
                        case MONITOR_BROWSE_BUTTON:
                            this.MonitorBox.Text = folderBrowserDialog.SelectedPath;
                            break;
                        case TO_BROWSE_BUTTON:
                            this.toBox.Text = folderBrowserDialog.SelectedPath;
                            break;
                        default:
                            break;
                    }
                }
                    //TODO:Error handler?
                catch(Exception ex){
                }

            }
        }

        /// <summary>
        /// Button click to initaite file movement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartMonitor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.MonitorBox.Text))
            {
                //there is no text!
            }

            watcher.Path = this.MonitorBox.Text;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            //specify which types of files to monitor here

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
        }

        /// <summary>
        /// Event for renamed files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// event for new files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.toBox.Text))
            {
                //to box is empty!
            }

            //try to get a lock on the file
            while(IsFileLockd(e.FullPath))
            {
                Console.WriteLine("waiting...");
                Thread.Sleep(1000);
            }

            //if we're out of the loop then the file is not locked
            File.Move(e.FullPath, this.toBox.Text);

        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.watcher != null)
                this.watcher.Dispose();
        }

        #region private helpers

        private static bool IsFileLockd(string fileName)
        {
            try
            {
                using (var inputStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    return false;    
                }
            }
            catch (IOException)
            {
                return true;
            }
        }

        #endregion

    }
}
