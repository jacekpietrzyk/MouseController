namespace MouseController
{
    partial class RegisterAreaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAreaForm));
            this.infoLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouseToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startPositionLabel = new System.Windows.Forms.Label();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.startPositionValueLabel = new System.Windows.Forms.Label();
            this.dimensionsValueLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(107, 21);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.infoLabel.Size = new System.Drawing.Size(286, 34);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Make sure the element you want to save is visible on the screen";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 193);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(505, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip";
            // 
            // mouseToolStripStatusLabel
            // 
            this.mouseToolStripStatusLabel.Name = "mouseToolStripStatusLabel";
            this.mouseToolStripStatusLabel.Size = new System.Drawing.Size(151, 17);
            this.mouseToolStripStatusLabel.Text = "mouseToolStripStatusLabel";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // startPositionLabel
            // 
            this.startPositionLabel.AutoSize = true;
            this.startPositionLabel.Location = new System.Drawing.Point(22, 106);
            this.startPositionLabel.Name = "startPositionLabel";
            this.startPositionLabel.Size = new System.Drawing.Size(75, 13);
            this.startPositionLabel.TabIndex = 2;
            this.startPositionLabel.Text = "Start Position: ";
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Location = new System.Drawing.Point(22, 130);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(67, 13);
            this.dimensionsLabel.TabIndex = 3;
            this.dimensionsLabel.Text = "Dimensions: ";
            // 
            // startPositionValueLabel
            // 
            this.startPositionValueLabel.AutoSize = true;
            this.startPositionValueLabel.Location = new System.Drawing.Point(103, 106);
            this.startPositionValueLabel.Name = "startPositionValueLabel";
            this.startPositionValueLabel.Size = new System.Drawing.Size(345, 13);
            this.startPositionValueLabel.TabIndex = 4;
            this.startPositionValueLabel.Text = "Go to start point and press S key. Then go to end point and press E key";
            // 
            // dimensionsValueLabel
            // 
            this.dimensionsValueLabel.AutoSize = true;
            this.dimensionsValueLabel.Location = new System.Drawing.Point(104, 130);
            this.dimensionsValueLabel.Name = "dimensionsValueLabel";
            this.dimensionsValueLabel.Size = new System.Drawing.Size(100, 13);
            this.dimensionsValueLabel.TabIndex = 5;
            this.dimensionsValueLabel.Text = "No bitmap captured";
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Location = new System.Drawing.Point(337, 157);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(418, 157);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captureButton.Location = new System.Drawing.Point(25, 21);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(85, 34);
            this.captureButton.TabIndex = 9;
            this.captureButton.Text = "Capture Area";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BackColor = System.Drawing.Color.Firebrick;
            this.previewPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewPictureBox.BackgroundImage")));
            this.previewPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPictureBox.Location = new System.Drawing.Point(392, 21);
            this.previewPictureBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(43, 34);
            this.previewPictureBox.TabIndex = 10;
            this.previewPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(461, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(107, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(267, 20);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.Text = "Type a name here...";
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // RegisterAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 215);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.previewPictureBox);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.dimensionsValueLabel);
            this.Controls.Add(this.startPositionValueLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dimensionsLabel);
            this.Controls.Add(this.startPositionLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterAreaForm";
            this.Text = "Register Area";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterAreaForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterAreaForm_MouseDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mouseToolStripStatusLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label startPositionLabel;
        private System.Windows.Forms.Label dimensionsLabel;
        private System.Windows.Forms.Label startPositionValueLabel;
        private System.Windows.Forms.Label dimensionsValueLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}