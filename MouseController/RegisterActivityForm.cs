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
        List<IAction> actions = new List<IAction>();
        List<Area> areas = new List<Area>();
        public RegisterActivityForm()
        {
            InitializeComponent();


            areas.Add(new Area() { Name = "Obszar1" });
            areas.Add(new Area() { Name = "Obszar2" });

            actions.Add(new ClickAction { DelayTime = 1000, Name = "Jeden" });
            actions.Add(new MoveAction(new Area() { Name = "Obszar2" }) { DelayTime = 2000, Name = "dwa", });
            //actions.Add(new ClickAction {  Name = "trzy" });

            var bindingList = new BindingList<IAction>(actions);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = actions;
            //foreach(IAction action in actions)
            //{

            //}

            // Initialize and add a check box column.
            DataGridViewCheckBoxColumn column0 = new DataGridViewCheckBoxColumn();
            column0.DataPropertyName = "Active";
            column0.Name = "Active";
            dataGridView1.Columns.Add(column0);


            // Initialize and add a text box column.
            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "Name";
            column1.Name = "Name";
            dataGridView1.Columns.Add(column1);

            dataGridView1.Columns.Add(CreateComboBoxWithEnums());

            // Initialize and add a text box column.
            DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "DelayTime";

            column3.Name = "Delay [ms]";
            dataGridView1.Columns.Add(column3);

            dataGridView1.Columns.Add(CreateComboBoxWithArea());
        }
        DataGridViewComboBoxColumn CreateComboBoxWithEnums()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = Enum.GetValues(typeof(Type));
            combo.DataPropertyName = "Type";
            combo.Name = "Type";
            return combo;
        }

        DataGridViewComboBoxColumn CreateComboBoxWithArea()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = areas.Select(t => t.Name).ToArray();

            combo.DataPropertyName = "Area.Name";
            combo.Name = "Area";
            return combo;
        }


        private void RegisterActivityForm_Load(object sender, EventArgs e)
        {


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
                    cell.ReadOnly = true;
                }
            }
        }
    }
}
