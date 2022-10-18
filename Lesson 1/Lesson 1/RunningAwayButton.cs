using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_1
{
    public partial class RunningAwayButton : Form
    {
        Random random = new Random();

        public RunningAwayButton()
        {
            InitializeComponent();
        }

        // при наведении на кнопку она отскакивает в случайные координаты
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(random.Next(0, this.Width - button1.Width), random.Next(0, this.Height - button1.Height));
        }
    }
}
