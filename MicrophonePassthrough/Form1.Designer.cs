namespace MicrophonePassthrough
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
            this.passthroughToggleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passthroughToggleButton
            // 
            this.passthroughToggleButton.Location = new System.Drawing.Point(12, 12);
            this.passthroughToggleButton.Name = "passthroughToggleButton";
            this.passthroughToggleButton.Size = new System.Drawing.Size(260, 85);
            this.passthroughToggleButton.TabIndex = 0;
            this.passthroughToggleButton.Text = "Start Passthrough";
            this.passthroughToggleButton.UseVisualStyleBackColor = true;
            this.passthroughToggleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.passthroughToggleButton);
            this.Name = "Form1";
            this.Text = "Microphone Passthrough";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button passthroughToggleButton;
    }
}

