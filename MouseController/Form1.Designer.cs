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
            this.runButton = new System.Windows.Forms.Button();
            this.conditionalAreaButton = new System.Windows.Forms.Button();
            this.actionAreaButton = new System.Windows.Forms.Button();
            this.actionSettingsButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.OrangeRed;
            this.runButton.FlatAppearance.BorderSize = 0;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Location = new System.Drawing.Point(276, 15);
            this.runButton.Margin = new System.Windows.Forms.Padding(6);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 75);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // conditionalAreaButton
            // 
            this.conditionalAreaButton.BackColor = System.Drawing.Color.ForestGreen;
            this.conditionalAreaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.conditionalAreaButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.conditionalAreaButton.FlatAppearance.BorderSize = 0;
            this.conditionalAreaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionalAreaButton.Location = new System.Drawing.Point(189, 102);
            this.conditionalAreaButton.Margin = new System.Windows.Forms.Padding(6);
            this.conditionalAreaButton.Name = "conditionalAreaButton";
            this.conditionalAreaButton.Size = new System.Drawing.Size(75, 75);
            this.conditionalAreaButton.TabIndex = 5;
            this.conditionalAreaButton.Text = "Select the conditional area";
            this.conditionalAreaButton.UseVisualStyleBackColor = false;
            this.conditionalAreaButton.Click += new System.EventHandler(this.conditionalAreaButton_Click);
            // 
            // actionAreaButton
            // 
            this.actionAreaButton.BackColor = System.Drawing.Color.Orange;
            this.actionAreaButton.FlatAppearance.BorderSize = 0;
            this.actionAreaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionAreaButton.Location = new System.Drawing.Point(189, 15);
            this.actionAreaButton.Margin = new System.Windows.Forms.Padding(6);
            this.actionAreaButton.Name = "actionAreaButton";
            this.actionAreaButton.Size = new System.Drawing.Size(75, 75);
            this.actionAreaButton.TabIndex = 5;
            this.actionAreaButton.Text = "Select the action area";
            this.actionAreaButton.UseVisualStyleBackColor = false;
            this.actionAreaButton.Click += new System.EventHandler(this.actionAreaButton_Click);
            // 
            // actionSettingsButton
            // 
            this.actionSettingsButton.BackColor = System.Drawing.Color.Gray;
            this.actionSettingsButton.FlatAppearance.BorderSize = 0;
            this.actionSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionSettingsButton.Location = new System.Drawing.Point(15, 15);
            this.actionSettingsButton.Margin = new System.Windows.Forms.Padding(6);
            this.actionSettingsButton.Name = "actionSettingsButton";
            this.actionSettingsButton.Size = new System.Drawing.Size(162, 75);
            this.actionSettingsButton.TabIndex = 0;
            this.actionSettingsButton.Text = "Action Settings";
            this.actionSettingsButton.UseVisualStyleBackColor = false;
            this.actionSettingsButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(363, 15);
            this.stopButton.Margin = new System.Windows.Forms.Padding(6);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 75);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(276, 102);
            this.closeButton.Margin = new System.Windows.Forms.Padding(6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(162, 75);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 183);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(43, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result: ";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.YellowGreen;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(102, 102);
            this.resetButton.Margin = new System.Windows.Forms.Padding(6);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 75);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset All";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // runTimer
            // 
            this.runTimer.Interval = 5000;
            this.runTimer.Tick += new System.EventHandler(this.runTimer_Tick);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.Gray;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Location = new System.Drawing.Point(15, 102);
            this.openButton.Margin = new System.Windows.Forms.Padding(6);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 75);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open profile";
            this.openButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 205);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.actionAreaButton);
            this.Controls.Add(this.conditionalAreaButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.actionSettingsButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.runButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Mouse Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button conditionalAreaButton;
        private System.Windows.Forms.Button actionAreaButton;
        private System.Windows.Forms.Button actionSettingsButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer runTimer;
        private System.Windows.Forms.Button openButton;
    }
}

