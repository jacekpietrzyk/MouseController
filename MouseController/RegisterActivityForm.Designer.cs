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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterActivityForm));
            this.actionsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activitiesComboBox = new System.Windows.Forms.ComboBox();
            this.activitiesListLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actionsListLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addActivityPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addActivityPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsDataGridView
            // 
            this.actionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.actionsDataGridView.Name = "actionsDataGridView";
            this.actionsDataGridView.Size = new System.Drawing.Size(553, 224);
            this.actionsDataGridView.TabIndex = 0;
            this.actionsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.actionsDataGridView);
            this.panel1.Location = new System.Drawing.Point(25, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 224);
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
            this.activitiesComboBox.Size = new System.Drawing.Size(255, 21);
            this.activitiesComboBox.TabIndex = 2;
            this.activitiesComboBox.SelectedIndexChanged += new System.EventHandler(this.activitiesComboBox_SelectedIndexChanged);
            // 
            // activitiesListLabel
            // 
            this.activitiesListLabel.AutoSize = true;
            this.activitiesListLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activitiesListLabel.Location = new System.Drawing.Point(22, 81);
            this.activitiesListLabel.Name = "activitiesListLabel";
            this.activitiesListLabel.Size = new System.Drawing.Size(129, 14);
            this.activitiesListLabel.TabIndex = 3;
            this.activitiesListLabel.Text = "SAVED ACTIVITIES";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.activitiesComboBox);
            this.panel2.Location = new System.Drawing.Point(167, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 24);
            this.panel2.TabIndex = 4;
            // 
            // closeButtonPictureBox
            // 
            this.closeButtonPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButtonPictureBox.BackgroundImage")));
            this.closeButtonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButtonPictureBox.Location = new System.Drawing.Point(573, 12);
            this.closeButtonPictureBox.Name = "closeButtonPictureBox";
            this.closeButtonPictureBox.Size = new System.Drawing.Size(20, 20);
            this.closeButtonPictureBox.TabIndex = 5;
            this.closeButtonPictureBox.TabStop = false;
            this.closeButtonPictureBox.Click += new System.EventHandler(this.closeButtonPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "ACTIVITIES";
            // 
            // actionsListLabel
            // 
            this.actionsListLabel.AutoSize = true;
            this.actionsListLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionsListLabel.Location = new System.Drawing.Point(22, 129);
            this.actionsListLabel.Name = "actionsListLabel";
            this.actionsListLabel.Size = new System.Drawing.Size(102, 14);
            this.actionsListLabel.TabIndex = 3;
            this.actionsListLabel.Text = "ACTIONS LIST";
            // 
            // acceptButton
            // 
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acceptButton.Location = new System.Drawing.Point(412, 443);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "ACCEPT";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(503, 443);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addActivityPictureBox
            // 
            this.addActivityPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addActivityPictureBox.BackgroundImage")));
            this.addActivityPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addActivityPictureBox.Location = new System.Drawing.Point(441, 72);
            this.addActivityPictureBox.Name = "addActivityPictureBox";
            this.addActivityPictureBox.Size = new System.Drawing.Size(31, 31);
            this.addActivityPictureBox.TabIndex = 8;
            this.addActivityPictureBox.TabStop = false;
            this.addActivityPictureBox.Click += new System.EventHandler(this.addActivityPictureBox_Click);
            // 
            // RegisterActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 483);
            this.Controls.Add(this.addActivityPictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButtonPictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.actionsListLabel);
            this.Controls.Add(this.activitiesListLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterActivityForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterActivityForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.actionsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addActivityPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView actionsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox activitiesComboBox;
        private System.Windows.Forms.Label activitiesListLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeButtonPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label actionsListLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox addActivityPictureBox;
    }
}