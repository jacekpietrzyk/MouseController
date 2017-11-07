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

        Area actionArea = new Area();
        Area conditionalArea = new Area();
        Area compareAction = new Area();
        Area compareConditional = new Area();

        int resultCounter = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        public Form1()
        {
            InitializeComponent();
            CreateTemporaryFilesDirectory();
            CreateUserDirectory();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if(analyze.AreaNotEmpty(conditionalArea) && analyze.AreaNotEmpty(actionArea))
            {
                runTimer.Enabled = true;
                FillAreasToScreenCompare();
            }
        }
        
        public void FillAreasToScreenCompare()
        {
            compareAction.StartPositionX = actionArea.StartPositionX;
            compareAction.StartPositionY = actionArea.StartPositionY;
            compareAction.Width = actionArea.Width;
            compareAction.Height = actionArea.Height;

            compareConditional.StartPositionX = conditionalArea.StartPositionX;
            compareConditional.StartPositionY = conditionalArea.StartPositionY;
            compareConditional.Width = conditionalArea.Width;
            compareConditional.Height = conditionalArea.Height;
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

        private void actionAreaButton_Click(object sender, EventArgs e)
        {
            RegisterAreaForm form = new RegisterAreaForm(actionArea);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                actionAreaButton.Text = "Saved";
            }
        }
       
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
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

        private void conditionalAreaButton_Click(object sender, EventArgs e)
        {
            using (RegisterAreaForm form = new RegisterAreaForm(conditionalArea))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    conditionalAreaButton.Text = "Saved";
                }
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            conditionalAreaButton.Text = "Select the conditional area";
            actionAreaButton.Text = "Select the action area";
            actionArea = new Area();
            conditionalArea = new Area();
        }

        private void runTimer_Tick(object sender, EventArgs e)
        {
            analyze.MakeScreenShot(compareConditional);
            if(analyze.Compare(conditionalArea.Bitmap, compareConditional.Bitmap) == 0)
            {
                resultLabel.Text = String.Format("Result: {0} task completed", resultCounter+1);
                RealizeClick(conditionalArea);
            }
            
        }
        public void RealizeClick(Area area)
        {
            Mouse.Instance.Location = new System.Windows.Point(area.ClickX, area.ClickY);
            Thread.Sleep(1500);
            Mouse.Instance.Click();
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            runTimer.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void conditionalAreaButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Select the conditional area";
        }

        private void conditionalAreaButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void actionAreaButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Select the main action area";
        }

        private void actionAreaButton_MouseLeave(object sender, EventArgs e)
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
        #endregion

    }

    
}
