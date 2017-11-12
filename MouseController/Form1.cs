using System;
using System.Windows.Forms;
using System.Threading;
using TestStack.White.InputDevices;
using System.Windows;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace MouseController
{
   
    public partial class Form1 : Form
    {
        AnalyzeImages analyze = new AnalyzeImages();
        WorkProfile profile = new WorkProfile();

        

        Area area = new Area();
        Area compareArea = new Area();
        

        int resultCounter = 0;
        
        public Form1()
        {
            InitializeComponent();
            CreateTemporaryFilesDirectory();
            CreateUserDirectory();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            List<Area> areas = profile.GetAreas();
            if(areas.Count != 0)
            {
                runTimer.Enabled = true;
                //FillAreasToScreenCompare();
            }
        }
        
        public void FillAreasToScreenCompare(Area area, Area compareArea)
        {
            compareArea.StartPositionX = area.StartPositionX;
            compareArea.StartPositionY = area.StartPositionY;
            compareArea.Width = area.Width;
            compareArea.Height = area.Height;

           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save this profile?", "Save the settings", MessageBoxButtons.YesNoCancel);

            if ( result == DialogResult.No)
            {
                this.Dispose();
            }
            else if (result == DialogResult.Yes)
            {
                //serialize and save
            }
            
        }


        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void CreateTemporaryFilesDirectory()
        {
            Constans.FilesDirectory = new System.IO.DirectoryInfo(Path.Combine(Path.GetTempPath(), Properties.Settings.Default.TempFilesFolderName));

            try
            {
                if (!Directory.Exists(Constans.FilesDirectory.ToString()))
                {
                    Directory.CreateDirectory(Constans.FilesDirectory.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void CreateUserDirectory()
        {
            Constans.UserSettings = new System.IO.DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Properties.Settings.Default.UserSettingFolderName));

            try
            {
                if (!Directory.Exists(Constans.UserSettings.ToString()))
                {
                    Directory.CreateDirectory(Constans.UserSettings.ToString());
                }
            }
            catch (System.IO.IOException IOex)
            {
                MessageBox.Show(IOex.Message.ToString());
            }
            catch (System.UnauthorizedAccessException UAex)
            {
                MessageBox.Show(UAex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

       

        private void resetButton_Click(object sender, EventArgs e)
        {
            areaButton.Text = "Select the conditional area";
            activityButton.Text = "Select the action area";
            area = new Area();
            compareArea  = new Area();
        }

        private void runTimer_Tick(object sender, EventArgs e)
        {
            //CompareAreas();
            
        }
        public bool CompareAreas(Area conditionalArea, Area compareArea)
        {
            analyze.MakeScreenShot(compareArea);
            if (analyze.Compare(conditionalArea.Bitmap, compareArea.Bitmap) == 0)
            {
                resultLabel.Text = String.Format("Result: {0} task completed", resultCounter + 1);
                
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void stopButton_Click(object sender, EventArgs e)
        {
            runTimer.Enabled = false;
        }
        
        private void areaButton_Click(object sender, EventArgs e)
        {
            Area newArea = new Area();

            AreasManagerForm form = new AreasManagerForm(newArea);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                profile.AddArea(newArea);
            }
            
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            profile.BeginEdit();
            ActivitiesManagerForm form = new ActivitiesManagerForm(profile.Activities, profile.Areas);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                profile.EndEdit();
            }
            else if (form.DialogResult == DialogResult.Cancel)
            {
                profile.CancelEdit();
            }

        }
        #region MouseHover

        private void openButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Open existing Mouse Controller profile";
        }

        private void openButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void resetButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Erase all current settings";
        }

        private void resetButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }
        
        private void actionSettingsButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Action Settings";
        }

        private void actionSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void runButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Start to check the conditional area";
        }

        private void runButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void stopButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Stop checking the conditional area";
        }

        private void stopButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Close the application";
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }
        private void activityButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void activityButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Define a new action ";
        }

        private void areaButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Define a new area";
        }

        private void areaButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        #endregion

    
    }

    
}
