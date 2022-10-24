using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5
{
    public partial class RichTextBox_Practice : Form
    {
        public RichTextBox_Practice()
        {
            InitializeComponent();

            richTextBox1.Text = "\nIt's a cat.";
            Clipboard.SetImage(Image.FromFile("C:\\Users\\user\\Pictures\\imgCat.jpg"));
            richTextBox1.Paste();
        }
         
    }
}
