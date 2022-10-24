using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Lesson_4
{
    public partial class ParentForm : Form
    {
        
        public ParentForm()
        {
            InitializeComponent(); 
        }
        public ParentForm parent { get; set; }
        public string text23
        {
            get
            {
                return this.textBox_Demo1.Text;
            }
            set
            {
                textBox_Demo1.Text = value;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            parent.text23 = textBox_Demo1.Text;
        }
    }
}
