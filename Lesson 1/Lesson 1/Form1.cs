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
    }
}