namespace Lesson_5
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
            this.linkLabel_practirRichTextBox = new System.Windows.Forms.LinkLabel();
            this.linkLabel1_screen = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel_practirRichTextBox
            // 
            this.linkLabel_practirRichTextBox.AutoSize = true;
            this.linkLabel_practirRichTextBox.Location = new System.Drawing.Point(12, 9);
            this.linkLabel_practirRichTextBox.Name = "linkLabel_practirRichTextBox";
            this.linkLabel_practirRichTextBox.Size = new System.Drawing.Size(85, 20);
            this.linkLabel_practirRichTextBox.TabIndex = 0;
            this.linkLabel_practirRichTextBox.TabStop = true;
            this.linkLabel_practirRichTextBox.Text = "richTextBox";
            this.linkLabel_practirRichTextBox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_practirRichTextBox_LinkClicked);
            // 
            // linkLabel1_screen
            // 
            this.linkLabel1_screen.AutoSize = true;
            this.linkLabel1_screen.Location = new System.Drawing.Point(12, 29);
            this.linkLabel1_screen.Name = "linkLabel1_screen";
            this.linkLabel1_screen.Size = new System.Drawing.Size(81, 20);
            this.linkLabel1_screen.TabIndex = 1;
            this.linkLabel1_screen.TabStop = true;
            this.linkLabel1_screen.Text = "Screenshot";
            this.linkLabel1_screen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_screen_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 49);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change WallPaper";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 69);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(42, 20);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Time";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel1_screen);
            this.Controls.Add(this.linkLabel_practirRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel_practirRichTextBox;
        private LinkLabel linkLabel1_screen;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}