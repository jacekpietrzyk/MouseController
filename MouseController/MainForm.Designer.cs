﻿namespace MouseController
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.runButton = new System.Windows.Forms.Button();
            this.areasManagerButton = new System.Windows.Forms.Button();
            this.activitiesManagerButton = new System.Windows.Forms.Button();
            this.actionSettingsButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.openButton = new System.Windows.Forms.Button();
            this.mainFormPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.resultLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolTipLabel = new System.Windows.Forms.ToolStripLabel();
            this.mainFormPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.runButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("runButton.BackgroundImage")));
            this.runButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.runButton.FlatAppearance.BorderSize = 0;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Location = new System.Drawing.Point(422, 7);
            this.runButton.Margin = new System.Windows.Forms.Padding(4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 75);
            this.runButton.TabIndex = 0;
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            this.runButton.MouseLeave += new System.EventHandler(this.runButton_MouseLeave);
            this.runButton.MouseHover += new System.EventHandler(this.runButton_MouseHover);
            // 
            // areasManagerButton
            // 
            this.areasManagerButton.BackColor = System.Drawing.Color.ForestGreen;
            this.areasManagerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("areasManagerButton.BackgroundImage")));
            this.areasManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.areasManagerButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.areasManagerButton.FlatAppearance.BorderSize = 0;
            this.areasManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areasManagerButton.Location = new System.Drawing.Point(173, 7);
            this.areasManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.areasManagerButton.Name = "areasManagerButton";
            this.areasManagerButton.Size = new System.Drawing.Size(75, 75);
            this.areasManagerButton.TabIndex = 5;
            this.areasManagerButton.UseVisualStyleBackColor = false;
            this.areasManagerButton.Click += new System.EventHandler(this.areasManagerButton_Click);
            this.areasManagerButton.MouseLeave += new System.EventHandler(this.areasManagerButton_MouseLeave);
            this.areasManagerButton.MouseHover += new System.EventHandler(this.areasManagerButton_MouseHover);
            // 
            // activitiesManagerButton
            // 
            this.activitiesManagerButton.BackColor = System.Drawing.Color.Orange;
            this.activitiesManagerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("activitiesManagerButton.BackgroundImage")));
            this.activitiesManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.activitiesManagerButton.FlatAppearance.BorderSize = 0;
            this.activitiesManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activitiesManagerButton.Location = new System.Drawing.Point(256, 7);
            this.activitiesManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.activitiesManagerButton.Name = "activitiesManagerButton";
            this.activitiesManagerButton.Size = new System.Drawing.Size(75, 75);
            this.activitiesManagerButton.TabIndex = 5;
            this.activitiesManagerButton.UseVisualStyleBackColor = false;
            this.activitiesManagerButton.Click += new System.EventHandler(this.activitiesManagerButton_Click);
            this.activitiesManagerButton.MouseLeave += new System.EventHandler(this.activitiesManagerButton_MouseLeave);
            this.activitiesManagerButton.MouseHover += new System.EventHandler(this.activitiesManagerButton_MouseHover);
            // 
            // actionSettingsButton
            // 
            this.actionSettingsButton.BackColor = System.Drawing.Color.Gray;
            this.actionSettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actionSettingsButton.BackgroundImage")));
            this.actionSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.actionSettingsButton.FlatAppearance.BorderSize = 0;
            this.actionSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionSettingsButton.Location = new System.Drawing.Point(339, 7);
            this.actionSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.actionSettingsButton.Name = "actionSettingsButton";
            this.actionSettingsButton.Size = new System.Drawing.Size(75, 75);
            this.actionSettingsButton.TabIndex = 0;
            this.actionSettingsButton.UseVisualStyleBackColor = false;
            this.actionSettingsButton.Click += new System.EventHandler(this.runButton_Click);
            this.actionSettingsButton.MouseLeave += new System.EventHandler(this.actionSettingsButton_MouseLeave);
            this.actionSettingsButton.MouseHover += new System.EventHandler(this.actionSettingsButton_MouseHover);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(505, 7);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 75);
            this.stopButton.TabIndex = 0;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            this.stopButton.MouseLeave += new System.EventHandler(this.stopButton_MouseLeave);
            this.stopButton.MouseHover += new System.EventHandler(this.stopButton_MouseHover);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(588, 7);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 75);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetButton.BackgroundImage")));
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(90, 7);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 75);
            this.resetButton.TabIndex = 0;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            this.resetButton.MouseLeave += new System.EventHandler(this.resetButton_MouseLeave);
            this.resetButton.MouseHover += new System.EventHandler(this.resetButton_MouseHover);
            // 
            // runTimer
            // 
            this.runTimer.Interval = 5000;
            this.runTimer.Tick += new System.EventHandler(this.runTimer_Tick);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.Orange;
            this.openButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openButton.BackgroundImage")));
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openButton.Enabled = false;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Location = new System.Drawing.Point(7, 7);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 75);
            this.openButton.TabIndex = 0;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.MouseLeave += new System.EventHandler(this.openButton_MouseLeave);
            this.openButton.MouseHover += new System.EventHandler(this.openButton_MouseHover);
            // 
            // mainFormPanel
            // 
            this.mainFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainFormPanel.Controls.Add(this.toolStrip1);
            this.mainFormPanel.Controls.Add(this.activitiesManagerButton);
            this.mainFormPanel.Controls.Add(this.openButton);
            this.mainFormPanel.Controls.Add(this.areasManagerButton);
            this.mainFormPanel.Controls.Add(this.runButton);
            this.mainFormPanel.Controls.Add(this.resetButton);
            this.mainFormPanel.Controls.Add(this.stopButton);
            this.mainFormPanel.Controls.Add(this.closeButton);
            this.mainFormPanel.Controls.Add(this.actionSettingsButton);
            this.mainFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFormPanel.Name = "mainFormPanel";
            this.mainFormPanel.Padding = new System.Windows.Forms.Padding(3);
            this.mainFormPanel.Size = new System.Drawing.Size(672, 117);
            this.mainFormPanel.TabIndex = 9;
            this.mainFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainFormPanel_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(1);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultLabel,
            this.toolTipLabel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 87);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip2";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown_1);
            // 
            // resultLabel
            // 
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(140, 22);
            this.resultLabel.Text = "Result: 0 tasks completed";
            // 
            // toolTipLabel
            // 
            this.toolTipLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolTipLabel.Name = "toolTipLabel";
            this.toolTipLabel.Size = new System.Drawing.Size(186, 22);
            this.toolTipLabel.Text = "Hover a button to see instructions";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 117);
            this.Controls.Add(this.mainFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Controller";
            this.mainFormPanel.ResumeLayout(false);
            this.mainFormPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button areasManagerButton;
        private System.Windows.Forms.Button activitiesManagerButton;
        private System.Windows.Forms.Button actionSettingsButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer runTimer;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Panel mainFormPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel resultLabel;
        private System.Windows.Forms.ToolStripLabel toolTipLabel;
    }
}
