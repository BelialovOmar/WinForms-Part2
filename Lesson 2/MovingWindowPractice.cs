using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2
{
    public partial class MovingWindowPractice : Form
    {
        public MovingWindowPractice()
        {
            InitializeComponent();
        }

        private void MovingWindowPractice_KeyDown(object sender, KeyEventArgs e)
        {
            Point? newLocation = null;

            if (e.KeyValue == 38 || e.KeyValue == 87)  // up + W
            {
                newLocation = new Point(this.Location.X, this.Location.Y - 50);
            }
            if (e.KeyValue == 40 || e.KeyValue == 83)  // down + S
            {
                newLocation = new Point(this.Location.X, this.Location.Y + 50);
            }
            if (e.KeyValue == 37 || e.KeyValue == 65) // left + A
            {
                newLocation = new Point(this.Location.X - 50, this.Location.Y);
            }
            if (e.KeyValue == 39 || e.KeyValue == 68) // right + D
            {
                newLocation = new Point(this.Location.X + 50, this.Location.Y);
            }
            if (newLocation != null)
            {
                if (Screen.PrimaryScreen.Bounds.Contains(new Rectangle(newLocation.Value, this.Size)))
                {
                    this.Location = newLocation.Value;
                }
            }
        }
    }
}
