namespace EnhancedPainter
{
    partial class PainterForm
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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.largeSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.smallSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.colorGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.blackRadioButton);
            this.colorGroupBox.Controls.Add(this.greenRadioButton);
            this.colorGroupBox.Controls.Add(this.BlueRadioButton);
            this.colorGroupBox.Controls.Add(this.redRadioButton);
            this.colorGroupBox.Location = new System.Drawing.Point(12, 22);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(200, 115);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(32, 92);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(32, 68);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Location = new System.Drawing.Point(32, 44);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.BlueRadioButton.TabIndex = 1;
            this.BlueRadioButton.TabStop = true;
            this.BlueRadioButton.Text = "Blue";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(32, 20);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 0;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.Controls.Add(this.largeSizeRadioButton);
            this.SizeGroupBox.Controls.Add(this.mediumSizeRadioButton);
            this.SizeGroupBox.Controls.Add(this.smallSizeRadioButton);
            this.SizeGroupBox.Location = new System.Drawing.Point(12, 158);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(200, 91);
            this.SizeGroupBox.TabIndex = 1;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "Size";
            this.SizeGroupBox.Enter += new System.EventHandler(this.SizeGroupBox_Enter);
            // 
            // largeSizeRadioButton
            // 
            this.largeSizeRadioButton.AutoSize = true;
            this.largeSizeRadioButton.Location = new System.Drawing.Point(32, 65);
            this.largeSizeRadioButton.Name = "largeSizeRadioButton";
            this.largeSizeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.largeSizeRadioButton.TabIndex = 2;
            this.largeSizeRadioButton.TabStop = true;
            this.largeSizeRadioButton.Text = "Large";
            this.largeSizeRadioButton.UseVisualStyleBackColor = true;
            this.largeSizeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // mediumSizeRadioButton
            // 
            this.mediumSizeRadioButton.AutoSize = true;
            this.mediumSizeRadioButton.Location = new System.Drawing.Point(32, 42);
            this.mediumSizeRadioButton.Name = "mediumSizeRadioButton";
            this.mediumSizeRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumSizeRadioButton.TabIndex = 1;
            this.mediumSizeRadioButton.TabStop = true;
            this.mediumSizeRadioButton.Text = "Medium";
            this.mediumSizeRadioButton.UseVisualStyleBackColor = true;
            this.mediumSizeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // smallSizeRadioButton
            // 
            this.smallSizeRadioButton.AutoSize = true;
            this.smallSizeRadioButton.Location = new System.Drawing.Point(32, 19);
            this.smallSizeRadioButton.Name = "smallSizeRadioButton";
            this.smallSizeRadioButton.Size = new System.Drawing.Size(50, 17);
            this.smallSizeRadioButton.TabIndex = 0;
            this.smallSizeRadioButton.TabStop = true;
            this.smallSizeRadioButton.Text = "Small";
            this.smallSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // drawingPanel
            // 
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(240, 22);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(375, 275);
            this.drawingPanel.TabIndex = 2;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 309);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.SizeGroupBox);
            this.Controls.Add(this.colorGroupBox);
            this.Name = "PainterForm";
            this.Text = "Form1";
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.GroupBox SizeGroupBox;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton BlueRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton largeSizeRadioButton;
        private System.Windows.Forms.RadioButton mediumSizeRadioButton;
        private System.Windows.Forms.RadioButton smallSizeRadioButton;
        private System.Windows.Forms.Panel drawingPanel;
    }
}

