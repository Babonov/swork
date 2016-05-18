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
        int Style;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Functional.SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\1.jpg", Style, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Functional.SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\2.jpg", Style, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Functional.SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\3.jpg", Style, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Functional.SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\4.jpg", Style, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Functional.SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\5.jpg", Style, 0);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Functional.SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\6.jpg", Style, 0);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Functional.SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\7.jpg", Style, 0);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Functional.SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\8.jpg", Style, 0);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Functional.SetWallpaper("C:\\Users\\MediaMarkt\\Desktop\\семестровая\\pictures\\9.jpg", Style, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Исходный размер": Style = 1; break;
                case "Растянуть": Style = 2; break;
            }

        }


    }
}
