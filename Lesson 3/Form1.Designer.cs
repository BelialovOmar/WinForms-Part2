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
            this.statusStripPractire = new System.Windows.Forms.LinkLabel();
            this.hwWallpaper = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // statusStripPractire
            // 
            this.statusStripPractire.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.statusStripPractire.AutoSize = true;
            this.statusStripPractire.Location = new System.Drawing.Point(12, 9);
            this.statusStripPractire.Name = "statusStripPractire";
            this.statusStripPractire.Size = new System.Drawing.Size(158, 20);
            this.statusStripPractire.TabIndex = 0;
            this.statusStripPractire.TabStop = true;
            this.statusStripPractire.Text = "Practice1 - Status Strip";
            this.statusStripPractire.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.statusStripPractire_LinkClicked);
            // 
            // hwWallpaper
            // 
            this.hwWallpaper.AutoSize = true;
            this.hwWallpaper.Location = new System.Drawing.Point(12, 29);
            this.hwWallpaper.Name = "hwWallpaper";
            this.hwWallpaper.Size = new System.Drawing.Size(116, 20);
            this.hwWallpaper.TabIndex = 1;
            this.hwWallpaper.TabStop = true;
            this.hwWallpaper.Text = "HW - Wallpaper";
            this.hwWallpaper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hwWallpaper_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hwWallpaper);
            this.Controls.Add(this.statusStripPractire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel statusStripPractire;
        private LinkLabel hwWallpaper;
    }
}