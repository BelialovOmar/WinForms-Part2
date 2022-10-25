using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5
{
    public partial class TimeInfo : Form
    {
        public TimeInfo()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox_Time.Items.Clear();

            DateTime time = DateTime.Now; // узнаем время

            var NewYorkTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(time, "Eastern Standard Time").ToString(new CultureInfo("en-US").DateTimeFormat); // конвертируем
            listBox_Time.Items.Add($"Time in New York - {NewYorkTime}"); // добавляем в ListBox элемент

            var LondonTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(time, "GMT Standard Time").ToString(new CultureInfo("en-GB").DateTimeFormat);
            listBox_Time.Items.Add($"Time in London - {LondonTime}");

            var CaliforniaTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(time, "Pacific Standard Time").ToString(new CultureInfo("en-US").DateTimeFormat);
            listBox_Time.Items.Add($"Time in California - {CaliforniaTime}");

            var TokyoTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(time, "Tokyo Standard Time").ToString(new CultureInfo("ja-JP").DateTimeFormat);
            listBox_Time.Items.Add($"Tokyo - {TokyoTime}");

            var KyivTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(time, "FLE Standard Time").ToString(new CultureInfo("uk-UA").DateTimeFormat);
            listBox_Time.Items.Add($"Kyiv - {KyivTime}");

        }
    }
}
