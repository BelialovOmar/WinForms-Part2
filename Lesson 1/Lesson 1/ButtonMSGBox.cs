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
    public partial class ButtonMSGBox : Form
    {
        public ButtonMSGBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mbox + tab + tab
            MessageBox.Show("Hello!");
        }
    }
}
