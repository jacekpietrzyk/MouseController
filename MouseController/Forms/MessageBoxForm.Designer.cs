namespace MouseController
{
    partial class MessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.headlineLabel = new System.Windows.Forms.Label();
            this.closeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.MessageBoxPanel = new System.Windows.Forms.Panel();
            this.yesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).BeginInit();
            this.MessageBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headlineLabel.Location = new System.Drawing.Point(20, 20);
            this.headlineLabel.Margin = new System.Windows.Forms.Padding(10);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(210, 31);
            this.headlineLabel.TabIndex = 8;
            this.headlineLabel.Text = "SAVE PROFILE";
            // 
            // closeButtonPictureBox
            // 
            this.closeButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButtonPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButtonPictureBox.BackgroundImage")));
            this.closeButtonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButtonPictureBox.Location = new System.Drawing.Point(397, 20);
            this.closeButtonPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.closeButtonPictureBox.Name = "closeButtonPictureBox";
            this.closeButtonPictureBox.Size = new System.Drawing.Size(20, 20);
            this.closeButtonPictureBox.TabIndex = 7;
            this.closeButtonPictureBox.TabStop = false;
            this.closeButtonPictureBox.Click += new System.EventHandler(this.closeButtonPictureBox_Click);
            this.closeButtonPictureBox.MouseEnter += new System.EventHandler(this.closeButtonPictureBox_MouseEnter);
            this.closeButtonPictureBox.MouseLeave += new System.EventHandler(this.closeButtonPictureBox_MouseLeave);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(22, 76);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(279, 20);
            this.questionLabel.TabIndex = 8;
            this.questionLabel.Text = "Do you want to save your work profile?";
            // 
            // noButton
            // 
            this.noButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noButton.Location = new System.Drawing.Point(178, 123);
            this.noButton.Margin = new System.Windows.Forms.Padding(10);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 9;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(273, 123);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MessageBoxPanel
            // 
            this.MessageBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageBoxPanel.Controls.Add(this.yesButton);
            this.MessageBoxPanel.Controls.Add(this.noButton);
            this.MessageBoxPanel.Controls.Add(this.headlineLabel);
            this.MessageBoxPanel.Controls.Add(this.questionLabel);
            this.MessageBoxPanel.Controls.Add(this.closeButtonPictureBox);
            this.MessageBoxPanel.Controls.Add(this.cancelButton);
            this.MessageBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.MessageBoxPanel.Name = "MessageBoxPanel";
            this.MessageBoxPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MessageBoxPanel.Size = new System.Drawing.Size(439, 168);
            this.MessageBoxPanel.TabIndex = 11;
            this.MessageBoxPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MessageBoxPanel_MouseDown);
            // 
            // yesButton
            // 
            this.yesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yesButton.Location = new System.Drawing.Point(83, 123);
            this.yesButton.Margin = new System.Windows.Forms.Padding(10);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 9;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 168);
            this.Controls.Add(this.MessageBoxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxForm";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPictureBox)).EndInit();
            this.MessageBoxPanel.ResumeLayout(false);
            this.MessageBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButtonPictureBox;
        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel MessageBoxPanel;
        private System.Windows.Forms.Button yesButton;
    }
}