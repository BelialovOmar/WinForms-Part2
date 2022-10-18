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
    public partial class ButtonClickPractice : Form
    {
        public ButtonClickPractice()
        {
            InitializeComponent();
        }

        int cnt = 0;

        private void btnClickCounter_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            cnt++;
            b.Text = "Clicked: " + cnt + " times";
        }
    }
}
