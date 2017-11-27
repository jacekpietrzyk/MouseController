namespace MouseController
{
    partial class ActivitiesManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitiesManagerForm));
            this.actionsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activitiesComboBox = new System.Windows.Forms.ComboBox();
            this.savedActivitiesLabel = new System.Windows.Forms.Label();
            this.activitiesComboBoxPanel = new System.Windows.Forms.Panel();
            this.activitiesLabel = new System.Windows.Forms.Label();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addActivityPanel = new System.Windows.Forms.Panel();
            this.removeActivityPanel = new System.Windows.Forms.Panel();
            this.activitiesManagerPanel = new System.Windows.Forms.Panel();
            this.removeActionPanel = new System.Windows.Forms.Panel();
            this.addActionPanel = new System.Windows.Forms.Panel();
            this.closeButtonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.activitiesComboBoxPanel.SuspendLayout();
            this.activitiesManagerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsDataGridView
            // 
            this.actionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.actionsDataGridView.Name = "actionsDataGridView";
            this.actionsDataGridView.Size = new System.Drawing.Size(546, 264);
            this.actionsDataGridView.TabIndex = 0;
            this.actionsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.actionsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.actionsDataGridView_CellValidating);
            this.actionsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.actionsDataGridView_CellValueChanged);
            this.actionsDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.actionsDataGridView_CurrentCellDirtyStateChanged);
            this.actionsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.actionsDataGridView_DataError);
            this.actionsDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.actionsDataGridView_RowValidating);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.actionsDataGridView);
            this.panel1.Location = new System.Drawing.Point(21, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 264);
            this.panel1.TabIndex = 1;
            // 
            // activitiesComboBox
            // 
            this.activitiesComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activitiesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activitiesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activitiesComboBox.FormattingEnabled = true;
            this.activitiesComboBox.ItemHeight = 16;
            this.activitiesComboBox.Location = new System.Drawing.Point(0, 0);
            this.activitiesComboBox.Name = "activitiesComboBox";
            this.activitiesComboBox.Size = new System.Drawing.Size(246, 24);
            this.activitiesComboBox.TabIndex = 2;
            this.activitiesComboBox.SelectedIndexChanged += new System.EventHandler(this.activitiesComboBox_SelectedIndexChanged);
            // 
            // savedActivitiesLabel
            // 
            this.savedActivitiesLabel.AutoSize = true;
            this.savedActivitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.savedActivitiesLabel.Location = new System.Drawing.Point(18, 76);
            this.savedActivitiesLabel.Margin = new System.Windows.Forms.Padding(10);
            this.savedActivitiesLabel.Name = "savedActivitiesLabel";
            this.savedActivitiesLabel.Size = new System.Drawing.Size(130, 17);
            this.savedActivitiesLabel.TabIndex = 3;
            this.savedActivitiesLabel.Text = "SAVED ACTIVITIES";
            // 
            // activitiesComboBoxPanel
            // 
            this.activitiesComboBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activitiesComboBoxPanel.Controls.Add(this.activitiesComboBox);
            this.activitiesComboBoxPanel.Location = new System.Drawing.Point(167, 72);
            this.activitiesComboBoxPanel.Margin = new System.Windows.Forms.Padding(10);
            this.activitiesComboBoxPanel.Name = "activitiesComboBoxPanel";
            this.activitiesComboBoxPanel.Size = new System.Drawing.Size(248, 24);
            this.activitiesComboBoxPanel.TabIndex = 4;
            // 
            // activitiesLabel
            // 
            this.activitiesLabel.AutoSize = true;
            this.activitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activitiesLabel.Location = new System.Drawing.Point(18, 20);
            this.activitiesLabel.Margin = new System.Windows.Forms.Padding(10);
            this.activitiesLabel.Name = "activitiesLabel";
            this.activitiesLabel.Size = new System.Drawing.Size(308, 31);
            this.activitiesLabel.TabIndex = 6;
            this.activitiesLabel.Text = "ACTIVITIES MANAGER";
            // 
            // actionsLabel
            // 
            this.actionsLabel.AutoSize = true;
            this.actionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionsLabel.Location = new System.Drawing.Point(20, 120);
            this.actionsLabel.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Size = new System.Drawing.Size(68, 17);
            this.actionsLabel.TabIndex = 3;
            this.actionsLabel.Text = "ACTIONS";
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acceptButton.Location = new System.Drawing.Point(394, 433);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "ACCEPT";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(492, 433);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addActivityPanel
            // 
            this.addActivityPanel.BackgroundImage = global::MouseController.Properties.Resources.addIcon;
            this.addActivityPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addActivityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addActivityPanel.Location = new System.Drawing.Point(435, 72);
            this.addActivityPanel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addActivityPanel.Name = "addActivityPanel";
            this.addActivityPanel.Size = new System.Drawing.Size(24, 24);
            this.addActivityPanel.TabIndex = 10;
            this.addActivityPanel.Click += new System.EventHandler(this.addActivityPanel_Click);
            this.addActivityPanel.MouseEnter += new System.EventHandler(this.addActivityPanel_MouseEnter);
            this.addActivityPanel.MouseLeave += new System.EventHandler(this.addActivityPanel_MouseLeave);
            // 
            // removeActivityPanel
            // 
            this.removeActivityPanel.BackgroundImage = global::MouseController.Properties.Resources.removeIcon;
            this.removeActivityPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeActivityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeActivityPanel.Location = new System.Drawing.Point(470, 72);
            this.removeActivityPanel.Margin = new System.Windows.Forms.Padding(5);
            this.removeActivityPanel.Name = "removeActivityPanel";
            this.removeActivityPanel.Size = new System.Drawing.Size(24, 24);
            this.removeActivityPanel.TabIndex = 10;
            this.removeActivityPanel.Click += new System.EventHandler(this.removeActivityPanel_Click);
            this.removeActivityPanel.MouseEnter += new System.EventHandler(this.removeActivityPanel_MouseEnter);
            this.removeActivityPanel.MouseLeave += new System.EventHandler(this.removeActivityPanel_MouseLeave);
            // 
            // activitiesManagerPanel
            // 
            this.activitiesManagerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activitiesManagerPanel.Controls.Add(this.acceptButton);
            this.activitiesManagerPanel.Controls.Add(this.removeActionPanel);
            this.activitiesManagerPanel.Controls.Add(this.removeActivityPanel);
            this.activitiesManagerPanel.Controls.Add(this.cancelButton);
            this.activitiesManagerPanel.Controls.Add(this.addActionPanel);
            this.activitiesManagerPanel.Controls.Add(this.addActivityPanel);
            this.activitiesManagerPanel.Controls.Add(this.closeButtonPictureBox);
            this.activitiesManagerPanel.Controls.Add(this.activitiesLabel);
            this.activitiesManagerPanel.Controls.Add(this.activitiesComboBoxPanel);
            this.activitiesManagerPanel.Controls.Add(this.panel1);
            this.activitiesManagerPanel.Controls.Add(this.actionsLabel);
            this.activitiesManagerPanel.Controls.Add(this.savedActivitiesLabel);
            this.activitiesManagerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesManagerPanel.Location = new System.Drawing.Point(0, 0);
            this.activitiesManagerPanel.Name = "activitiesManagerPanel";
            this.activitiesManagerPanel.Padding = new System.Windows.Forms.Padding(10);
            this.activitiesManagerPanel.Size = new System.Drawing.Size(589, 478);
            this.activitiesManagerPanel.TabIndex = 11;
            this.activitiesManagerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.activitiesManagerPanel_MouseDown);
            // 
            // removeActionPanel
            // 
            this.removeActionPanel.BackgroundImage = global::MouseController.Properties.Resources.removeIcon;
            this.removeActionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeActionPanel.Location = new System.Drawing.Point(125, 116);
            this.removeActionPanel.Margin = new System.Windows.Forms.Padding(5);
            this.removeActionPanel.Name = "removeActionPanel";
            this.removeActionPanel.Size = new System.Drawing.Size(19, 19);
            this.removeActionPanel.TabIndex = 10;
            this.removeActionPanel.TabStop = true;
            this.removeActionPanel.Click += new System.EventHandler(this.removeActionPanel_Click);
            this.removeActionPanel.MouseEnter += new System.EventHandler(this.removeActionPanel_MouseEnter);
            this.removeActionPanel.MouseLeave += new System.EventHandler(this.removeActionPanel_MouseLeave);
            // 
            // addActionPanel
            // 
            this.addActionPanel.BackgroundImage = global::MouseController.Properties.Resources.addIcon;
            this.addActionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addActionPanel.Location = new System.Drawing.Point(96, 116);
            this.addActionPanel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addActionPanel.Name = "addActionPanel";
            this.addActionPanel.Size = new System.Drawing.Size(19, 19);
            this.addActionPanel.TabIndex = 10;
            this.addActionPanel.TabStop = true;
            this.addActionPanel.Click += new System.EventHandler(this.addActionPanel_Click);
            this.addActionPanel.MouseEnter += new System.EventHandler(this.addActionPanel_MouseEnter);
            this.addActionPanel.MouseLeave += new System.EventHandler(this.addActionPanel_MouseLeave);
            // 
            // closeButtonPictureBox
            // 
            this.closeButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButtonPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButtonPictureBox.BackgroundImage")));
            this.closeButtonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButtonPictureBox.Location = new System.Drawing.Point(547, 20);
            this.closeButtonPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.closeButtonPictureBox.Name = "closeButtonPictureBox";
            this.closeButtonPictureBox.Size = new System.Drawing.Size(20, 20);
            this.closeButtonPictureBox.TabIndex = 5;
            this.closeButtonPictureBox.TabStop = false;
            this.closeButtonPictureBox.Click += new System.EventHandler(this.closeButtonPictureBox_Click);
            this.closeButtonPictureBox.MouseEnter += new System.EventHandler(this.closeButtonPictureBox_MouseEnter);
            this.closeButtonPictureBox.MouseLeave += new System.EventHandler(this.closeButtonPictureBox_MouseLeave);
            // 
            // ActivitiesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 478);
            this.Controls.Add(this.activitiesManagerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivitiesManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activities Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActivitiesManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.ActivitiesManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.activitiesComboBoxPanel.ResumeLayout(false);
            this.activitiesManagerPanel.ResumeLayout(false);
            this.activitiesManagerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView actionsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox activitiesComboBox;
        private System.Windows.Forms.Label savedActivitiesLabel;
        private System.Windows.Forms.Panel activitiesComboBoxPanel;
        private System.Windows.Forms.PictureBox closeButtonPictureBox;
        private System.Windows.Forms.Label activitiesLabel;
        private System.Windows.Forms.Label actionsLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel addActivityPanel;
        private System.Windows.Forms.Panel removeActivityPanel;
        private System.Windows.Forms.Panel activitiesManagerPanel;
        private System.Windows.Forms.Panel removeActionPanel;
        private System.Windows.Forms.Panel addActionPanel;
    }
}