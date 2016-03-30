namespace GetPixelColor
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
            this.MouseTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblPixelColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MouseTimer
            // 
            this.MouseTimer.Interval = 1;
            this.MouseTimer.Tick += new System.EventHandler(this.OnMouseTimerTick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Begin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPixelColor
            // 
            this.lblPixelColor.AutoSize = true;
            this.lblPixelColor.Location = new System.Drawing.Point(98, 197);
            this.lblPixelColor.Name = "lblPixelColor";
            this.lblPixelColor.Size = new System.Drawing.Size(0, 17);
            this.lblPixelColor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lblPixelColor);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MouseTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPixelColor;
    }
}

