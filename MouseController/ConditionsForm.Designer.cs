namespace MouseController
{
    partial class ConditionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionsForm));
            this.conditionsFormPanel = new System.Windows.Forms.Panel();
            this.conditionsLabel = new System.Windows.Forms.Label();
            this.closeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.conditionsFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionsFormPanel
            // 
            this.conditionsFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conditionsFormPanel.Controls.Add(this.acceptButton);
            this.conditionsFormPanel.Controls.Add(this.cancelButton);
            this.conditionsFormPanel.Controls.Add(this.conditionsLabel);
            this.conditionsFormPanel.Controls.Add(this.closeButtonPictureBox);
            this.conditionsFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conditionsFormPanel.Location = new System.Drawing.Point(0, 0);
            this.conditionsFormPanel.Name = "conditionsFormPanel";
            this.conditionsFormPanel.Padding = new System.Windows.Forms.Padding(10);
            this.conditionsFormPanel.Size = new System.Drawing.Size(573, 283);
            this.conditionsFormPanel.TabIndex = 0;
            this.conditionsFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.conditionsFormPanel_MouseDown);
            // 
            // conditionsLabel
            // 
            this.conditionsLabel.AutoSize = true;
            this.conditionsLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.conditionsLabel.Location = new System.Drawing.Point(23, 20);
            this.conditionsLabel.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.conditionsLabel.Name = "conditionsLabel";
            this.conditionsLabel.Size = new System.Drawing.Size(177, 27);
            this.conditionsLabel.TabIndex = 3;
            this.conditionsLabel.Text = "CONDITIONS";
            // 
            // closeButtonPictureBox
            // 
            this.closeButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButtonPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButtonPictureBox.BackgroundImage")));
            this.closeButtonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButtonPictureBox.Location = new System.Drawing.Point(531, 20);
            this.closeButtonPictureBox.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.closeButtonPictureBox.Name = "closeButtonPictureBox";
            this.closeButtonPictureBox.Size = new System.Drawing.Size(20, 20);
            this.closeButtonPictureBox.TabIndex = 4;
            this.closeButtonPictureBox.TabStop = false;
            this.closeButtonPictureBox.Click += new System.EventHandler(this.closeButtonPictureBox_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acceptButton.Location = new System.Drawing.Point(378, 238);
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
            this.cancelButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(476, 238);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConditionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 283);
            this.Controls.Add(this.conditionsFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConditionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConditionsForm";
            this.Load += new System.EventHandler(this.ConditionsForm_Load);
            this.conditionsFormPanel.ResumeLayout(false);
            this.conditionsFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conditionsFormPanel;
        private System.Windows.Forms.Label conditionsLabel;
        private System.Windows.Forms.PictureBox closeButtonPictureBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}