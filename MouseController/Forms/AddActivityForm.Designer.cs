﻿namespace MouseController
{
    partial class AddActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddActivityForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.addActivityLabel = new System.Windows.Forms.Label();
            this.closeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addActivityPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).BeginInit();
            this.addActivityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(25, 76);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 14);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "NAME";
            // 
            // addActivityLabel
            // 
            this.addActivityLabel.AutoSize = true;
            this.addActivityLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addActivityLabel.Location = new System.Drawing.Point(23, 20);
            this.addActivityLabel.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.addActivityLabel.Name = "addActivityLabel";
            this.addActivityLabel.Size = new System.Drawing.Size(191, 27);
            this.addActivityLabel.TabIndex = 1;
            this.addActivityLabel.Text = "ADD ACTIVITY";
            // 
            // closeButtonPictureBox
            // 
            this.closeButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButtonPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButtonPictureBox.BackgroundImage")));
            this.closeButtonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButtonPictureBox.Location = new System.Drawing.Point(377, 18);
            this.closeButtonPictureBox.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.closeButtonPictureBox.Name = "closeButtonPictureBox";
            this.closeButtonPictureBox.Size = new System.Drawing.Size(20, 20);
            this.closeButtonPictureBox.TabIndex = 2;
            this.closeButtonPictureBox.TabStop = false;
            this.closeButtonPictureBox.Click += new System.EventHandler(this.closeButtonPictureBox_Click);
            this.closeButtonPictureBox.MouseEnter += new System.EventHandler(this.closeButtonPictureBox_MouseEnter);
            this.closeButtonPictureBox.MouseLeave += new System.EventHandler(this.closeButtonPictureBox_MouseLeave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(85, 74);
            this.nameTextBox.MaximumSize = new System.Drawing.Size(2, 20);
            this.nameTextBox.MinimumSize = new System.Drawing.Size(200, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Type a name here...";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(224, 122);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(322, 122);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addActivityPanel
            // 
            this.addActivityPanel.BackColor = System.Drawing.Color.White;
            this.addActivityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addActivityPanel.Controls.Add(this.addActivityLabel);
            this.addActivityPanel.Controls.Add(this.cancelButton);
            this.addActivityPanel.Controls.Add(this.nameLabel);
            this.addActivityPanel.Controls.Add(this.addButton);
            this.addActivityPanel.Controls.Add(this.nameTextBox);
            this.addActivityPanel.Controls.Add(this.closeButtonPictureBox);
            this.addActivityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addActivityPanel.Location = new System.Drawing.Point(0, 0);
            this.addActivityPanel.Name = "addActivityPanel";
            this.addActivityPanel.Padding = new System.Windows.Forms.Padding(10);
            this.addActivityPanel.Size = new System.Drawing.Size(417, 165);
            this.addActivityPanel.TabIndex = 5;
            this.addActivityPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addActivityPanel_MouseDown);
            // 
            // AddActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 165);
            this.Controls.Add(this.addActivityPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddActivityForm";
            this.Load += new System.EventHandler(this.AddActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).EndInit();
            this.addActivityPanel.ResumeLayout(false);
            this.addActivityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addActivityLabel;
        private System.Windows.Forms.PictureBox closeButtonPictureBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        protected System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel addActivityPanel;
    }
}