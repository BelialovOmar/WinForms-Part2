namespace Lesson_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip_practice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Status_Strip_practice().ShowDialog();
        }
    }
}