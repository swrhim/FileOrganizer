using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        public Form1()
        {
            InitializeComponent();
            
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

        }
    }
}
