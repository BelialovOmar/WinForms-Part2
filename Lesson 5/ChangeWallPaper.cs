using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Lesson_5
{
    public partial class ChangeWallPaper : Form
    {
        Random rnd = new Random();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        private string[] wallpapers;

        public ChangeWallPaper()
        {
            InitializeComponent();
            timer1.Start();
            wallpapers = Directory.GetFiles("E:\\Рабочий стол\\photo");
            timer1.Interval = 4000;
        }
        private void SetWallpaper(string WallpaperLocation, int WallpaperStyle, int TileWallpaper)
        {
             // Sets the actual wallpaper
            SystemParametersInfo(20, 0, WallpaperLocation, 0x01 | 0x02);
            // Set the wallpaper style to streched (can be changed to tile, center, maintain aspect ratio, etc.
            RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            // Sets the wallpaper style
            rkWallPaper.SetValue("WallpaperStyle", WallpaperStyle);
            // Whether or not this wallpaper will be displayed as a tile
            rkWallPaper.SetValue("TileWallpaper", TileWallpaper);
            rkWallPaper.Close();
        }

        private void ChangeWallPaper_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetWallpaper(wallpapers[rnd.Next(3)], 2,0);
        }
    }
}
