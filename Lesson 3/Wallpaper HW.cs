using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Lesson_3
{
    public partial class Wallpaper_HW : Form
    {
        public Wallpaper_HW()
        {
            InitializeComponent();
             
        }
        
        private string directory = "C:\\Users\\user\\source\\repos\\BelialovOmar\\WinForms-Part2\\Lesson 3\\Resources";
        private string[] wallpaperArray;
        Random rnd = new Random();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        private int wallpaperCnt;

        // List<Bitmap> wallpaperList = new List<Bitmap>(); // аааааааааааааааааа
        // List<Bitmap> wallpaperList = new List<Bitmap>();
        private void ChangeWallpaper()
        {
            #region НЕ РАБОТАЕТ
            //Bitmap img;
            //foreach (var item in directory)
            //{
            //    img = new Bitmap(item.ToString());
            //    wallpaperList.Add(img);
            //    // ааааааааааааааааааааааааааааааааааа
            //    pictureBox1.Image = img;
            //}
            //timer1.Start();

            // // Bitmap MyImage;
            // // wallpaperArray       = Directory.GetFiles(directory);
            // //  pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // // MyImage = new Bitmap();
            // // pictureBox1.ClientSize = new Size(xSize, ySize);
            // // pictureBox1.Image = (Image)MyImage;
            #endregion
            wallpaperArray = Directory.GetFiles(directory);
            wallpaperCnt = 0;
            timer1.Start();
        }

        private void SetNewWallpaper()
        {
            string wlp = wallpaperArray[wallpaperCnt];
            SystemParametersInfo(20, 0, wlp, 0x01 | 0x02);
            // Set the wallpaper style to streched (can be changed to tile, center, maintain aspect ratio, etc.
            RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            // Sets the wallpaper style
            rkWallPaper.SetValue("WallpaperStyle", 2);
            // Whether or not this wallpaper will be displayed as a tile
            rkWallPaper.SetValue("TileWallpaper", 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetNewWallpaper();
        }
    }
}
