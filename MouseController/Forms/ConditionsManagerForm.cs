using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MouseController
{
    public partial class ConditionsManagerForm : Form
    {
        WorkProfile profile;


        public ConditionsManagerForm(WorkProfile profile)
        {
            this.profile = profile;

            InitializeComponent();
            conditionsDataGridView.AutoGenerateColumns = false;
            AddDataGridViewColumns();

        }
        private void AddDataGridViewColumns()
        {
            conditionsDataGridView.Columns.Add(CreateAreaComboColumn());
            conditionsDataGridView.Columns.Add(CreateActivityComboColumn());
        }
        DataGridViewComboBoxColumn CreateAreaComboColumn()
        {
            DataGridViewComboBoxColumn areaComboColumn = new DataGridViewComboBoxColumn();
            areaComboColumn.DataSource = profile.Areas.Select(t => t.Name).ToArray();
            areaComboColumn.DataPropertyName = "Name";
            areaComboColumn.Name = "Area Name";

            return areaComboColumn;
        }
        DataGridViewComboBoxColumn CreateActivityComboColumn()
        {
            DataGridViewComboBoxColumn activityComboColumn = new DataGridViewComboBoxColumn();
            List<string> activitiesNamesList = profile.Activities.Select(t => t.Name).ToList();
            activitiesNamesList.Insert(0, "");
            activityComboColumn.DataSource = activitiesNamesList;

            activityComboColumn.DataPropertyName = "ActivityName";
            activityComboColumn.Name = "Activity Name";

            return activityComboColumn;
        }
        private void SetGridSource()
        {
            try
            {
                if (profile.Areas.Count != 0 && profile.Activities.Count != 0)
                {
                    var bindingList = new BindingList<Area>(profile.Areas);
                    conditionsDataGridView.DataSource = bindingList;
                }
                else
                {
                    conditionsDataGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception occurred");
            }
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
            AllocateFont();
            SetGridSource();
        }

        private void AllocateFont()
        {
            FontLoader fontLoader = new FontLoader();

            fontLoader.AllocateFont(Constans.myFontFamily, this.conditionsManagerLabel, 20);
            fontLoader.AllocateFont(Constans.myFontFamily, this.cancelButton, 8.25f);
            fontLoader.AllocateFont(Constans.myFontFamily, this.acceptButton, 8.25f);
            fontLoader.AllocateFont(Constans.myFontFamily, this.conditionsDataGridView.DefaultCellStyle, 9, false);
            fontLoader.AllocateFont(Constans.myFontFamily, this.conditionsDataGridView.ColumnHeadersDefaultCellStyle, 9, false);
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
