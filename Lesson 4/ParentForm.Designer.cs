namespace Lesson_4
{
    partial class ParentForm
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
            this.textBox_Demo1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Demo1
            // 
            this.textBox_Demo1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Demo1.Location = new System.Drawing.Point(12, 12);
            this.textBox_Demo1.Multiline = true;
            this.textBox_Demo1.Name = "textBox_Demo1";
            this.textBox_Demo1.Size = new System.Drawing.Size(445, 368);
            this.textBox_Demo1.TabIndex = 0;
             // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 392);
            this.Controls.Add(this.textBox_Demo1);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
             this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Demo1;
    }
}