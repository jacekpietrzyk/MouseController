namespace MouseController
{
    partial class AddAreaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAreaForm));
            this.areasLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startPositionLabel = new System.Windows.Forms.Label();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.captureButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.startPositionValueLabel = new System.Windows.Forms.Label();
            this.dimensionsValueLabel = new System.Windows.Forms.Label();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.addAreaPanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mouseToolStripStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.addAreaPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.previewPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // areasLabel
            // 
            this.areasLabel.AutoSize = true;
            this.areasLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.areasLabel.Location = new System.Drawing.Point(20, 20);
            this.areasLabel.Margin = new System.Windows.Forms.Padding(10);
            this.areasLabel.Name = "areasLabel";
            this.areasLabel.Size = new System.Drawing.Size(145, 27);
            this.areasLabel.TabIndex = 15;
            this.areasLabel.Text = "ADD AREA";
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Enabled = false;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acceptButton.Location = new System.Drawing.Point(547, 198);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 16;
            this.acceptButton.Text = "ACCEPT";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(648, 198);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(10, 10, 20, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(5, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(289, 16);
            this.nameTextBox.TabIndex = 26;
            this.nameTextBox.Text = "Type a name here...";
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // startPositionLabel
            // 
            this.startPositionLabel.AutoSize = true;
            this.startPositionLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPositionLabel.Location = new System.Drawing.Point(28, 113);
            this.startPositionLabel.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.startPositionLabel.Name = "startPositionLabel";
            this.startPositionLabel.Size = new System.Drawing.Size(134, 14);
            this.startPositionLabel.TabIndex = 19;
            this.startPositionLabel.Text = "START POSITION: ";
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dimensionsLabel.Location = new System.Drawing.Point(28, 145);
            this.dimensionsLabel.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(99, 14);
            this.dimensionsLabel.TabIndex = 20;
            this.dimensionsLabel.Text = "DIMENSIONS:";
            // 
            // captureButton
            // 
            this.captureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captureButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.captureButton.Location = new System.Drawing.Point(28, 67);
            this.captureButton.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(130, 26);
            this.captureButton.TabIndex = 24;
            this.captureButton.Text = "CAPTURE AREA";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(264, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 14);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "NAME:";
            // 
            // startPositionValueLabel
            // 
            this.startPositionValueLabel.AutoSize = true;
            this.startPositionValueLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPositionValueLabel.Location = new System.Drawing.Point(173, 111);
            this.startPositionValueLabel.Name = "startPositionValueLabel";
            this.startPositionValueLabel.Size = new System.Drawing.Size(540, 14);
            this.startPositionValueLabel.TabIndex = 22;
            this.startPositionValueLabel.Text = "Go to start point and press HOME key. Then go to end point and press END key";
            // 
            // dimensionsValueLabel
            // 
            this.dimensionsValueLabel.AutoSize = true;
            this.dimensionsValueLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dimensionsValueLabel.Location = new System.Drawing.Point(140, 145);
            this.dimensionsValueLabel.Name = "dimensionsValueLabel";
            this.dimensionsValueLabel.Size = new System.Drawing.Size(133, 14);
            this.dimensionsValueLabel.TabIndex = 23;
            this.dimensionsValueLabel.Text = "No bitmap captured";
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePictureBox.Location = new System.Drawing.Point(711, 20);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(10, 20, 20, 10);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(20, 20);
            this.closePictureBox.TabIndex = 28;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            this.closePictureBox.MouseEnter += new System.EventHandler(this.closePictureBox_MouseEnter);
            this.closePictureBox.MouseLeave += new System.EventHandler(this.closePictureBox_MouseLeave);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BackColor = System.Drawing.Color.Firebrick;
            this.previewPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewPictureBox.BackgroundImage")));
            this.previewPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previewPictureBox.Location = new System.Drawing.Point(-2, -5);
            this.previewPictureBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(45, 35);
            this.previewPictureBox.TabIndex = 27;
            this.previewPictureBox.TabStop = false;
            // 
            // addAreaPanel
            // 
            this.addAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addAreaPanel.Controls.Add(this.cancelButton);
            this.addAreaPanel.Controls.Add(this.resetButton);
            this.addAreaPanel.Controls.Add(this.acceptButton);
            this.addAreaPanel.Controls.Add(this.toolStrip1);
            this.addAreaPanel.Controls.Add(this.previewPanel);
            this.addAreaPanel.Controls.Add(this.panel2);
            this.addAreaPanel.Controls.Add(this.closePictureBox);
            this.addAreaPanel.Controls.Add(this.startPositionLabel);
            this.addAreaPanel.Controls.Add(this.dimensionsLabel);
            this.addAreaPanel.Controls.Add(this.startPositionValueLabel);
            this.addAreaPanel.Controls.Add(this.dimensionsValueLabel);
            this.addAreaPanel.Controls.Add(this.captureButton);
            this.addAreaPanel.Controls.Add(this.areasLabel);
            this.addAreaPanel.Controls.Add(this.nameLabel);
            this.addAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAreaPanel.Location = new System.Drawing.Point(0, 0);
            this.addAreaPanel.Name = "addAreaPanel";
            this.addAreaPanel.Size = new System.Drawing.Size(753, 243);
            this.addAreaPanel.TabIndex = 29;
            this.addAreaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addAreaPanel_MouseDown);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Enabled = false;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetButton.Location = new System.Drawing.Point(442, 198);
            this.resetButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 20);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseToolStripStatusLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 217);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(751, 25);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mouseToolStripStatusLabel
            // 
            this.mouseToolStripStatusLabel.Font = new System.Drawing.Font("Gulim", 9F);
            this.mouseToolStripStatusLabel.Name = "mouseToolStripStatusLabel";
            this.mouseToolStripStatusLabel.Size = new System.Drawing.Size(141, 22);
            this.mouseToolStripStatusLabel.Text = "Mouse Position: X: , Y: ";
            // 
            // previewPanel
            // 
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPanel.Controls.Add(this.previewPictureBox);
            this.previewPanel.Location = new System.Drawing.Point(157, 67);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(42, 26);
            this.previewPanel.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Location = new System.Drawing.Point(330, 67);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(301, 26);
            this.panel2.TabIndex = 29;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AddAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 243);
            this.Controls.Add(this.addAreaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAreaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAreaForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddAreaForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.addAreaPanel.ResumeLayout(false);
            this.addAreaPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.previewPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label areasLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label startPositionLabel;
        private System.Windows.Forms.Label dimensionsLabel;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label startPositionValueLabel;
        private System.Windows.Forms.Label dimensionsValueLabel;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Panel addAreaPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel mouseToolStripStatusLabel;
    }
}