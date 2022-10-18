using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2
{
    public partial class TimerPractice : Form
    {
        public TimerPractice()
        {
            InitializeComponent();
        }

        DateTime timerStarts;

        private void TimerPractice_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timerStarts = DateTime.UtcNow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = (DateTime.UtcNow - timerStarts).ToString();
        }

        private void TimerPractice_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
