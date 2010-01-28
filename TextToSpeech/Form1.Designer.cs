namespace TextToSpeech
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
            this.VoiceComboBox = new System.Windows.Forms.ComboBox();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.PauseResumeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TextLabel = new System.Windows.Forms.Label();
            this.VoiceLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VoiceComboBox
            // 
            this.VoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoiceComboBox.FormattingEnabled = true;
            this.VoiceComboBox.Location = new System.Drawing.Point(75, 12);
            this.VoiceComboBox.Name = "VoiceComboBox";
            this.VoiceComboBox.Size = new System.Drawing.Size(195, 24);
            this.VoiceComboBox.TabIndex = 0;
            this.VoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.VoiceComboBox_SelectedIndexChanged);
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Location = new System.Drawing.Point(75, 42);
            this.SpeedTrackBar.Minimum = -10;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(195, 56);
            this.SpeedTrackBar.TabIndex = 1;
            this.SpeedTrackBar.ValueChanged += new System.EventHandler(this.SpeedTrackBar_ValueChanged);
            // 
            // TextTextBox
            // 
            this.TextTextBox.Location = new System.Drawing.Point(12, 92);
            this.TextTextBox.Multiline = true;
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextTextBox.Size = new System.Drawing.Size(258, 120);
            this.TextTextBox.TabIndex = 2;
            this.TextTextBox.Text = "Hello World. I am speaking from text.";
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(12, 222);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 3;
            this.StartStopButton.Text = "&Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // PauseResumeButton
            // 
            this.PauseResumeButton.Enabled = false;
            this.PauseResumeButton.Location = new System.Drawing.Point(93, 222);
            this.PauseResumeButton.Name = "PauseResumeButton";
            this.PauseResumeButton.Size = new System.Drawing.Size(75, 23);
            this.PauseResumeButton.TabIndex = 4;
            this.PauseResumeButton.Text = "&Pause";
            this.PauseResumeButton.UseVisualStyleBackColor = true;
            this.PauseResumeButton.Click += new System.EventHandler(this.PauseResumeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(195, 222);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(12, 72);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(35, 17);
            this.TextLabel.TabIndex = 6;
            this.TextLabel.Text = "Text";
            // 
            // VoiceLabel
            // 
            this.VoiceLabel.AutoSize = true;
            this.VoiceLabel.Location = new System.Drawing.Point(9, 12);
            this.VoiceLabel.Name = "VoiceLabel";
            this.VoiceLabel.Size = new System.Drawing.Size(43, 17);
            this.VoiceLabel.TabIndex = 7;
            this.VoiceLabel.Text = "Voice";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(9, 42);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(49, 17);
            this.SpeedLabel.TabIndex = 8;
            this.SpeedLabel.Text = "Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 257);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.VoiceLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PauseResumeButton);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.TextTextBox);
            this.Controls.Add(this.SpeedTrackBar);
            this.Controls.Add(this.VoiceComboBox);
            this.Name = "Form1";
            this.Text = "Say It!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VoiceComboBox;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.TextBox TextTextBox;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Button PauseResumeButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label VoiceLabel;
        private System.Windows.Forms.Label SpeedLabel;
    }
}

