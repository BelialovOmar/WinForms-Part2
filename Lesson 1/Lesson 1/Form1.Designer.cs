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
            this.MouseEvent = new System.Windows.Forms.LinkLabel();
            this.runningAwayBtn = new System.Windows.Forms.LinkLabel();
            this.drawingButtonsPractice = new System.Windows.Forms.LinkLabel();
            this.KeyBoardExample = new System.Windows.Forms.LinkLabel();
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
            // MouseEvent
            // 
            this.MouseEvent.AutoSize = true;
            this.MouseEvent.Location = new System.Drawing.Point(12, 49);
            this.MouseEvent.Name = "MouseEvent";
            this.MouseEvent.Size = new System.Drawing.Size(135, 20);
            this.MouseEvent.TabIndex = 2;
            this.MouseEvent.TabStop = true;
            this.MouseEvent.Text = "Mouse Leave/Enter";
            this.MouseEvent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MouseEvent_LinkClicked);
            // 
            // runningAwayBtn
            // 
            this.runningAwayBtn.AutoSize = true;
            this.runningAwayBtn.Location = new System.Drawing.Point(12, 69);
            this.runningAwayBtn.Name = "runningAwayBtn";
            this.runningAwayBtn.Size = new System.Drawing.Size(225, 20);
            this.runningAwayBtn.TabIndex = 3;
            this.runningAwayBtn.TabStop = true;
            this.runningAwayBtn.Text = "Practice2 - Running Away Button";
            this.runningAwayBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.runningAwayBtn_LinkClicked);
            // 
            // drawingButtonsPractice
            // 
            this.drawingButtonsPractice.AutoSize = true;
            this.drawingButtonsPractice.Location = new System.Drawing.Point(12, 89);
            this.drawingButtonsPractice.Name = "drawingButtonsPractice";
            this.drawingButtonsPractice.Size = new System.Drawing.Size(193, 20);
            this.drawingButtonsPractice.TabIndex = 4;
            this.drawingButtonsPractice.TabStop = true;
            this.drawingButtonsPractice.Text = "Practice3 - Drawing Buttons";
            this.drawingButtonsPractice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.drawingButtonsPractice_LinkClicked);
            // 
            // KeyBoardExample
            // 
            this.KeyBoardExample.AutoSize = true;
            this.KeyBoardExample.Location = new System.Drawing.Point(12, 109);
            this.KeyBoardExample.Name = "KeyBoardExample";
            this.KeyBoardExample.Size = new System.Drawing.Size(73, 20);
            this.KeyBoardExample.TabIndex = 5;
            this.KeyBoardExample.TabStop = true;
            this.KeyBoardExample.Text = "KeyBoard";
            this.KeyBoardExample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KeyBoardExample_LinkClicked);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeyBoardExample);
            this.Controls.Add(this.drawingButtonsPractice);
            this.Controls.Add(this.runningAwayBtn);
            this.Controls.Add(this.MouseEvent);
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
        private LinkLabel MouseEvent;
        private LinkLabel runningAwayBtn;
        private LinkLabel drawingButtonsPractice;
        private LinkLabel KeyBoardExample;
    }
}