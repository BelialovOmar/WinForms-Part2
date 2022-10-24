namespace Lesson_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_ParentChildPractice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ParentForm().ShowDialog();
        }
    }
}