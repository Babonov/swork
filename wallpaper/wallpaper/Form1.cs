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

namespace wallpaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void SetWallpaper (string path, int style, int tile)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop");
        }

    }
}
