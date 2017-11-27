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
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm(string headline, string question)
        {
            InitializeComponent();
            questionLabel.Text = question;
            headlineLabel.Text = headline;
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void closeButtonPictureBox_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MessageBoxPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
            AllocateFont();
        }

        private void AllocateFont()
        {
            FontLoader fontLoader = new FontLoader();

            fontLoader.AllocateFont(Constans.myFontFamily, this.headlineLabel, 20);
            fontLoader.AllocateFont(Constans.myFontFamily, this.questionLabel, 12);
            fontLoader.AllocateFont(Constans.myFontFamily, this.yesButton, 8.25f);
            fontLoader.AllocateFont(Constans.myFontFamily, this.noButton, 8.25f);
            fontLoader.AllocateFont(Constans.myFontFamily, this.cancelButton, 8.25f);

        }

        private void closeButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            closeButtonPictureBox.BackColor = Color.Gainsboro;
        }

        private void closeButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            closeButtonPictureBox.BackColor = Color.White;
        }
    }
}
