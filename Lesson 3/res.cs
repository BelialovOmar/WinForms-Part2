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
    public partial class res : Form
    {
        public res()
        {
            InitializeComponent();
            string path = "C:\\Users\\user\\source\\repos\\BelialovOmar\\WinForms-Part2\\Lesson 3\\Resources\\brennan-burling-vpaHZEYx35U-unsplash (1).jpg";

            var bmp = new Bitmap(path);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
