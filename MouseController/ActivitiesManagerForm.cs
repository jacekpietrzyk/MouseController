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
        private bool eventsNotSuspended = true;
        WorkProfile profile;
        
        public ActivitiesManagerForm(WorkProfile profile)
        {
            InitializeComponent();
            actionsDataGridView.AutoGenerateColumns = false;
            
            this.profile = profile;
            
            ReadActivitiesCollection();
            AddDataGridViewColumns();

            profile.Activities.CollectionChanged += Activities_CollectionChanged;


            // Add the events to listen for
            actionsDataGridView.CellValueChanged +=
                 new DataGridViewCellEventHandler(actionsDataGridView_CellValueChanged);
            actionsDataGridView.CurrentCellDirtyStateChanged +=
                 new EventHandler(actionsDataGridView_CurrentCellDirtyStateChanged);



        }
        
        private void Activities_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(eventsNotSuspended)
            {
                ReadActivitiesCollection();
            }
        }
        
        public void ReadActivitiesCollection()
        {
            if(profile.Activities.Count != 0)
            {
                actionsDataGridView.Enabled = true;
                activitiesComboBox.DataSource = profile.Activities.Select(t => t.Name).ToList();
            }
            else
            {
                activitiesComboBox.DataSource = null;
                actionsDataGridView.DataSource = new List<IAction>();
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
            if(eventsNotSuspended)
            {
                SetGridSource();
            }
        }
        private void SetGridSource()
        {
            try
            {
                if (activitiesComboBox.SelectedValue != null)
                {
                    if (profile.Activities.Where(t => t.Name == activitiesComboBox.SelectedValue.ToString()).Any())
                    {
                        currentActions = profile.Activities.Where(t => t.Name == activitiesComboBox.SelectedValue.ToString()).First().GetActions();
                        var bindingList = new BindingList<IAction>(currentActions);

                        actionsDataGridView.DataSource = bindingList;
                    }
                }
                else
                {
                    actionsDataGridView.DataSource = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception occurred");
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
            eventsNotSuspended = false;
            using (AddActivityForm addActivityForm = new AddActivityForm(profile.Activities))
            {
                addActivityForm.ShowDialog();

                if (addActivityForm.DialogResult == DialogResult.OK)
                {
                    ReadActivitiesCollection();
                    activitiesComboBox.SelectedItem = addActivityForm.NewActivity.Name;
                    SetGridSource();
                }
            }
            eventsNotSuspended = true;
        }

        private void removeActivityLabel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to remove this activity?", "Removing activity", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if(profile.Activities.Where(t => t.Name == activitiesComboBox.SelectedItem.ToString()).Any())
                {
                    try
                    {
                        profile.Activities.Remove(profile.Activities.Where(t => t.Name == activitiesComboBox.SelectedItem.ToString()).First());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception occurred");
                    }
                }
            }
        }

        private void addActionLabel_Click(object sender, EventArgs e)
        {
            currentActions.Add(new ClickAction());
            SetGridSource();
        }




        

        // This event handler manually raises the CellValueChanged event 
        // by calling the CommitEdit method. 
        void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void actionsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.RowIndex < currentActions.Count) //Type triggered
            {
                DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)actionsDataGridView.Rows[e.RowIndex].Cells[2];
                if (cb.Value != null)
                {
                    DataGridViewTextBoxCell tb = (DataGridViewTextBoxCell)actionsDataGridView.Rows[e.RowIndex].Cells[1];
                    if(tb.Value == null)
                    {
                        MessageBox.Show("You should type a name first!");
                        currentActions.RemoveAt(currentActions.Count - 1);
                        SetGridSource();
                        return;
                    }
                    int editedActionIndex = currentActions.IndexOf(currentActions.Where(t => t.Name == tb.Value.ToString()).First());
                    IAction editedAction = currentActions[editedActionIndex];
                    IAction newAction;
                    if ((Type)cb.Value == Type.MoveAction)
                    {
                        if (profile.Areas.Count != 0)
                        {
                            Area firstArea = profile.Areas.First();
                            newAction = new MoveAction(firstArea) { Name = editedAction.Name, Type = Type.MoveAction, DelayTime = editedAction.DelayTime, Active = editedAction.Active };
                            currentActions.Remove(editedAction);
                            currentActions.Insert(editedActionIndex, newAction);
                            actionsDataGridView.Invalidate();

                        }
                        else
                        {
                            cb.Value = Type.ClickAction;
                        }
                    }
                    if ((Type)cb.Value == Type.ClickAction)
                    {
                        newAction = new ClickAction { Name = editedAction.Name, DelayTime = editedAction.DelayTime, Type = Type.ClickAction, Active = editedAction.Active };
                        currentActions.Remove(editedAction);
                        currentActions.Insert(editedActionIndex, newAction);
                        actionsDataGridView.Invalidate();
                    }
                    SetGridSource();
                    
                }
            }
            
        }

        private void actionsDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (actionsDataGridView.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                actionsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
