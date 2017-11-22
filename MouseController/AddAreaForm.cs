using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseController
{
    public partial class AddAreaForm : Form
    {
        ObservableCollection<Area> areas;
        AnalyzeImages analyze = new AnalyzeImages();
        private bool _readingAreaPoints = false;
        CustomizedToolTip myToolTip = new CustomizedToolTip();
        Area newArea;


        public AddAreaForm(ObservableCollection<Area> areas)
        {
            InitializeComponent();

            this.areas = areas;
            this.Focus();
            myToolTip.SetToolTip(previewPictureBox, "Preview disabled");
            myToolTip.InitialDelay = 1;
            timer.Enabled = true;
        }

        public void CaptureAndShowArea()
        {
            try
            {
                analyze.AddScreenShotToArea(newArea);
                previewPictureBox.Tag = newArea.Bitmap;
                myToolTip.AutoSize = false;
                myToolTip.Size = newArea.Bitmap.Size;
                myToolTip.ToolTipTitle = " ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception occurred");
            }
        }

        public void CleanAreaObject()
        {
            newArea = new Area();
        }

        private bool IsNotTheSamePoint(int x1, int y1, int x2, int y2)
        {
            if (x1 != x2 && y1 != y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            _readingAreaPoints = true;
            captureButton.Enabled = false;
            nameTextBox.Enabled = false;
            cancelButton.Enabled = false;
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Type a name here...")
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

        private void AddAreaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (_readingAreaPoints == true)
            {
                if (e.KeyCode == Keys.Home)
                {
                    newArea = new Area();
                    newArea.StartPositionX = Cursor.Position.X;
                    newArea.StartPositionY = Cursor.Position.Y;
                }
                if (e.KeyCode == Keys.End)
                {
                    if (IsNotTheSamePoint(newArea.StartPositionX, newArea.StartPositionY, Cursor.Position.X, Cursor.Position.Y))
                    {
                        newArea.Width = Math.Abs(Cursor.Position.X - newArea.StartPositionX);
                        newArea.Height = Math.Abs(Cursor.Position.Y - newArea.StartPositionY);
                        newArea.StartPositionX = Math.Min(newArea.StartPositionX, Cursor.Position.X);
                        newArea.StartPositionY = Math.Min(newArea.StartPositionY, Cursor.Position.Y);

                        startPositionValueLabel.Text = "X: " + newArea.StartPositionX + "  Y: " + newArea.StartPositionY;
                        dimensionsValueLabel.Text = "Width: " + newArea.Width + ",  Height: " + newArea.Height;

                        acceptButton.Enabled = true;
                        cancelButton.Enabled = true;
                        resetButton.Enabled = true;
                        nameTextBox.Enabled = true;
                        try
                        {
                            CaptureAndShowArea();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Exception occurred");
                        }

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

        private void timer_Tick(object sender, EventArgs e)
        {
            mouseToolStripStatusLabel.Text = String.Format("Mouse position: X {0},   Y {1}  ", Cursor.Position.X.ToString(), Cursor.Position.Y.ToString());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) && nameTextBox.Text != "Type a name here...")
            {
                newArea.Name = nameTextBox.Text;
                areas.Add(newArea);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Name value can not be default or empty!");
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            CleanAreaObject();
            acceptButton.Enabled = false;
            cancelButton.Enabled = true;
            resetButton.Enabled = false;
            captureButton.Enabled = true;

            dimensionsValueLabel.Text = "No bitmap captured";
            startPositionValueLabel.Text = "Go to start point and press HOME key. Then go to end point and press END key";
            previewPictureBox.Tag = null;
            myToolTip.AutoSize = true;
            previewPictureBox.BackColor = Color.Firebrick;
            nameTextBox.Enabled = false;
        }

        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void addAreaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        private void AddAreaForm_Load(object sender, EventArgs e)
        {
            AllocateFont();
        }
        private void AllocateFont()
        {
            FontLoader fontLoader = new FontLoader();

            fontLoader.AllocateFont(Constans.myFontFamily, this.areasLabel, 20);
            fontLoader.AllocateFont(Constans.myFontFamily, this.startPositionLabel, 10);
            fontLoader.AllocateFont(Constans.myFontFamily, this.dimensionsLabel, 10);

            fontLoader.AllocateFont(Constans.myFontFamily, this.acceptButton, 8.25f);
            fontLoader.AllocateFont(Constans.myFontFamily, this.cancelButton, 8.25f);
            fontLoader.AllocateFont(Constans.myFontFamily, this.resetButton, 8.25f);
            fontLoader.AllocateFont(Constans.myFontFamily, this.captureButton, 9);

            fontLoader.AllocateFont(Constans.myFontFamily, this.nameLabel, 10);
            fontLoader.AllocateFont(Constans.myFontFamily, this.nameTextBox, 10);

            fontLoader.AllocateFont(Constans.myFontFamily, this.startPositionValueLabel, 10);
            fontLoader.AllocateFont(Constans.myFontFamily, this.dimensionsValueLabel, 10);
            fontLoader.AllocateFont(Constans.myFontFamily, this.toolStrip1, 9);
            fontLoader.AllocateFont(Constans.myFontFamily, this.mouseToolStripStatusLabel, 9);
        }

        #region Mouse Hover Effects

        private void closePictureBox_MouseEnter(object sender, EventArgs e)
        {
            closePictureBox.BackColor = Color.Gainsboro;
        }

        private void closePictureBox_MouseLeave(object sender, EventArgs e)
        {
            closePictureBox.BackColor = Color.White;
        }
        #endregion
    }
}
