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
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouseToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startPositionLabel = new System.Windows.Forms.Label();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.startPositionValueLabel = new System.Windows.Forms.Label();
            this.dimensionsValueLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.areaPictureBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upewnij się, ze poszukiwany element jest widoczny i zaznacz obszar na ekranie";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(561, 22);
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
            this.startPositionLabel.Location = new System.Drawing.Point(22, 66);
            this.startPositionLabel.Name = "startPositionLabel";
            this.startPositionLabel.Size = new System.Drawing.Size(75, 13);
            this.startPositionLabel.TabIndex = 2;
            this.startPositionLabel.Text = "Start Position: ";
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Location = new System.Drawing.Point(22, 90);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(67, 13);
            this.dimensionsLabel.TabIndex = 3;
            this.dimensionsLabel.Text = "Dimensions: ";
            // 
            // startPositionValueLabel
            // 
            this.startPositionValueLabel.AutoSize = true;
            this.startPositionValueLabel.Location = new System.Drawing.Point(107, 66);
            this.startPositionValueLabel.Name = "startPositionValueLabel";
            this.startPositionValueLabel.Size = new System.Drawing.Size(348, 13);
            this.startPositionValueLabel.TabIndex = 4;
            this.startPositionValueLabel.Text = " Go to start point and press S key. Then go to end point and press E key";
            // 
            // dimensionsValueLabel
            // 
            this.dimensionsValueLabel.AutoSize = true;
            this.dimensionsValueLabel.Location = new System.Drawing.Point(104, 90);
            this.dimensionsValueLabel.Name = "dimensionsValueLabel";
            this.dimensionsValueLabel.Size = new System.Drawing.Size(0, 13);
            this.dimensionsValueLabel.TabIndex = 5;
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(169, 280);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // areaPictureBox
            // 
            this.areaPictureBox.Location = new System.Drawing.Point(15, 136);
            this.areaPictureBox.Name = "areaPictureBox";
            this.areaPictureBox.Size = new System.Drawing.Size(532, 122);
            this.areaPictureBox.TabIndex = 7;
            this.areaPictureBox.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(284, 280);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // RegisterAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 345);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.areaPictureBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.dimensionsValueLabel);
            this.Controls.Add(this.startPositionValueLabel);
            this.Controls.Add(this.dimensionsLabel);
            this.Controls.Add(this.startPositionLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Name = "RegisterAreaForm";
            this.Text = "RegisterAreaForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterAreaForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mouseToolStripStatusLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label startPositionLabel;
        private System.Windows.Forms.Label dimensionsLabel;
        private System.Windows.Forms.Label startPositionValueLabel;
        private System.Windows.Forms.Label dimensionsValueLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.PictureBox areaPictureBox;
        private System.Windows.Forms.Button resetButton;
    }
}