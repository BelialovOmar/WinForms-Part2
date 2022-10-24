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

namespace WinFormsApp1
{
    public partial class Child : Form
    {
        public Parent parent { get; set; }
        public String text
        {
            get
            {
                return this.textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }
        public Child()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            parent.text = textBox.Text;

        }
    }
}
