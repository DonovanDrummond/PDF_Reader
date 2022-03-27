namespace PDFTextToSpeech
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
            this.BtnInputPdf = new System.Windows.Forms.Button();
            this.BtnStartNewReader = new System.Windows.Forms.Button();
            this.TxtBxFilePathOutput = new System.Windows.Forms.TextBox();
            this.LblFileDirectoryOutput = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CmbBxVoiceSelectionInput = new System.Windows.Forms.ComboBox();
            this.LblVoiceSelectionOutput = new System.Windows.Forms.Label();
            this.LblSpeechRateOutput = new System.Windows.Forms.Label();
            this.RTxtBxPdfTxtOutput = new System.Windows.Forms.RichTextBox();
            this.BtnResumeAndPaused = new System.Windows.Forms.Button();
            this.trcBarSpeechRate = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trcBarSpeechRate)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInputPdf
            // 
            this.BtnInputPdf.Location = new System.Drawing.Point(446, 391);
            this.BtnInputPdf.Name = "BtnInputPdf";
            this.BtnInputPdf.Size = new System.Drawing.Size(114, 47);
            this.BtnInputPdf.TabIndex = 1;
            this.BtnInputPdf.Text = "Look for Pdf";
            this.BtnInputPdf.UseVisualStyleBackColor = true;
            this.BtnInputPdf.Click += new System.EventHandler(this.BtnInputPdf_Click);
            // 
            // BtnStartNewReader
            // 
            this.BtnStartNewReader.Enabled = false;
            this.BtnStartNewReader.Location = new System.Drawing.Point(566, 391);
            this.BtnStartNewReader.Name = "BtnStartNewReader";
            this.BtnStartNewReader.Size = new System.Drawing.Size(114, 47);
            this.BtnStartNewReader.TabIndex = 2;
            this.BtnStartNewReader.UseVisualStyleBackColor = true;
            this.BtnStartNewReader.Click += new System.EventHandler(this.BtnStartNewReader_Click);
            // 
            // TxtBxFilePathOutput
            // 
            this.TxtBxFilePathOutput.Enabled = false;
            this.TxtBxFilePathOutput.Location = new System.Drawing.Point(479, 35);
            this.TxtBxFilePathOutput.Name = "TxtBxFilePathOutput";
            this.TxtBxFilePathOutput.Size = new System.Drawing.Size(296, 20);
            this.TxtBxFilePathOutput.TabIndex = 3;
            this.TxtBxFilePathOutput.Click += new System.EventHandler(this.TxtBxFilePathOutput_Click);
            // 
            // LblFileDirectoryOutput
            // 
            this.LblFileDirectoryOutput.AutoSize = true;
            this.LblFileDirectoryOutput.Location = new System.Drawing.Point(479, 12);
            this.LblFileDirectoryOutput.Name = "LblFileDirectoryOutput";
            this.LblFileDirectoryOutput.Size = new System.Drawing.Size(68, 13);
            this.LblFileDirectoryOutput.TabIndex = 4;
            this.LblFileDirectoryOutput.Text = "File Directory";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CmbBxVoiceSelectionInput
            // 
            this.CmbBxVoiceSelectionInput.FormattingEnabled = true;
            this.CmbBxVoiceSelectionInput.Location = new System.Drawing.Point(479, 96);
            this.CmbBxVoiceSelectionInput.Name = "CmbBxVoiceSelectionInput";
            this.CmbBxVoiceSelectionInput.Size = new System.Drawing.Size(290, 21);
            this.CmbBxVoiceSelectionInput.TabIndex = 5;
            // 
            // LblVoiceSelectionOutput
            // 
            this.LblVoiceSelectionOutput.AutoSize = true;
            this.LblVoiceSelectionOutput.Location = new System.Drawing.Point(479, 80);
            this.LblVoiceSelectionOutput.Name = "LblVoiceSelectionOutput";
            this.LblVoiceSelectionOutput.Size = new System.Drawing.Size(81, 13);
            this.LblVoiceSelectionOutput.TabIndex = 6;
            this.LblVoiceSelectionOutput.Text = "Voice Selection";
            // 
            // LblSpeechRateOutput
            // 
            this.LblSpeechRateOutput.AutoSize = true;
            this.LblSpeechRateOutput.Location = new System.Drawing.Point(479, 142);
            this.LblSpeechRateOutput.Name = "LblSpeechRateOutput";
            this.LblSpeechRateOutput.Size = new System.Drawing.Size(70, 13);
            this.LblSpeechRateOutput.TabIndex = 8;
            this.LblSpeechRateOutput.Text = "Speech Rate";
            // 
            // RTxtBxPdfTxtOutput
            // 
            this.RTxtBxPdfTxtOutput.Location = new System.Drawing.Point(14, 12);
            this.RTxtBxPdfTxtOutput.Name = "RTxtBxPdfTxtOutput";
            this.RTxtBxPdfTxtOutput.Size = new System.Drawing.Size(427, 419);
            this.RTxtBxPdfTxtOutput.TabIndex = 9;
            this.RTxtBxPdfTxtOutput.Text = "";
            // 
            // BtnResumeAndPaused
            // 
            this.BtnResumeAndPaused.Enabled = false;
            this.BtnResumeAndPaused.Location = new System.Drawing.Point(686, 391);
            this.BtnResumeAndPaused.Name = "BtnResumeAndPaused";
            this.BtnResumeAndPaused.Size = new System.Drawing.Size(114, 47);
            this.BtnResumeAndPaused.TabIndex = 10;
            this.BtnResumeAndPaused.UseVisualStyleBackColor = true;
            this.BtnResumeAndPaused.Click += new System.EventHandler(this.BtnResumeAndPaused_Click);
            // 
            // trcBarSpeechRate
            // 
            this.trcBarSpeechRate.LargeChange = 2;
            this.trcBarSpeechRate.Location = new System.Drawing.Point(452, 158);
            this.trcBarSpeechRate.Minimum = -10;
            this.trcBarSpeechRate.Name = "trcBarSpeechRate";
            this.trcBarSpeechRate.Size = new System.Drawing.Size(348, 45);
            this.trcBarSpeechRate.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.trcBarSpeechRate);
            this.Controls.Add(this.BtnResumeAndPaused);
            this.Controls.Add(this.RTxtBxPdfTxtOutput);
            this.Controls.Add(this.LblSpeechRateOutput);
            this.Controls.Add(this.LblVoiceSelectionOutput);
            this.Controls.Add(this.CmbBxVoiceSelectionInput);
            this.Controls.Add(this.LblFileDirectoryOutput);
            this.Controls.Add(this.TxtBxFilePathOutput);
            this.Controls.Add(this.BtnStartNewReader);
            this.Controls.Add(this.BtnInputPdf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trcBarSpeechRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnInputPdf;
        private System.Windows.Forms.Button BtnStartNewReader;
        private System.Windows.Forms.TextBox TxtBxFilePathOutput;
        private System.Windows.Forms.Label LblFileDirectoryOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CmbBxVoiceSelectionInput;
        private System.Windows.Forms.Label LblVoiceSelectionOutput;
        private System.Windows.Forms.Label LblSpeechRateOutput;
        private System.Windows.Forms.RichTextBox RTxtBxPdfTxtOutput;
        private System.Windows.Forms.Button BtnResumeAndPaused;
        private System.Windows.Forms.TrackBar trcBarSpeechRate;
    }
}

