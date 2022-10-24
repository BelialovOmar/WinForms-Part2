namespace Lesson_3
{
    partial class Status_Strip_practice
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1_Demo = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 136);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(308, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 20);
            this.toolStripStatusLabel1.Text = "clicked 0 times";
            // 
            // button1_Demo
            // 
            this.button1_Demo.BackColor = System.Drawing.Color.Red;
            this.button1_Demo.Location = new System.Drawing.Point(12, 12);
            this.button1_Demo.Name = "button1_Demo";
            this.button1_Demo.Size = new System.Drawing.Size(284, 77);
            this.button1_Demo.TabIndex = 1;
            this.button1_Demo.Text = "Press Me!";
            this.button1_Demo.UseVisualStyleBackColor = false;
            this.button1_Demo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_Demo_MouseDown);
            // 
            // Status_Strip_practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 162);
            this.Controls.Add(this.button1_Demo);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Status_Strip_practice";
            this.Text = "Status_Strip_practice";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private Button button1_Demo;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}