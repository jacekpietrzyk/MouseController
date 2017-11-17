namespace MouseController
{
    partial class ConditionsManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionsManagerForm));
            this.conditionsFormPanel = new System.Windows.Forms.Panel();
            this.conditionsDataGridView = new System.Windows.Forms.DataGridView();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.conditionsManagerLabel = new System.Windows.Forms.Label();
            this.closeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.conditionsFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionsFormPanel
            // 
            this.conditionsFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conditionsFormPanel.Controls.Add(this.conditionsDataGridView);
            this.conditionsFormPanel.Controls.Add(this.acceptButton);
            this.conditionsFormPanel.Controls.Add(this.cancelButton);
            this.conditionsFormPanel.Controls.Add(this.conditionsManagerLabel);
            this.conditionsFormPanel.Controls.Add(this.closeButtonPictureBox);
            this.conditionsFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conditionsFormPanel.Location = new System.Drawing.Point(0, 0);
            this.conditionsFormPanel.Name = "conditionsFormPanel";
            this.conditionsFormPanel.Padding = new System.Windows.Forms.Padding(10);
            this.conditionsFormPanel.Size = new System.Drawing.Size(455, 358);
            this.conditionsFormPanel.TabIndex = 0;
            this.conditionsFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.conditionsFormPanel_MouseDown);
            // 
            // conditionsDataGridView
            // 
            this.conditionsDataGridView.AllowUserToAddRows = false;
            this.conditionsDataGridView.AllowUserToDeleteRows = false;
            this.conditionsDataGridView.AllowUserToResizeColumns = false;
            this.conditionsDataGridView.AllowUserToResizeRows = false;
            this.conditionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conditionsDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.conditionsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.conditionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conditionsDataGridView.Location = new System.Drawing.Point(20, 81);
            this.conditionsDataGridView.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.conditionsDataGridView.Name = "conditionsDataGridView";
            this.conditionsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.conditionsDataGridView.ShowCellToolTips = false;
            this.conditionsDataGridView.Size = new System.Drawing.Size(413, 202);
            this.conditionsDataGridView.TabIndex = 10;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acceptButton.Location = new System.Drawing.Point(260, 313);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 8;
            this.acceptButton.Text = "ACCEPT";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(358, 313);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // conditionsManagerLabel
            // 
            this.conditionsManagerLabel.AutoSize = true;
            this.conditionsManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.conditionsManagerLabel.Location = new System.Drawing.Point(20, 20);
            this.conditionsManagerLabel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 15);
            this.conditionsManagerLabel.Name = "conditionsManagerLabel";
            this.conditionsManagerLabel.Size = new System.Drawing.Size(331, 31);
            this.conditionsManagerLabel.TabIndex = 3;
            this.conditionsManagerLabel.Text = "CONDITIONS MANAGER";
            // 
            // closeButtonPictureBox
            // 
            this.closeButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButtonPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButtonPictureBox.BackgroundImage")));
            this.closeButtonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButtonPictureBox.Location = new System.Drawing.Point(413, 20);
            this.closeButtonPictureBox.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.closeButtonPictureBox.Name = "closeButtonPictureBox";
            this.closeButtonPictureBox.Size = new System.Drawing.Size(20, 20);
            this.closeButtonPictureBox.TabIndex = 4;
            this.closeButtonPictureBox.TabStop = false;
            this.closeButtonPictureBox.Click += new System.EventHandler(this.closeButtonPictureBox_Click);
            this.closeButtonPictureBox.MouseEnter += new System.EventHandler(this.closeButtonPictureBox_MouseEnter);
            this.closeButtonPictureBox.MouseLeave += new System.EventHandler(this.closeButtonPictureBox_MouseLeave);
            // 
            // ConditionsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 358);
            this.Controls.Add(this.conditionsFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConditionsManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Conditions Manager Form";
            this.Load += new System.EventHandler(this.ConditionsForm_Load);
            this.conditionsFormPanel.ResumeLayout(false);
            this.conditionsFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conditionsFormPanel;
        private System.Windows.Forms.Label conditionsManagerLabel;
        private System.Windows.Forms.PictureBox closeButtonPictureBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView conditionsDataGridView;
    }
}