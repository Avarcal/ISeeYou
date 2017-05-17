namespace ISeeYou
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.leftEyeButton = new System.Windows.Forms.Button();
            this.discardEyeButton = new System.Windows.Forms.Button();
            this.rightEyeButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.phaseOneButton = new System.Windows.Forms.Button();
            this.phaseTwoButton = new System.Windows.Forms.Button();
            this.phaseThreeButton = new System.Windows.Forms.Button();
            this.phaseFourButton = new System.Windows.Forms.Button();
            this.phaseFiveButton = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(160, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(694, 519);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(12, 12);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(142, 66);
            this.openFolderButton.TabIndex = 1;
            this.openFolderButton.Text = "Wybierz źródło";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // leftEyeButton
            // 
            this.leftEyeButton.Location = new System.Drawing.Point(160, 567);
            this.leftEyeButton.Name = "leftEyeButton";
            this.leftEyeButton.Size = new System.Drawing.Size(198, 66);
            this.leftEyeButton.TabIndex = 2;
            this.leftEyeButton.Text = "Lewe";
            this.leftEyeButton.UseVisualStyleBackColor = true;
            this.leftEyeButton.Click += new System.EventHandler(this.leftEyeButton_Click);
            // 
            // discardEyeButton
            // 
            this.discardEyeButton.Location = new System.Drawing.Point(414, 567);
            this.discardEyeButton.Name = "discardEyeButton";
            this.discardEyeButton.Size = new System.Drawing.Size(198, 66);
            this.discardEyeButton.TabIndex = 3;
            this.discardEyeButton.Text = "Odrzuć";
            this.discardEyeButton.UseVisualStyleBackColor = true;
            this.discardEyeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // rightEyeButton
            // 
            this.rightEyeButton.Location = new System.Drawing.Point(662, 567);
            this.rightEyeButton.Name = "rightEyeButton";
            this.rightEyeButton.Size = new System.Drawing.Size(198, 66);
            this.rightEyeButton.TabIndex = 4;
            this.rightEyeButton.Text = "Prawe";
            this.rightEyeButton.UseVisualStyleBackColor = true;
            this.rightEyeButton.Click += new System.EventHandler(this.rightEyeButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 229);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(142, 23);
            this.previousButton.TabIndex = 5;
            this.previousButton.Text = "Poprzedni";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(875, 229);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(142, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Następny";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // phaseOneButton
            // 
            this.phaseOneButton.Location = new System.Drawing.Point(160, 671);
            this.phaseOneButton.Name = "phaseOneButton";
            this.phaseOneButton.Size = new System.Drawing.Size(77, 52);
            this.phaseOneButton.TabIndex = 7;
            this.phaseOneButton.Text = "1";
            this.phaseOneButton.UseVisualStyleBackColor = true;
            this.phaseOneButton.Click += new System.EventHandler(this.phaseOneButton_Click);
            // 
            // phaseTwoButton
            // 
            this.phaseTwoButton.Location = new System.Drawing.Point(310, 671);
            this.phaseTwoButton.Name = "phaseTwoButton";
            this.phaseTwoButton.Size = new System.Drawing.Size(77, 52);
            this.phaseTwoButton.TabIndex = 8;
            this.phaseTwoButton.Text = "2";
            this.phaseTwoButton.UseVisualStyleBackColor = true;
            this.phaseTwoButton.Click += new System.EventHandler(this.phaseTwoButton_Click);
            // 
            // phaseThreeButton
            // 
            this.phaseThreeButton.Location = new System.Drawing.Point(462, 671);
            this.phaseThreeButton.Name = "phaseThreeButton";
            this.phaseThreeButton.Size = new System.Drawing.Size(77, 52);
            this.phaseThreeButton.TabIndex = 9;
            this.phaseThreeButton.Text = "3";
            this.phaseThreeButton.UseVisualStyleBackColor = true;
            this.phaseThreeButton.Click += new System.EventHandler(this.phaseThreeButton_Click);
            // 
            // phaseFourButton
            // 
            this.phaseFourButton.Location = new System.Drawing.Point(626, 671);
            this.phaseFourButton.Name = "phaseFourButton";
            this.phaseFourButton.Size = new System.Drawing.Size(77, 52);
            this.phaseFourButton.TabIndex = 10;
            this.phaseFourButton.Text = "4";
            this.phaseFourButton.UseVisualStyleBackColor = true;
            this.phaseFourButton.Click += new System.EventHandler(this.phaseFourButton_Click);
            // 
            // phaseFiveButton
            // 
            this.phaseFiveButton.Location = new System.Drawing.Point(783, 671);
            this.phaseFiveButton.Name = "phaseFiveButton";
            this.phaseFiveButton.Size = new System.Drawing.Size(77, 52);
            this.phaseFiveButton.TabIndex = 11;
            this.phaseFiveButton.Text = "5";
            this.phaseFiveButton.UseVisualStyleBackColor = true;
            this.phaseFiveButton.Click += new System.EventHandler(this.phaseFiveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 735);
            this.Controls.Add(this.phaseFiveButton);
            this.Controls.Add(this.phaseFourButton);
            this.Controls.Add(this.phaseThreeButton);
            this.Controls.Add(this.phaseTwoButton);
            this.Controls.Add(this.phaseOneButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.rightEyeButton);
            this.Controls.Add(this.discardEyeButton);
            this.Controls.Add(this.leftEyeButton);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.Button leftEyeButton;
        private System.Windows.Forms.Button discardEyeButton;
        private System.Windows.Forms.Button rightEyeButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button phaseOneButton;
        private System.Windows.Forms.Button phaseTwoButton;
        private System.Windows.Forms.Button phaseThreeButton;
        private System.Windows.Forms.Button phaseFourButton;
        private System.Windows.Forms.Button phaseFiveButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}

