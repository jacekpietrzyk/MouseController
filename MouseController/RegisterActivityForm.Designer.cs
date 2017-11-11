namespace MouseController
{
    partial class RegisterActivityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actionsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activitiesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsDataGridView
            // 
 
            this.actionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.actionsDataGridView.Name = "actionsDataGridView";
            this.actionsDataGridView.Size = new System.Drawing.Size(599, 224);
            this.actionsDataGridView.TabIndex = 0;
            this.actionsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.actionsDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 224);
            this.panel1.TabIndex = 1;
            // 
            // activitiesComboBox
            // 
            this.activitiesComboBox.FormattingEnabled = true;
            this.activitiesComboBox.Location = new System.Drawing.Point(162, 24);
            this.activitiesComboBox.Name = "activitiesComboBox";
            this.activitiesComboBox.Size = new System.Drawing.Size(211, 21);
            this.activitiesComboBox.TabIndex = 2;
            this.activitiesComboBox.SelectedIndexChanged += new System.EventHandler(this.activitiesComboBox_SelectedIndexChanged);
            // 
            // RegisterActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 363);
            this.Controls.Add(this.activitiesComboBox);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterActivityForm";
            this.Text = "RegisterActivityForm";
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView actionsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox activitiesComboBox;
    }
}