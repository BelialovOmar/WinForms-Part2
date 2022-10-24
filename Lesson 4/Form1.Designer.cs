namespace Lesson_4
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
            this.linkLabel1_ParentChildPractice = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1_ParentChildPractice
            // 
            this.linkLabel1_ParentChildPractice.AutoSize = true;
            this.linkLabel1_ParentChildPractice.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1_ParentChildPractice.Name = "linkLabel1_ParentChildPractice";
            this.linkLabel1_ParentChildPractice.Size = new System.Drawing.Size(136, 20);
            this.linkLabel1_ParentChildPractice.TabIndex = 0;
            this.linkLabel1_ParentChildPractice.TabStop = true;
            this.linkLabel1_ParentChildPractice.Text = "ParentChildPractice";
            this.linkLabel1_ParentChildPractice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_ParentChildPractice_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1_ParentChildPractice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel1_ParentChildPractice;
    }
}