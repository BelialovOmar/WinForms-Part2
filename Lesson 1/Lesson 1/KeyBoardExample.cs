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
    public partial class KeyBoardExample : Form
    {
        public KeyBoardExample()
        {
            InitializeComponent();
        }

        private void KeyBoardExample_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Value: " + e.KeyValue + " Code: " + e.KeyCode);
        }
    }
}
