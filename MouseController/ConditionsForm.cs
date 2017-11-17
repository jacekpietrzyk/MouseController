using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseController
{
    public partial class ConditionsForm : Form
    {
        WorkProfile profile;
        FontLoader fontLoader = new FontLoader();


        public ConditionsForm(WorkProfile profile)
        {
            this.profile = profile;

            InitializeComponent();
        }


        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        private void conditionsFormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        private void closeButtonPictureBox_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ConditionsForm_Load(object sender, EventArgs e)
        {
            fontLoader.LoadFont(Properties.Resources.DefaultFont);

            fontLoader.AllocateFont(this.conditionsLabel, 20);
            fontLoader.AllocateFont(this.cancelButton, 8.25f);
            fontLoader.AllocateFont(this.acceptButton, 8.25f);
        }
    }
}
