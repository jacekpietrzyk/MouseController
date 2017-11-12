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
            this.activitiesListLabel = new System.Windows.Forms.Label();
            this.activitiesComboBoxPanel = new System.Windows.Forms.Panel();
            this.closeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actionsListLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addActivityLabel = new System.Windows.Forms.Label();
            this.addActivityPanel = new System.Windows.Forms.Panel();
            this.removeActivityPanel = new System.Windows.Forms.Panel();
            this.removeActivityLabel = new System.Windows.Forms.Label();
            this.activitiesManagerPanel = new System.Windows.Forms.Panel();
            this.removeActionPanel = new System.Windows.Forms.Panel();
            this.removeActionLabel = new System.Windows.Forms.Label();
            this.addActionPanel = new System.Windows.Forms.Panel();
            this.addActionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.activitiesComboBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).BeginInit();
            this.addActivityPanel.SuspendLayout();
            this.removeActivityPanel.SuspendLayout();
            this.activitiesManagerPanel.SuspendLayout();
            this.removeActionPanel.SuspendLayout();
            this.addActionPanel.SuspendLayout();
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
            this.activitiesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activitiesComboBox.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activitiesComboBox.FormattingEnabled = true;
            this.activitiesComboBox.ItemHeight = 13;
            this.activitiesComboBox.Location = new System.Drawing.Point(0, 0);
            this.activitiesComboBox.Name = "activitiesComboBox";
            this.activitiesComboBox.Size = new System.Drawing.Size(246, 21);
            this.activitiesComboBox.TabIndex = 2;
            this.activitiesComboBox.SelectedIndexChanged += new System.EventHandler(this.activitiesComboBox_SelectedIndexChanged);
            // 
            // activitiesListLabel
            // 
            this.activitiesListLabel.AutoSize = true;
            this.activitiesListLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activitiesListLabel.Location = new System.Drawing.Point(18, 76);
            this.activitiesListLabel.Margin = new System.Windows.Forms.Padding(10);
            this.activitiesListLabel.Name = "activitiesListLabel";
            this.activitiesListLabel.Size = new System.Drawing.Size(129, 14);
            this.activitiesListLabel.TabIndex = 3;
            this.activitiesListLabel.Text = "SAVED ACTIVITIES";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "ACTIVITIES MANAGER";
            // 
            // actionsListLabel
            // 
            this.actionsListLabel.AutoSize = true;
            this.actionsListLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionsListLabel.Location = new System.Drawing.Point(20, 120);
            this.actionsListLabel.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.actionsListLabel.Name = "actionsListLabel";
            this.actionsListLabel.Size = new System.Drawing.Size(68, 14);
            this.actionsListLabel.TabIndex = 3;
            this.actionsListLabel.Text = "ACTIONS";
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.cancelButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(492, 433);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addActivityLabel
            // 
            this.addActivityLabel.AutoSize = true;
            this.addActivityLabel.Font = new System.Drawing.Font("Gulim", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addActivityLabel.Location = new System.Drawing.Point(-2, -1);
            this.addActivityLabel.Name = "addActivityLabel";
            this.addActivityLabel.Size = new System.Drawing.Size(28, 26);
            this.addActivityLabel.TabIndex = 9;
            this.addActivityLabel.Text = "+";
            this.addActivityLabel.Click += new System.EventHandler(this.addActivityLabel_Click);
            // 
            // addActivityPanel
            // 
            this.addActivityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addActivityPanel.Controls.Add(this.addActivityLabel);
            this.addActivityPanel.Location = new System.Drawing.Point(435, 72);
            this.addActivityPanel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addActivityPanel.Name = "addActivityPanel";
            this.addActivityPanel.Size = new System.Drawing.Size(24, 24);
            this.addActivityPanel.TabIndex = 10;
            // 
            // removeActivityPanel
            // 
            this.removeActivityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeActivityPanel.Controls.Add(this.removeActivityLabel);
            this.removeActivityPanel.Location = new System.Drawing.Point(470, 72);
            this.removeActivityPanel.Margin = new System.Windows.Forms.Padding(5);
            this.removeActivityPanel.Name = "removeActivityPanel";
            this.removeActivityPanel.Size = new System.Drawing.Size(24, 24);
            this.removeActivityPanel.TabIndex = 10;
            // 
            // removeActivityLabel
            // 
            this.removeActivityLabel.AutoSize = true;
            this.removeActivityLabel.Font = new System.Drawing.Font("Gulim", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeActivityLabel.Location = new System.Drawing.Point(-2, -2);
            this.removeActivityLabel.Name = "removeActivityLabel";
            this.removeActivityLabel.Size = new System.Drawing.Size(28, 26);
            this.removeActivityLabel.TabIndex = 9;
            this.removeActivityLabel.Text = "-";
            this.removeActivityLabel.Click += new System.EventHandler(this.removeActivityLabel_Click);
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
            this.activitiesManagerPanel.Controls.Add(this.label1);
            this.activitiesManagerPanel.Controls.Add(this.activitiesComboBoxPanel);
            this.activitiesManagerPanel.Controls.Add(this.panel1);
            this.activitiesManagerPanel.Controls.Add(this.actionsListLabel);
            this.activitiesManagerPanel.Controls.Add(this.activitiesListLabel);
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
            this.removeActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeActionPanel.Controls.Add(this.removeActionLabel);
            this.removeActionPanel.Location = new System.Drawing.Point(125, 116);
            this.removeActionPanel.Margin = new System.Windows.Forms.Padding(5);
            this.removeActionPanel.Name = "removeActionPanel";
            this.removeActionPanel.Size = new System.Drawing.Size(19, 19);
            this.removeActionPanel.TabIndex = 10;
            this.removeActionPanel.TabStop = true;
            // 
            // removeActionLabel
            // 
            this.removeActionLabel.AutoSize = true;
            this.removeActionLabel.Font = new System.Drawing.Font("Gulim", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeActionLabel.Location = new System.Drawing.Point(-1, -4);
            this.removeActionLabel.Name = "removeActionLabel";
            this.removeActionLabel.Size = new System.Drawing.Size(21, 23);
            this.removeActionLabel.TabIndex = 9;
            this.removeActionLabel.Text = "-";
            // 
            // addActionPanel
            // 
            this.addActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addActionPanel.Controls.Add(this.addActionLabel);
            this.addActionPanel.Location = new System.Drawing.Point(96, 116);
            this.addActionPanel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addActionPanel.Name = "addActionPanel";
            this.addActionPanel.Size = new System.Drawing.Size(19, 19);
            this.addActionPanel.TabIndex = 10;
            this.addActionPanel.TabStop = true;
            // 
            // addActionLabel
            // 
            this.addActionLabel.AutoSize = true;
            this.addActionLabel.Font = new System.Drawing.Font("Gulim", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addActionLabel.Location = new System.Drawing.Point(-2, -4);
            this.addActionLabel.Name = "addActionLabel";
            this.addActionLabel.Size = new System.Drawing.Size(22, 23);
            this.addActionLabel.TabIndex = 9;
            this.addActionLabel.Text = "+";
            this.addActionLabel.Click += new System.EventHandler(this.addActionLabel_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.activitiesComboBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).EndInit();
            this.addActivityPanel.ResumeLayout(false);
            this.addActivityPanel.PerformLayout();
            this.removeActivityPanel.ResumeLayout(false);
            this.removeActivityPanel.PerformLayout();
            this.activitiesManagerPanel.ResumeLayout(false);
            this.activitiesManagerPanel.PerformLayout();
            this.removeActionPanel.ResumeLayout(false);
            this.removeActionPanel.PerformLayout();
            this.addActionPanel.ResumeLayout(false);
            this.addActionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView actionsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox activitiesComboBox;
        private System.Windows.Forms.Label activitiesListLabel;
        private System.Windows.Forms.Panel activitiesComboBoxPanel;
        private System.Windows.Forms.PictureBox closeButtonPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label actionsListLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label addActivityLabel;
        private System.Windows.Forms.Panel addActivityPanel;
        private System.Windows.Forms.Panel removeActivityPanel;
        private System.Windows.Forms.Label removeActivityLabel;
        private System.Windows.Forms.Panel activitiesManagerPanel;
        private System.Windows.Forms.Panel removeActionPanel;
        private System.Windows.Forms.Label removeActionLabel;
        private System.Windows.Forms.Panel addActionPanel;
        private System.Windows.Forms.Label addActionLabel;
    }
}