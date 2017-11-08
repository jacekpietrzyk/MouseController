
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MouseController
{
    public partial class RegisterAreaForm : Form
    {
        Area area;
        AnalyzeImages analyze = new AnalyzeImages();
        private bool _readingAreaPoints = false;
        CustomizedToolTip myToolTip = new CustomizedToolTip();



        public RegisterAreaForm(Area area)
        {
            InitializeComponent();
            this.area = area;
            this.Focus();
            myToolTip.SetToolTip(previewPictureBox, " ");
            myToolTip.InitialDelay = 1;
            
            

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            mouseToolStripStatusLabel.Text = String.Format("Mouse position: X {0},   Y {1}  ", Cursor.Position.X.ToString(), Cursor.Position.Y.ToString());
        }

        private void RegisterAreaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (_readingAreaPoints == true)
            {
                if (e.KeyCode == Keys.S)
                {
                    area.StartPositionX = Cursor.Position.X;
                    area.StartPositionY = Cursor.Position.Y;
                }
                if (e.KeyCode == Keys.E)
                {
                    area.Width = Math.Abs(Cursor.Position.X - area.StartPositionX);
                    area.Height = Math.Abs(Cursor.Position.Y - area.StartPositionY);
                    area.StartPositionX = Math.Min(area.StartPositionX, Cursor.Position.X);
                    area.StartPositionY = Math.Min(area.StartPositionY, Cursor.Position.Y);

                    startPositionValueLabel.Text = "X: " + area.StartPositionX + "  Y: " + area.StartPositionY;
                    dimensionsValueLabel.Text = "Width: " + area.Width + ",  Height: " + area.Height;

                    acceptButton.Enabled = true;
                    resetButton.Enabled = true;
                    nameTextBox.Enabled = true;
                    CaptureAndShowArea();
                    _readingAreaPoints = false;

                    
                    
                }
            }
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nameTextBox.Text) && nameTextBox.Text != "Type a name here...")
            {
                area.Name = nameTextBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Name value can not be default or empty!");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            CleanAreaObject();
            acceptButton.Enabled = false;
            resetButton.Enabled = false;
            captureButton.Enabled = true;
            
            areaPictureBox.ImageLocation = null;
            dimensionsValueLabel.Text = "  Go to destination point end press E key";
            startPositionValueLabel.Text = " Go to destination point end press S key";
        }

        public void CaptureAndShowArea()
        {
            analyze.MakeScreenShot(area);
            previewPictureBox.Tag = area.Bitmap;
            myToolTip.AutoSize = false;
            myToolTip.Size = area.Bitmap.Size;
            

            areaPictureBox.Image = area.Bitmap;
        }
        
        public void CleanAreaObject()
        {
            area = new Area();
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            _readingAreaPoints = true;
            captureButton.Enabled = false;
            nameTextBox.Enabled = false;
        }


        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void RegisterAreaForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterAreaForm_Shown(object sender, EventArgs e)
        {
            
            
        }
    }


}
