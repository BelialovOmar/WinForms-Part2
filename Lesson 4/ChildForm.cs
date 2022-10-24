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

namespace Lesson_4
{
    public partial class ChildForm : Form
    {
        public ChildForm child { get; set; }
        public String text
        {
            get
            {
                return this.textBox_Demo2.Text;
            }
            set
            {
                this.textBox_Demo2.Text = value;
            }
        }
        public ChildForm()
        {
            InitializeComponent();
            this.child = new ChildForm();
            this.child.parent = this;
            child.Show();
        }

        private void textBox_Demo2_TextChanged(object sender, EventArgs e)
        {
            child.text = textBox_Demo2.Text;

        }
    }
}
