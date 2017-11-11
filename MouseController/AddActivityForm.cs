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
    public partial class AddActivityForm : Form
    {
        private string defaultName = "Type a name here";
        public Activity Activity { get; set; }

        public AddActivityForm()
        {
            InitializeComponent();
            nameTextBox.Text = defaultName;
            
        }


        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        
        private void addActivityPanel_MouseDown(object sender, MouseEventArgs e)
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
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (IsValidName())
            {
                this.DialogResult = DialogResult.OK;
                Activity = new Activity { Name = nameTextBox.Text };

            }
            else
            {
                MessageBox.Show("New activity name is invalid");
            }

        }

        public bool IsValidName()
        {
            if(nameTextBox.Text == "" || nameTextBox.Text == defaultName)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValidName())
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }

        
    }
}
