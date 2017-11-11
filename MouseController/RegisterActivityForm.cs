using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseController
{
    public partial class RegisterActivityForm : Form
    {
        List<IAction> currentActions;
        List<Area> areas;
        List<IActivity> activities = new List<IActivity>();

        public RegisterActivityForm(List<IActivity> activities1, List<Area> areas)
        {
            InitializeComponent();
            actionsDataGridView.AutoGenerateColumns = false;

            //this.activities = activities;
            this.areas = areas;

            #region Sample Data
            Area area1 = new Area { Name = "Obszar" };
            Area area2 = new Area { Name = "NowyObszar" };
            areas.Add(area2);
            areas.Add(area1);

            Activity act1 = new Activity { Name = "Activ1" };
            Activity act2 = new Activity { Name = "Activ2" };
            
            ClickAction action1 = new ClickAction { Name = "Click1", DelayTime = 1000, Active = true };
            ClickAction action2 = new ClickAction { Name = "Click2", DelayTime = 1000, Active = true };


            MoveAction action3 = new MoveAction(area1) { Name = "Move1", DelayTime = 1000, Active = true };
            MoveAction action4 = new MoveAction(area2) { Name = "Move2", DelayTime = 1000, Active = true };
            act1.AddAction(action1);
            act1.AddAction(action3);
            act1.AddAction(action4);
            act2.AddAction(action2);

            activities.Add(act1);
            activities.Add(act2);

            #endregion

            activitiesComboBox.DataSource = activities.Select(t => t.Name).ToList();
            
            AddDataGridViewColumns();
        }

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
            areaComboBoxColumn.DataSource = areas.Select(t => t.Name).ToArray();
            areaComboBoxColumn.DataPropertyName = "Area.Name";
            areaComboBoxColumn.Name = "Area";

            return areaComboBoxColumn;
        }

        
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
            currentActions = activities.Where(t => t.Name == activitiesComboBox.SelectedValue.ToString()).First().GetActions();
            var bindingList = new BindingList<IAction>(currentActions);
            var source = new BindingSource(bindingList, null);

            actionsDataGridView.DataSource = source;
        }
    }
}
