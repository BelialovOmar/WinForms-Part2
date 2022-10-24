using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2
{
    public partial class ButtonArray : Form
    {
        Random rnd = new Random();

        public ButtonArray()
        {
            InitializeComponent();
        }


        private const int M = 5;   // кол-во строк массива 
        private const int N = 5;   // кол-во столбцов массива
        private int       X = 60;  // ширина и высота кнопки
        private int       Y = 25;  // расстояние между кнопками
        public  int       serialNumber;   // переменная для хранения порядкого номера кнопки

        Button[,] buttons = new Button [M, N]; // создаем массив кнопок

        private void RemoveBtn(object sender, EventArgs e)
        {
            // удаление кнопки с формы 
            Controls.Remove((Button)sender);
        }

        private void ButtonArray_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    buttons[i, j]        = new Button();
                    serialNumber++;
                    buttons[i, j].Text   = serialNumber.ToString();
                    buttons[i, j].Parent = this;     // присоединяем элемент управления к форме
                    buttons[i, j].Height = 90;
                    buttons[i, j].Width  = 90;
                    buttons[i, j].Location  = new Point(i * X + i * Y, j * X + j * Y);
                    buttons[i, j].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    buttons[i, j].Click    += new EventHandler(RemoveBtn);      // при нажатии удаляем кнопку
                }
            }
        }

    }
}
