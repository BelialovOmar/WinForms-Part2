namespace Lesson_5
{
    partial class TimeInfo
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox_Time = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox_Time
            // 
            this.listBox_Time.FormattingEnabled = true;
            this.listBox_Time.ItemHeight = 20;
            this.listBox_Time.Location = new System.Drawing.Point(12, 12);
            this.listBox_Time.Name = "listBox_Time";
            this.listBox_Time.Size = new System.Drawing.Size(480, 304);
            this.listBox_Time.TabIndex = 0;
            // 
            // TimeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 324);
            this.Controls.Add(this.listBox_Time);
            this.Name = "TimeInfo";
            this.Text = "TimeInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ListBox listBox_Time;
    }
}