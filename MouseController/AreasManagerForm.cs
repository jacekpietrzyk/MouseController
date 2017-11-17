
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        FontLoader fontLoader = new FontLoader();

        WorkProfile profile = new WorkProfile();
        CustomizedToolTip myToolTip = new CustomizedToolTip();
        Area selectedArea;


        public AreasManagerForm(WorkProfile profile)
        {
            InitializeComponent();
            this.profile = profile;
            myToolTip.SetToolTip(previewPictureBox, "Preview disabled");
            myToolTip.InitialDelay = 1;

            ReadAreasCollection();

            profile.Areas.CollectionChanged += Areas_CollectionChanged;
        }
        
        private void Areas_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ReadAreasCollection();
        }

        public void SetPreviewArea()
        {
            if (profile.Areas.Where(a => a.Name == areasComboBox.SelectedItem.ToString()).Any())
            {
                myToolTip.AutoSize = false;
                selectedArea = profile.Areas.Where(a => a.Name == areasComboBox.SelectedItem.ToString()).First();
                previewPictureBox.Tag = selectedArea.Bitmap;
                myToolTip.Size = selectedArea.Bitmap.Size;
                myToolTip.ToolTipTitle = " ";
                previewPictureBox.BackColor = Color.DarkGreen;
            }
            else
            {
                selectedArea = new Area();
                previewPictureBox.BackColor = Color.Firebrick;
                myToolTip.AutoSize = true;
                myToolTip.ToolTipTitle = "Preview disabled";

            }
        }

        public void ReadAreasCollection()
        {
            if (profile.Areas.Count != 0)
            {
                areasComboBox.DataSource = profile.Areas.Select(t => t.Name).ToList();
            }
            else
            {
                areasComboBox.DataSource = null;
            }
        }
        
       
        
        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void closePictureBox_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void areasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPreviewArea();
        }
        
        

        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void areasManagerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void AreasManagerForm_Load(object sender, EventArgs e)
        {
            fontLoader.LoadFont(Properties.Resources.DefaultFont);
            fontLoader.AllocateFont(this.areasLabel, 20);
            fontLoader.AllocateFont(this.savedAreasLabel, 10);
            fontLoader.AllocateFont(this.areasComboBox, 10);
            fontLoader.AllocateFont(this.cancelButton, 8.25f);
            fontLoader.AllocateFont(this.acceptButton, 8.25f);
        }

        
        private void addAreaPanel_Click(object sender, EventArgs e)
        {
            AddAreaForm addAreaForm = new AddAreaForm(profile.Areas);
            addAreaForm.ShowDialog();
        }

        private void removeAreaPanel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this area?", "Removing area", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (profile.Areas.Where(t => t.Name == areasComboBox.SelectedItem.ToString()).Any())
                {
                    profile.Areas.Remove(profile.Areas.Where(t => t.Name == areasComboBox.SelectedItem.ToString()).First());
                }
            }
        }
    }


}
