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

        private void linkLabel1_screen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ScreenShot().Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ChangeWallPaper().Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TimeInfo().Show();
        }
    }
}