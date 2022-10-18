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
    public partial class MouseEventEnterLeave : Form
    {
        public MouseEventEnterLeave()
        {
            InitializeComponent();
        }

        // при наведении указателя мыши кнопка станет крайной
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Red;
        }

        // когда мы уберем указатель мыши, кнопка станет синей
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Blue;
        }
    }
}
