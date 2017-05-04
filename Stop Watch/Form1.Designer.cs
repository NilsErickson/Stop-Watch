namespace Stop_Watch
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
            this.components = new System.ComponentModel.Container();
            this.minLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.secLabel = new System.Windows.Forms.Label();
            this.CsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Century", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.Red;
            this.minLabel.Location = new System.Drawing.Point(28, 15);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(158, 116);
            this.minLabel.TabIndex = 0;
            this.minLabel.Text = "00";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(209, 165);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(364, 165);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLabel.ForeColor = System.Drawing.Color.Red;
            this.secLabel.Location = new System.Drawing.Point(191, 22);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(151, 108);
            this.secLabel.TabIndex = 4;
            this.secLabel.Text = "00";
            // 
            // CsLabel
            // 
            this.CsLabel.AutoSize = true;
            this.CsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsLabel.ForeColor = System.Drawing.Color.Red;
            this.CsLabel.Location = new System.Drawing.Point(346, 23);
            this.CsLabel.Name = "CsLabel";
            this.CsLabel.Size = new System.Drawing.Size(153, 108);
            this.CsLabel.TabIndex = 5;
            this.CsLabel.Text = "00";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(66, 165);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 226);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.CsLabel);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.minLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stop Watch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label CsLabel;
        private System.Windows.Forms.Button startButton;
    }
}

