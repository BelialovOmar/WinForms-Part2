namespace Lesson_1
{
    partial class PortalForm
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
            this.ButtonMSGLink = new System.Windows.Forms.LinkLabel();
            this.buttonClickPractice = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ButtonMSGLink
            // 
            this.ButtonMSGLink.AutoSize = true;
            this.ButtonMSGLink.Location = new System.Drawing.Point(12, 9);
            this.ButtonMSGLink.Name = "ButtonMSGLink";
            this.ButtonMSGLink.Size = new System.Drawing.Size(117, 20);
            this.ButtonMSGLink.TabIndex = 0;
            this.ButtonMSGLink.TabStop = true;
            this.ButtonMSGLink.Text = "Button MSG Box";
            this.ButtonMSGLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonMSGLink_LinkClicked);
            // 
            // buttonClickPractice
            // 
            this.buttonClickPractice.AutoSize = true;
            this.buttonClickPractice.Location = new System.Drawing.Point(12, 29);
            this.buttonClickPractice.Name = "buttonClickPractice";
            this.buttonClickPractice.Size = new System.Drawing.Size(136, 20);
            this.buttonClickPractice.TabIndex = 1;
            this.buttonClickPractice.TabStop = true;
            this.buttonClickPractice.Text = "Practice1 - BtnClick";
            this.buttonClickPractice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.buttonClickPractice_LinkClicked);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClickPractice);
            this.Controls.Add(this.ButtonMSGLink);
            this.Name = "PortalForm";
            this.Text = "Portal Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel ButtonMSGLink;
        private LinkLabel buttonClickPractice;
    }
}