namespace MouseController
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreasManagerForm));
            this.infoLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouseToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startPositionLabel = new System.Windows.Forms.Label();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.startPositionValueLabel = new System.Windows.Forms.Label();
            this.dimensionsValueLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.areasManagerPanel = new System.Windows.Forms.Panel();
            this.removeAreaPanel = new System.Windows.Forms.Panel();
            this.removeAreaLabel = new System.Windows.Forms.Label();
            this.addAreaPanel = new System.Windows.Forms.Panel();
            this.addAreaLabel = new System.Windows.Forms.Label();
            this.areasComboBoxPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.areasLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.areasManagerPanel.SuspendLayout();
            this.removeAreaPanel.SuspendLayout();
            this.addAreaPanel.SuspendLayout();
            this.areasComboBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(184, 210);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
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
            this.startPositionLabel.Location = new System.Drawing.Point(99, 295);
            this.startPositionLabel.Name = "startPositionLabel";
            this.startPositionLabel.Size = new System.Drawing.Size(75, 13);
            this.startPositionLabel.TabIndex = 2;
            this.startPositionLabel.Text = "Start Position: ";
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Location = new System.Drawing.Point(99, 319);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(67, 13);
            this.dimensionsLabel.TabIndex = 3;
            this.dimensionsLabel.Text = "Dimensions: ";
            // 
            // startPositionValueLabel
            // 
            this.startPositionValueLabel.AutoSize = true;
            this.startPositionValueLabel.Location = new System.Drawing.Point(180, 295);
            this.startPositionValueLabel.Name = "startPositionValueLabel";
            this.startPositionValueLabel.Size = new System.Drawing.Size(345, 13);
            this.startPositionValueLabel.TabIndex = 4;
            this.startPositionValueLabel.Text = "Go to start point and press S key. Then go to end point and press E key";
            // 
            // dimensionsValueLabel
            // 
            this.dimensionsValueLabel.AutoSize = true;
            this.dimensionsValueLabel.Location = new System.Drawing.Point(181, 319);
            this.dimensionsValueLabel.Name = "dimensionsValueLabel";
            this.dimensionsValueLabel.Size = new System.Drawing.Size(100, 13);
            this.dimensionsValueLabel.TabIndex = 5;
            this.dimensionsValueLabel.Text = "No bitmap captured";
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Enabled = false;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acceptButton.Location = new System.Drawing.Point(391, 361);
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
            this.cancelButton.Enabled = false;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(489, 361);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captureButton.Location = new System.Drawing.Point(102, 210);
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
            this.previewPictureBox.Location = new System.Drawing.Point(469, 210);
            this.previewPictureBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(43, 34);
            this.previewPictureBox.TabIndex = 10;
            this.previewPictureBox.TabStop = false;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePictureBox.Location = new System.Drawing.Point(544, 18);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(20, 20);
            this.closePictureBox.TabIndex = 11;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(99, 267);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(184, 264);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(267, 20);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.Text = "Type a name here...";
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // areasManagerPanel
            // 
            this.areasManagerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areasManagerPanel.Controls.Add(this.removeAreaPanel);
            this.areasManagerPanel.Controls.Add(this.addAreaPanel);
            this.areasManagerPanel.Controls.Add(this.areasComboBoxPanel);
            this.areasManagerPanel.Controls.Add(this.label1);
            this.areasManagerPanel.Controls.Add(this.areasLabel);
            this.areasManagerPanel.Controls.Add(this.nameTextBox);
            this.areasManagerPanel.Controls.Add(this.infoLabel);
            this.areasManagerPanel.Controls.Add(this.closePictureBox);
            this.areasManagerPanel.Controls.Add(this.startPositionLabel);
            this.areasManagerPanel.Controls.Add(this.previewPictureBox);
            this.areasManagerPanel.Controls.Add(this.dimensionsLabel);
            this.areasManagerPanel.Controls.Add(this.captureButton);
            this.areasManagerPanel.Controls.Add(this.nameLabel);
            this.areasManagerPanel.Controls.Add(this.cancelButton);
            this.areasManagerPanel.Controls.Add(this.startPositionValueLabel);
            this.areasManagerPanel.Controls.Add(this.acceptButton);
            this.areasManagerPanel.Controls.Add(this.dimensionsValueLabel);
            this.areasManagerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areasManagerPanel.Location = new System.Drawing.Point(0, 0);
            this.areasManagerPanel.Name = "areasManagerPanel";
            this.areasManagerPanel.Size = new System.Drawing.Size(584, 410);
            this.areasManagerPanel.TabIndex = 13;
            this.areasManagerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.areasManagerPanel_MouseDown);
            // 
            // removeAreaPanel
            // 
            this.removeAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeAreaPanel.Controls.Add(this.removeAreaLabel);
            this.removeAreaPanel.Location = new System.Drawing.Point(441, 74);
            this.removeAreaPanel.Name = "removeAreaPanel";
            this.removeAreaPanel.Size = new System.Drawing.Size(24, 24);
            this.removeAreaPanel.TabIndex = 18;
            // 
            // removeAreaLabel
            // 
            this.removeAreaLabel.AutoSize = true;
            this.removeAreaLabel.Font = new System.Drawing.Font("Gulim", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeAreaLabel.Location = new System.Drawing.Point(-2, -2);
            this.removeAreaLabel.Name = "removeAreaLabel";
            this.removeAreaLabel.Size = new System.Drawing.Size(28, 26);
            this.removeAreaLabel.TabIndex = 9;
            this.removeAreaLabel.Text = "-";
            // 
            // addAreaPanel
            // 
            this.addAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addAreaPanel.Controls.Add(this.addAreaLabel);
            this.addAreaPanel.Location = new System.Drawing.Point(405, 74);
            this.addAreaPanel.Name = "addAreaPanel";
            this.addAreaPanel.Size = new System.Drawing.Size(24, 24);
            this.addAreaPanel.TabIndex = 17;
            // 
            // addAreaLabel
            // 
            this.addAreaLabel.AutoSize = true;
            this.addAreaLabel.Font = new System.Drawing.Font("Gulim", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addAreaLabel.Location = new System.Drawing.Point(-2, -1);
            this.addAreaLabel.Name = "addAreaLabel";
            this.addAreaLabel.Size = new System.Drawing.Size(28, 26);
            this.addAreaLabel.TabIndex = 9;
            this.addAreaLabel.Text = "+";
            // 
            // areasComboBoxPanel
            // 
            this.areasComboBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areasComboBoxPanel.Controls.Add(this.comboBox1);
            this.areasComboBoxPanel.Location = new System.Drawing.Point(134, 74);
            this.areasComboBoxPanel.Name = "areasComboBoxPanel";
            this.areasComboBoxPanel.Size = new System.Drawing.Size(250, 24);
            this.areasComboBoxPanel.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "SAVED AREAS";
            // 
            // areasLabel
            // 
            this.areasLabel.AutoSize = true;
            this.areasLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.areasLabel.Location = new System.Drawing.Point(23, 18);
            this.areasLabel.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.areasLabel.Name = "areasLabel";
            this.areasLabel.Size = new System.Drawing.Size(238, 27);
            this.areasLabel.TabIndex = 13;
            this.areasLabel.Text = "AREAS MANAGER";
            // 
            // AreasManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 432);
            this.Controls.Add(this.areasManagerPanel);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreasManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Area";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterAreaForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.areasManagerPanel.ResumeLayout(false);
            this.areasManagerPanel.PerformLayout();
            this.removeAreaPanel.ResumeLayout(false);
            this.removeAreaPanel.PerformLayout();
            this.addAreaPanel.ResumeLayout(false);
            this.addAreaPanel.PerformLayout();
            this.areasComboBoxPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel areasManagerPanel;
        private System.Windows.Forms.Label areasLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel areasComboBoxPanel;
        private System.Windows.Forms.Panel addAreaPanel;
        private System.Windows.Forms.Label addAreaLabel;
        private System.Windows.Forms.Panel removeAreaPanel;
        private System.Windows.Forms.Label removeAreaLabel;
    }
}