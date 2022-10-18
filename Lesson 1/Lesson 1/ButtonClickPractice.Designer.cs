namespace Lesson_1
{
    partial class ButtonClickPractice
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
            this.btnClickCounter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickCounter
            // 
            this.btnClickCounter.Location = new System.Drawing.Point(12, 12);
            this.btnClickCounter.Name = "btnClickCounter";
            this.btnClickCounter.Size = new System.Drawing.Size(322, 223);
            this.btnClickCounter.TabIndex = 0;
            this.btnClickCounter.Text = "Press Me!";
            this.btnClickCounter.UseVisualStyleBackColor = true;
            this.btnClickCounter.Click += new System.EventHandler(this.btnClickCounter_Click);
            // 
            // ButtonClickPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 247);
            this.Controls.Add(this.btnClickCounter);
            this.Name = "ButtonClickPractice";
            this.Text = "ButtonClickPractice";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClickCounter;
    }
}