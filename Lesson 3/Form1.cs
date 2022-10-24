namespace Lesson_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStripPractire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new statusStrip_practice().ShowDialog();
        }
    }
}