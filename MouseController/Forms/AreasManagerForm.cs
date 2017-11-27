
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

        private void areasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPreviewArea();
        }
        public void SetPreviewArea()
        {
            if (profile.Areas.Where(a => a.Name == areasComboBox.SelectedItem.ToString()).Any())
            {
                myToolTip.AutoSize = false;
                selectedArea = profile.Areas.Where(a => a.Name == areasComboBox.SelectedItem.ToString()).First();
                previewPictureBox.Tag = selectedArea.Bitmap;
                Size size = new Size() { Width = selectedArea.Bitmap.Size.Width + 2, Height = selectedArea.Bitmap.Size.Height + 2 };
                myToolTip.Size = size;
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
            AllocateFont();
        }
        private void AllocateFont()
        {
            FontLoader fontLoader = new FontLoader();

            fontLoader.LoadFont(Properties.Resources.DefaultFont);
            fontLoader.AllocateFont(Constans.myFontFamily, this.areasLabel, 20);
            fontLoader.AllocateFont(Constans.myFontFamily, this.savedAreasLabel, 10);
            fontLoader.AllocateFont(Constans.myFontFamily, this.areasComboBox, 10);
            fontLoader.AllocateFont(Constans.myFontFamily, this.cancelButton, 8.25f);
            fontLoader.AllocateFont(Constans.myFontFamily, this.acceptButton, 8.25f);
        }

        private void addAreaPanel_Click(object sender, EventArgs e)
        {
            Area areaToAdd = new Area();
            using (AddAreaForm addAreaForm = new AddAreaForm(areaToAdd))
            {
                addAreaForm.ShowDialog();

                if (addAreaForm.DialogResult == DialogResult.OK)
                {
                    profile.Areas.Add(areaToAdd);
                }
            }
        }
        private void removeAreaPanel_Click(object sender, EventArgs e)
        {
            if(areasComboBox.SelectedItem != null)
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
        private void editAreaPanel_Click(object sender, EventArgs e)
        {
            if (areasComboBox.SelectedItem != null)
            {
                Area areaToEdit = profile.Areas.Where(t => t.Name == areasComboBox.SelectedItem.ToString()).First();
                Area clonedArea = areaToEdit.Clone();

                using (AddAreaForm addAreaForm = new AddAreaForm(clonedArea))
                {
                    addAreaForm.ShowDialog();

                    if (addAreaForm.DialogResult == DialogResult.OK)
                    {
                        int index = profile.Areas.IndexOf(areaToEdit);
                        profile.Areas.RemoveAt(index);
                        profile.Areas.Insert(index, clonedArea);
                        SetPreviewArea();
                        ReadAreasCollection();
                    }
                }
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            OnFormClose(DialogResult.OK);
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            OnFormClose(DialogResult.Cancel);
        }
        private void closePictureBox_Click(object sender, EventArgs e)
        {
            OnFormClose(DialogResult.Cancel);
        }

        public void OnFormClose(DialogResult result)
        {
            if (profile != null)
            {
                profile.Areas.CollectionChanged -= Areas_CollectionChanged;
            }
            this.DialogResult = result;
            this.Close();
        }

        #region Mouse Hover Events

        private void closePictureBox_MouseEnter(object sender, EventArgs e)
        {
            closePictureBox.BackColor = Color.Gainsboro;
        }

        private void closePictureBox_MouseLeave(object sender, EventArgs e)
        {
            closePictureBox.BackColor = Color.White;
        }

        private void addAreaPanel_MouseEnter(object sender, EventArgs e)
        {
            addAreaPanel.BackColor = Color.Gainsboro;
        }

        private void addAreaPanel_MouseLeave(object sender, EventArgs e)
        {
            addAreaPanel.BackColor = Color.White;
        }

        private void removeAreaPanel_MouseEnter(object sender, EventArgs e)
        {
            removeAreaPanel.BackColor = Color.Gainsboro;
        }

        private void removeAreaPanel_MouseLeave(object sender, EventArgs e)
        {
            removeAreaPanel.BackColor = Color.White;
        }

        private void editAreaPanel_MouseLeave(object sender, EventArgs e)
        {
            editAreaPanel.BackColor = Color.White;
        }

        private void editAreaPanel_MouseEnter(object sender, EventArgs e)
        {
            editAreaPanel.BackColor = Color.Gainsboro;
        }

        #endregion
    }
}
