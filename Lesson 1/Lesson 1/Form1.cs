namespace Lesson_1
{
    public partial class PortalForm : Form
    {
        public PortalForm()
        {
            InitializeComponent();
        }

        private void ButtonMSGLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ButtonMSGBox().ShowDialog();
        }

        private void buttonClickPractice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ButtonClickPractice().ShowDialog();
        }

        private void MouseEvent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MouseEventEnterLeave().ShowDialog();
        }

        private void runningAwayBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RunningAwayButton().ShowDialog();
        }

        private void drawingButtonsPractice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DrawingButtons().ShowDialog();
        }

        private void KeyBoardExample_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new KeyBoardExample().ShowDialog();
        }
    }
}