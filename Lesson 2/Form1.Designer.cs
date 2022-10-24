namespace Lesson_2
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
            this.movingTheWindow = new System.Windows.Forms.LinkLabel();
            this.timerPractice = new System.Windows.Forms.LinkLabel();
            this.buttonsArray = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // movingTheWindow
            // 
            this.movingTheWindow.AutoSize = true;
            this.movingTheWindow.Location = new System.Drawing.Point(12, 9);
            this.movingTheWindow.Name = "movingTheWindow";
            this.movingTheWindow.Size = new System.Drawing.Size(214, 20);
            this.movingTheWindow.TabIndex = 0;
            this.movingTheWindow.TabStop = true;
            this.movingTheWindow.Text = "Practice1 - Moving the window";
            this.movingTheWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.movingTheWindow_LinkClicked);
            // 
            // timerPractice
            // 
            this.timerPractice.AutoSize = true;
            this.timerPractice.Location = new System.Drawing.Point(12, 29);
            this.timerPractice.Name = "timerPractice";
            this.timerPractice.Size = new System.Drawing.Size(175, 20);
            this.timerPractice.TabIndex = 1;
            this.timerPractice.TabStop = true;
            this.timerPractice.Text = "Practice2 - Timer in Tittle";
            this.timerPractice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.timerPractice_LinkClicked);
            // 
            // buttonsArray
            // 
            this.buttonsArray.AutoSize = true;
            this.buttonsArray.Location = new System.Drawing.Point(12, 49);
            this.buttonsArray.Name = "buttonsArray";
            this.buttonsArray.Size = new System.Drawing.Size(190, 20);
            this.buttonsArray.TabIndex = 2;
            this.buttonsArray.TabStop = true;
            this.buttonsArray.Text = "Practice3 - Array of Buttons";
            this.buttonsArray.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.buttonsArray_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsArray);
            this.Controls.Add(this.timerPractice);
            this.Controls.Add(this.movingTheWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel movingTheWindow;
        private LinkLabel timerPractice;
        private LinkLabel buttonsArray;
    }
}