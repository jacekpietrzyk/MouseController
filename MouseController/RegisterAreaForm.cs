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

namespace MouseController
{
    public partial class RegisterAreaForm : Form
    {
        Area area;
        AnalyzeImages analyze = new AnalyzeImages();

        public RegisterAreaForm(Area area)
        {
            InitializeComponent();
            this.area = area;
            this.Focus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            mouseToolStripStatusLabel.Text = String.Format("Mouse position: X {0},   Y {1}  ", Cursor.Position.X.ToString(), Cursor.Position.Y.ToString());
        }

        private void RegisterAreaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S)
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
                dimensionsValueLabel.Text = "Width: " + area.Width+ ",  Height: " + area.Height;

                acceptButton.Enabled = true;
                resetButton.Enabled = true;
                CaptureAndShowArea();
            }
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            CleanAreaObject();
            acceptButton.Enabled = false;
            resetButton.Enabled = false;
            areaPictureBox.ImageLocation = null;
            dimensionsValueLabel.Text = "  Go to destination point end press E key";
            startPositionValueLabel.Text = " Go to destination point end press S key";
        }

        public void CaptureAndShowArea()
        {
            areaPictureBox.Image = analyze.MakeScreenShot(area);
        }
        
        public void CleanAreaObject()
        {
            area = new Area();
        }
    }

    
}
