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
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace MouseController
{
   
    public partial class MainForm : Form
    {
        AnalyzeImages analyze = new AnalyzeImages();
        WorkProfile profile = new WorkProfile();
        
        Area area = new Area();
        Area compareArea = new Area();
        
        int resultCounter = 0;
        
        public MainForm()
        {
            AddDefaultFont();
            InitializeComponent();
            CreateTemporaryFilesDirectory();
            CreateUserDirectory();
            WriteSampleData();
        }
        

        public void AddDefaultFont()
        {

            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.gulim.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.gulim;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);


            //PrivateFontCollection pfc = new PrivateFontCollection();

            //using (Stream fontStream = GetType().Assembly.GetManifestResourceStream(@"C:\Users\Jacek\Desktop\MouseController\MouseController\Resources\gulim.ttc"))
            //{
            //    if (null == fontStream)
            //    {
            //        return;
            //    }

            //    int fontStreamLength = (int)fontStream.Length;

            //    IntPtr data = Marshal.AllocCoTaskMem(fontStreamLength);

            //    byte[] fontData = new byte[fontStreamLength];
            //    fontStream.Read(fontData, 0, fontStreamLength);

            //    Marshal.Copy(fontData, 0, data, fontStreamLength);

            //    pfc.AddMemoryFont(data, fontStreamLength);

            //    Marshal.FreeCoTaskMem(data);
            //}
        }
        public void WriteSampleData()
        {

            Area area = new Area
            {
                Bitmap = analyze.MakeScreenShot(new Area
                {
                    StartPositionX = 10,
                    StartPositionY = 10,
                    Height = 100,
                    Width = 300
                }),
                StartPositionX = 10,
                StartPositionY = 10,
                Height = 100,
                Width = 300,
                Name = "Przykładowy obszar"
            };
            profile.Areas.Add(area);

            Area area2 = new Area
            {
                Bitmap = analyze.MakeScreenShot(new Area
                {
                    StartPositionX = 300,
                    StartPositionY = 300,
                    Height = 200,
                    Width = 200
                }),
                StartPositionX = 300,
                StartPositionY = 300,
                Height = 200,
                Width = 200,
                Name = "Inny obraz"
            };
            profile.Areas.Add(area2);


            Activity act1 = new Activity { Name = "Przykład 1" };
            Activity act2 = new Activity { Name = "Przykład 2" };

            ClickAction action1 = new ClickAction { Name = "Akcja Click", DelayTime = 1000, Active = true };
            ClickAction action2 = new ClickAction { Name = "Akcja Click Inna", DelayTime = 1000, Active = true };
            MoveAction action3 = new MoveAction(area) { Name = "Akcja Move", DelayTime = 2000, Active = true };

            act1.AddAction(action1);
            act1.AddAction(action3);
            act2.AddAction(action2);

            profile.Activities.Add(act1);
            profile.Activities.Add(act2);

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            runTimer.Enabled = true;
            // TO DO
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
                //serialize and save profile object
            }
            
        }
        
        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        private void toolStrip1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainFormPanel_MouseDown(object sender, MouseEventArgs e)
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
            profile = new WorkProfile();
        }

        private void runTimer_Tick(object sender, EventArgs e)
        {
            //TO DO
            
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
        
        private void areasManagerButton_Click(object sender, EventArgs e)
        {
            profile.BeginEdit();

            using (AreasManagerForm form = new AreasManagerForm(profile))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    profile.EndEdit();
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    profile.CancelEdit();
                }
            }
        }

        private void activitiesManagerButton_Click(object sender, EventArgs e)
        {
            profile.BeginEdit();

            using (ActivitiesManagerForm form = new ActivitiesManagerForm(profile))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    profile.EndEdit();
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    profile.CancelEdit();
                }
            }
        }

        #region Mouse Hover Events

        private void openButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Open existing Mouse Controller work profile";
        }

        private void openButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void resetButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Clean work profile";
        }

        private void resetButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }
        
        private void actionSettingsButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Connect areas with activities";
        }

        private void actionSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void runButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Run";
        }

        private void runButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void stopButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Stop current work process";
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
        private void activitiesManagerButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void activitiesManagerButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Open Activities Manager";
        }

        private void areasManagerButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Open Areas Manager";
        }

        private void areasManagerButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }




        #endregion

        
    }

    
}
