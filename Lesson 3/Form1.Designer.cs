namespace Lesson_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip_practice = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // statusStrip_practice
            // 
            this.statusStrip_practice.AutoSize = true;
            this.statusStrip_practice.Location = new System.Drawing.Point(12, 9);
            this.statusStrip_practice.Name = "statusStrip_practice";
            this.statusStrip_practice.Size = new System.Drawing.Size(158, 20);
            this.statusStrip_practice.TabIndex = 0;
            this.statusStrip_practice.TabStop = true;
            this.statusStrip_practice.Text = "Practice1 - Status Strip";
            this.statusStrip_practice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.statusStrip_practice_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip_practice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel statusStrip_practice;
    }
}