
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
    public partial class AreasManagerForm : Form
    {
        Area area;
        AnalyzeImages analyze = new AnalyzeImages();
        private bool _readingAreaPoints = false;
        CustomizedToolTip myToolTip = new CustomizedToolTip();



        public AreasManagerForm(Area area)
        {
            InitializeComponent();
            this.area = area;
            this.Focus();
            myToolTip.SetToolTip(previewPictureBox, "Preview");
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
                    if(IsNotTheSamePoint(area.StartPositionX, area.StartPositionY, Cursor.Position.X, Cursor.Position.Y))
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

                        previewPictureBox.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        MessageBox.Show("You have to capture two different poinsts!");
                    }
                    
                }
            }
        }

        private bool IsNotTheSamePoint(int x1, int y1, int x2, int y2)
        {
            if(x1 != x2 && y1 != y2)
            {
                return true;
            }
            else
            {
                return false;
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
            
            
            dimensionsValueLabel.Text = " No bitmap captured";
            startPositionValueLabel.Text = "  Go to start point and press S key. Then go to end point and press E key";
            previewPictureBox.Tag = null;
            myToolTip.AutoSize = true;
            previewPictureBox.BackColor = Color.Firebrick;
            nameTextBox.Enabled = false;
        }

        public void CaptureAndShowArea()
        {
            analyze.MakeScreenShot(area);
            previewPictureBox.Tag = area.Bitmap;
            myToolTip.AutoSize = false;
            myToolTip.Size = area.Bitmap.Size;
            myToolTip.ToolTipTitle = " ";
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

        private void AreasManagerForm_MouseDown(object sender, MouseEventArgs e)
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

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "Type a name here...")
            {
                nameTextBox.Text = "";
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameTextBox.Text = "Type a name here...";
            }
        }

  
    }


}
