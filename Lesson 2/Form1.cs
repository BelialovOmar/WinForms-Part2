namespace Lesson_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void movingTheWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MovingWindowPractice().ShowDialog();
        }

        private void timerPractice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TimerPractice().ShowDialog();
        }
    }
}