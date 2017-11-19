namespace MouseController
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
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.mainFormPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.infoStatusButton = new System.Windows.Forms.ToolStripButton();
            this.resultLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolTipLabel = new System.Windows.Forms.ToolStripLabel();
            this.activitiesManagerButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.areasManagerButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.conditionsManagerButton = new System.Windows.Forms.Button();
            this.mainFormPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // runTimer
            // 
            this.runTimer.Interval = 5000;
            this.runTimer.Tick += new System.EventHandler(this.runTimer_Tick);
            // 
            // mainFormPanel
            // 
            this.mainFormPanel.BackColor = System.Drawing.Color.White;
            this.mainFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainFormPanel.Controls.Add(this.toolStrip1);
            this.mainFormPanel.Controls.Add(this.activitiesManagerButton);
            this.mainFormPanel.Controls.Add(this.openButton);
            this.mainFormPanel.Controls.Add(this.areasManagerButton);
            this.mainFormPanel.Controls.Add(this.runButton);
            this.mainFormPanel.Controls.Add(this.resetButton);
            this.mainFormPanel.Controls.Add(this.stopButton);
            this.mainFormPanel.Controls.Add(this.closeButton);
            this.mainFormPanel.Controls.Add(this.conditionsManagerButton);
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
            this.infoStatusButton,
            this.resultLabel,
            this.toolTipLabel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 87);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip2";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown_1);
            // 
            // infoStatusButton
            // 
            this.infoStatusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoStatusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoStatusButton.Image = ((System.Drawing.Image)(resources.GetObject("infoStatusButton.Image")));
            this.infoStatusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoStatusButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.infoStatusButton.Name = "infoStatusButton";
            this.infoStatusButton.Size = new System.Drawing.Size(23, 22);
            this.infoStatusButton.Text = "toolStripButton1";
            this.infoStatusButton.ToolTipText = "Info";
            // 
            // resultLabel
            // 
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(140, 22);
            this.resultLabel.Text = "Result: 0 tasks completed";
            // 
            // toolTipLabel
            // 
            this.toolTipLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolTipLabel.Margin = new System.Windows.Forms.Padding(10, 1, 5, 2);
            this.toolTipLabel.Name = "toolTipLabel";
            this.toolTipLabel.Size = new System.Drawing.Size(186, 22);
            this.toolTipLabel.Text = "Hover a button to see instructions";
            // 
            // activitiesManagerButton
            // 
            this.activitiesManagerButton.BackColor = System.Drawing.Color.Orange;
            this.activitiesManagerButton.BackgroundImage = global::MouseController.Properties.Resources.LeftClick;
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
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.openButton.BackgroundImage = global::MouseController.Properties.Resources.OpenFile;
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Location = new System.Drawing.Point(7, 7);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 75);
            this.openButton.TabIndex = 0;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            this.openButton.MouseLeave += new System.EventHandler(this.openButton_MouseLeave);
            this.openButton.MouseHover += new System.EventHandler(this.openButton_MouseHover);
            // 
            // areasManagerButton
            // 
            this.areasManagerButton.BackColor = System.Drawing.Color.ForestGreen;
            this.areasManagerButton.BackgroundImage = global::MouseController.Properties.Resources.Areas;
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
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.runButton.BackgroundImage = global::MouseController.Properties.Resources.Run;
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
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetButton.BackgroundImage = global::MouseController.Properties.Resources.Erase;
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
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Orange;
            this.stopButton.BackgroundImage = global::MouseController.Properties.Resources.Stop;
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
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.BackgroundImage = global::MouseController.Properties.Resources.Close;
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
            // conditionsManagerButton
            // 
            this.conditionsManagerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.conditionsManagerButton.BackgroundImage = global::MouseController.Properties.Resources.Conditions;
            this.conditionsManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.conditionsManagerButton.FlatAppearance.BorderSize = 0;
            this.conditionsManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionsManagerButton.Location = new System.Drawing.Point(339, 7);
            this.conditionsManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.conditionsManagerButton.Name = "conditionsManagerButton";
            this.conditionsManagerButton.Size = new System.Drawing.Size(75, 75);
            this.conditionsManagerButton.TabIndex = 0;
            this.conditionsManagerButton.UseVisualStyleBackColor = false;
            this.conditionsManagerButton.Click += new System.EventHandler(this.actionSettingsButton_Click);
            this.conditionsManagerButton.MouseLeave += new System.EventHandler(this.actionSettingsButton_MouseLeave);
            this.conditionsManagerButton.MouseHover += new System.EventHandler(this.actionSettingsButton_MouseHover);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Button conditionsManagerButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer runTimer;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Panel mainFormPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel resultLabel;
        private System.Windows.Forms.ToolStripLabel toolTipLabel;
        private System.Windows.Forms.ToolStripButton infoStatusButton;
    }
}

