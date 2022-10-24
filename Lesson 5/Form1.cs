namespace Lesson_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel_practirRichTextBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RichTextBox_Practice().Show();
        }
    }
}