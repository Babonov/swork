using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace wallpaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int SPI_SETDESKWALLPAPER = 20;
const int SPIF_UPDATEINIFILE = 0x01;
const int SPIF_SENDWININICHANGE = 0x02;

[DllImport("user32.dll", CharSet = CharSet.Auto)]
static extern int SystemParametersInfo (int uAction, int uParam, string lpvParam, int fuWinIni);

        
        public static void SetWallpaper (string path, int style, int tile)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            key.SetValue("WallpaperStyle", style.ToString());
            key.SetValue("TileWallpaper", tile.ToString());
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\1.jpg", 1, 0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\2.jpg", 2, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\2.jpg", 2, 0);
        }


    }
}
