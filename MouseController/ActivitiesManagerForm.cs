using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MouseController
{
    public partial class ActivitiesManagerForm : Form
    {
        List<IAction> currentActions;
        
        WorkProfile profile;
        
        public ActivitiesManagerForm(WorkProfile profile)
        {
            InitializeComponent();
            actionsDataGridView.AutoGenerateColumns = false;
            
            this.profile = profile;

            #region Sample Data

            Area area1 = new Area { Name = "Obszar" };
            Area area2 = new Area { Name = "NowyObszar" };
            profile.Areas.Add(area2);
            profile.Areas.Add(area1);

            Activity act1 = new Activity { Name = "Przykład 1" };
            Activity act2 = new Activity { Name = "Przykład 2" };

            ClickAction action1 = new ClickAction { Name = "Click1", DelayTime = 1000, Active = true };
            ClickAction action2 = new ClickAction { Name = "Click2", DelayTime = 1000, Active = true };


            MoveAction action3 = new MoveAction(area1) { Name = "Move1", DelayTime = 1000, Active = true };
            MoveAction action4 = new MoveAction(area2) { Name = "Move2", DelayTime = 1000, Active = true };
            act1.AddAction(action1);
            act1.AddAction(action3);
            act1.AddAction(action4);
            act2.AddAction(action2);

            profile.Activities.Add(act1);
            profile.Activities.Add(act2);

            #endregion
            
            ReadActivitiesCollection();
            AddDataGridViewColumns();
            profile.Activities.CollectionChanged += Activities_CollectionChanged;
        }
        
        private void Activities_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ReadActivitiesCollection();
        }

        public void ReadActivitiesCollection()
        {
            if(profile.Activities.Count != 0)
            {
                actionsDataGridView.Enabled = true;
                activitiesComboBox.DataSource = profile.Activities.Select(t => t.Name).ToList();
                //activitiesComboBox.SelectedIndex = -1;
                
            }
            else
            {
                activitiesComboBox.DataSource = null;
                actionsDataGridView.DataSource = null;
                actionsDataGridView.Enabled = false;
            }
        }


        #region DataGridView Columns

        private void AddDataGridViewColumns()
        {
            actionsDataGridView.Columns.Add(CreateActiveCheckBoxColumn());
            actionsDataGridView.Columns.Add(CreateNameColumn());
            actionsDataGridView.Columns.Add(CreateTypeComboColumn());
            actionsDataGridView.Columns.Add(CreateDelayTimeColumn());
            actionsDataGridView.Columns.Add(CreateAreaComboColumn());
        }

        DataGridViewCheckBoxColumn CreateActiveCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn activeCheckBoxColumn = new DataGridViewCheckBoxColumn();
            activeCheckBoxColumn.DataPropertyName = "Active";
            activeCheckBoxColumn.Name = "Active";

            return activeCheckBoxColumn;
        }

        DataGridViewColumn CreateNameColumn()
        {
            DataGridViewColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Name";
            nameTextBoxColumn.Name = "Name";

            return nameTextBoxColumn;
        }

        DataGridViewColumn CreateDelayTimeColumn()
        {
            DataGridViewColumn delayTimeTexTBoxColumn = new DataGridViewTextBoxColumn();
            delayTimeTexTBoxColumn.DataPropertyName = "DelayTime";
            delayTimeTexTBoxColumn.Name = "Delay [ms]";
            

            return delayTimeTexTBoxColumn;


        }

        DataGridViewComboBoxColumn CreateTypeComboColumn()
        {
            DataGridViewComboBoxColumn typeComboColumn = new DataGridViewComboBoxColumn();
            typeComboColumn.DataSource = Enum.GetValues(typeof(Type));
            typeComboColumn.DataPropertyName = "Type";
            typeComboColumn.Name = "Type";

            return typeComboColumn;
        }

        DataGridViewComboBoxColumn CreateAreaComboColumn()
        {
            DataGridViewComboBoxColumn areaComboBoxColumn = new DataGridViewComboBoxColumn();
            areaComboBoxColumn.DataSource = profile.Areas.Select(t => t.Name).ToArray();
            areaComboBoxColumn.DataPropertyName = "Area.Name";
            areaComboBoxColumn.Name = "Area";

            return areaComboBoxColumn;
        }

        #endregion

        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        private void activitiesManagerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            {
                string[] props = col.DataPropertyName.Split('.');
                PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);

                if (propInfo != null)
                {
                    object val = propInfo.GetValue(row.DataBoundItem, null);
                    for (int i = 1; i < props.Length; i++)
                    {
                        propInfo = val.GetType().GetProperty(props[i]);
                        val = propInfo.GetValue(val, null);
                    }
                    e.Value = val;
                }
                else
                {
                    DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    DataGridViewComboBoxCell chkCell = cell as DataGridViewComboBoxCell;
                    chkCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                    chkCell.ReadOnly = true;
                }
            }

        }

        private void activitiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(activitiesComboBox.SelectedValue != null)
            {
                if (profile.Activities.Where(t => t.Name == activitiesComboBox.SelectedValue.ToString()).Any())
                {
                    currentActions = profile.Activities.Where(t => t.Name == activitiesComboBox.SelectedValue.ToString()).First().GetActions();
                    var bindingList = new BindingList<IAction>(currentActions);
                    var source = new BindingSource(bindingList, null);

                    actionsDataGridView.DataSource = bindingList;
                }
            }
            else
            {
                actionsDataGridView.DataSource = null;
            }
            
        }
        
        private void closeButtonPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
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
        
        private void addActivityLabel_Click(object sender, EventArgs e)
        {
            AddActivityForm addActivityForm = new AddActivityForm(profile.Activities);

            addActivityForm.ShowDialog();
            if(addActivityForm.DialogResult == DialogResult.OK)
            {
                activitiesComboBox.SelectedItem = addActivityForm.NewActivity.Name;
            }
        }

        private void removeActivityLabel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to remove this activity?", "Removing activity", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if(profile.Activities.Where(t => t.Name == activitiesComboBox.SelectedItem.ToString()).Any())
                {
                    profile.Activities.Remove(profile.Activities.Where(t => t.Name == activitiesComboBox.SelectedItem.ToString()).First());
                }
            }
        }

        private void addActionLabel_Click(object sender, EventArgs e)
        {
            currentActions.Add(new ClickAction());
        }

        private void removeActionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
