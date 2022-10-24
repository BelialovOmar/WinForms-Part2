using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3
{
    public partial class statusStrip_practice : Form
    {
        public statusStrip_practice()
        {
            InitializeComponent();
        }

        int cnt;  // счетчик кликов

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            cnt++;
            toolStripStatusLabel1.Text = $"clicked {cnt} times";
        }
    }
}
