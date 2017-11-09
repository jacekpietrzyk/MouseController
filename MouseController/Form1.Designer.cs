namespace MouseController
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.runButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.actionButton = new System.Windows.Forms.Button();
            this.actionSettingsButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.openButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.resultLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTipLabel = new System.Windows.Forms.ToolStripLabel();
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
            // areaButton
            // 
            this.areaButton.BackColor = System.Drawing.Color.ForestGreen;
            this.areaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("areaButton.BackgroundImage")));
            this.areaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.areaButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.areaButton.FlatAppearance.BorderSize = 0;
            this.areaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areaButton.Location = new System.Drawing.Point(173, 7);
            this.areaButton.Margin = new System.Windows.Forms.Padding(4);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(75, 75);
            this.areaButton.TabIndex = 5;
            this.areaButton.UseVisualStyleBackColor = false;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            this.areaButton.MouseLeave += new System.EventHandler(this.areaButton_MouseLeave);
            this.areaButton.MouseHover += new System.EventHandler(this.areaButton_MouseHover);
            // 
            // actionButton
            // 
            this.actionButton.BackColor = System.Drawing.Color.Orange;
            this.actionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actionButton.BackgroundImage")));
            this.actionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.actionButton.FlatAppearance.BorderSize = 0;
            this.actionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionButton.Location = new System.Drawing.Point(256, 7);
            this.actionButton.Margin = new System.Windows.Forms.Padding(4);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 75);
            this.actionButton.TabIndex = 5;
            this.actionButton.UseVisualStyleBackColor = false;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            this.actionButton.MouseLeave += new System.EventHandler(this.actionButton_MouseLeave);
            this.actionButton.MouseHover += new System.EventHandler(this.actionButton_MouseHover);
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
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultLabel,
            this.toolStripSeparator1,
            this.toolTipLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 87);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // resultLabel
            // 
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(140, 22);
            this.resultLabel.Text = "Result: 0 tasks completed";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolTipLabel
            // 
            this.toolTipLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolTipLabel.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolTipLabel.Name = "toolTipLabel";
            this.toolTipLabel.Size = new System.Drawing.Size(186, 22);
            this.toolTipLabel.Text = "Hover a button to see instructions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 112);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.actionSettingsButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.runButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Mouse Controller";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Button actionSettingsButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer runTimer;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel resultLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolTipLabel;
    }
}

