﻿namespace MouseController
{
    partial class AreasManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreasManagerForm));
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.areasManagerPanel = new System.Windows.Forms.Panel();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.editAreaPanel = new System.Windows.Forms.Panel();
            this.removeAreaPanel = new System.Windows.Forms.Panel();
            this.addAreaPanel = new System.Windows.Forms.Panel();
            this.areasComboBoxPanel = new System.Windows.Forms.Panel();
            this.areasComboBox = new System.Windows.Forms.ComboBox();
            this.savedAreasLabel = new System.Windows.Forms.Label();
            this.areasLabel = new System.Windows.Forms.Label();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.areasManagerPanel.SuspendLayout();
            this.previewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.areasComboBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acceptButton.Location = new System.Drawing.Point(358, 129);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(10);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "ACCEPT";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(453, 129);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // areasManagerPanel
            // 
            this.areasManagerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areasManagerPanel.Controls.Add(this.previewPanel);
            this.areasManagerPanel.Controls.Add(this.editAreaPanel);
            this.areasManagerPanel.Controls.Add(this.removeAreaPanel);
            this.areasManagerPanel.Controls.Add(this.addAreaPanel);
            this.areasManagerPanel.Controls.Add(this.areasComboBoxPanel);
            this.areasManagerPanel.Controls.Add(this.savedAreasLabel);
            this.areasManagerPanel.Controls.Add(this.areasLabel);
            this.areasManagerPanel.Controls.Add(this.closePictureBox);
            this.areasManagerPanel.Controls.Add(this.cancelButton);
            this.areasManagerPanel.Controls.Add(this.acceptButton);
            this.areasManagerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areasManagerPanel.Location = new System.Drawing.Point(0, 0);
            this.areasManagerPanel.Name = "areasManagerPanel";
            this.areasManagerPanel.Size = new System.Drawing.Size(548, 172);
            this.areasManagerPanel.TabIndex = 13;
            this.areasManagerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.areasManagerPanel_MouseDown);
            // 
            // previewPanel
            // 
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPanel.Controls.Add(this.previewPictureBox);
            this.previewPanel.Location = new System.Drawing.Point(144, 73);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(35, 24);
            this.previewPanel.TabIndex = 31;
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BackColor = System.Drawing.Color.Firebrick;
            this.previewPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewPictureBox.BackgroundImage")));
            this.previewPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previewPictureBox.Location = new System.Drawing.Point(-4, -6);
            this.previewPictureBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(40, 35);
            this.previewPictureBox.TabIndex = 27;
            this.previewPictureBox.TabStop = false;
            // 
            // editAreaPanel
            // 
            this.editAreaPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editAreaPanel.BackgroundImage")));
            this.editAreaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editAreaPanel.Location = new System.Drawing.Point(453, 73);
            this.editAreaPanel.Name = "editAreaPanel";
            this.editAreaPanel.Size = new System.Drawing.Size(24, 24);
            this.editAreaPanel.TabIndex = 18;
            this.editAreaPanel.Click += new System.EventHandler(this.editAreaPanel_Click);
            this.editAreaPanel.MouseEnter += new System.EventHandler(this.editAreaPanel_MouseEnter);
            this.editAreaPanel.MouseLeave += new System.EventHandler(this.editAreaPanel_MouseLeave);
            // 
            // removeAreaPanel
            // 
            this.removeAreaPanel.BackgroundImage = global::MouseController.Properties.Resources.removeIcon;
            this.removeAreaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeAreaPanel.Location = new System.Drawing.Point(418, 73);
            this.removeAreaPanel.Name = "removeAreaPanel";
            this.removeAreaPanel.Size = new System.Drawing.Size(24, 24);
            this.removeAreaPanel.TabIndex = 18;
            this.removeAreaPanel.Click += new System.EventHandler(this.removeAreaPanel_Click);
            this.removeAreaPanel.MouseEnter += new System.EventHandler(this.removeAreaPanel_MouseEnter);
            this.removeAreaPanel.MouseLeave += new System.EventHandler(this.removeAreaPanel_MouseLeave);
            // 
            // addAreaPanel
            // 
            this.addAreaPanel.BackgroundImage = global::MouseController.Properties.Resources.addIcon;
            this.addAreaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addAreaPanel.Location = new System.Drawing.Point(382, 73);
            this.addAreaPanel.Name = "addAreaPanel";
            this.addAreaPanel.Size = new System.Drawing.Size(24, 24);
            this.addAreaPanel.TabIndex = 17;
            this.addAreaPanel.Click += new System.EventHandler(this.addAreaPanel_Click);
            this.addAreaPanel.MouseEnter += new System.EventHandler(this.addAreaPanel_MouseEnter);
            this.addAreaPanel.MouseLeave += new System.EventHandler(this.addAreaPanel_MouseLeave);
            // 
            // areasComboBoxPanel
            // 
            this.areasComboBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areasComboBoxPanel.Controls.Add(this.areasComboBox);
            this.areasComboBoxPanel.Location = new System.Drawing.Point(178, 73);
            this.areasComboBoxPanel.Name = "areasComboBoxPanel";
            this.areasComboBoxPanel.Size = new System.Drawing.Size(176, 24);
            this.areasComboBoxPanel.TabIndex = 16;
            // 
            // areasComboBox
            // 
            this.areasComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areasComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areasComboBox.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.areasComboBox.FormattingEnabled = true;
            this.areasComboBox.Location = new System.Drawing.Point(0, 0);
            this.areasComboBox.Name = "areasComboBox";
            this.areasComboBox.Size = new System.Drawing.Size(174, 21);
            this.areasComboBox.TabIndex = 15;
            this.areasComboBox.SelectedIndexChanged += new System.EventHandler(this.areasComboBox_SelectedIndexChanged);
            // 
            // savedAreasLabel
            // 
            this.savedAreasLabel.AutoSize = true;
            this.savedAreasLabel.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.savedAreasLabel.Location = new System.Drawing.Point(18, 78);
            this.savedAreasLabel.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.savedAreasLabel.Name = "savedAreasLabel";
            this.savedAreasLabel.Size = new System.Drawing.Size(99, 13);
            this.savedAreasLabel.TabIndex = 14;
            this.savedAreasLabel.Text = "SAVED AREAS:";
            // 
            // areasLabel
            // 
            this.areasLabel.AutoSize = true;
            this.areasLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.areasLabel.Location = new System.Drawing.Point(16, 18);
            this.areasLabel.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.areasLabel.Name = "areasLabel";
            this.areasLabel.Size = new System.Drawing.Size(238, 27);
            this.areasLabel.TabIndex = 13;
            this.areasLabel.Text = "AREAS MANAGER";
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePictureBox.Location = new System.Drawing.Point(508, 18);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(20, 20);
            this.closePictureBox.TabIndex = 11;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            this.closePictureBox.MouseEnter += new System.EventHandler(this.closePictureBox_MouseEnter);
            this.closePictureBox.MouseLeave += new System.EventHandler(this.closePictureBox_MouseLeave);
            // 
            // AreasManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 172);
            this.Controls.Add(this.areasManagerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreasManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Area";
            this.Load += new System.EventHandler(this.AreasManagerForm_Load);
            this.areasManagerPanel.ResumeLayout(false);
            this.areasManagerPanel.PerformLayout();
            this.previewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.areasComboBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Panel areasManagerPanel;
        private System.Windows.Forms.Label areasLabel;
        private System.Windows.Forms.ComboBox areasComboBox;
        private System.Windows.Forms.Label savedAreasLabel;
        private System.Windows.Forms.Panel areasComboBoxPanel;
        private System.Windows.Forms.Panel addAreaPanel;
        private System.Windows.Forms.Panel removeAreaPanel;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Panel editAreaPanel;
    }
}