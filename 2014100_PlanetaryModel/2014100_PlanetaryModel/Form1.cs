using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2014100_PlanetaryModel
{
//    Celestial Bodies:

//http://en.wikipedia.org/wiki/Astrological_symbols
//http://en.wikipedia.org/wiki/Greek_astronomy


//    *Sun: (U+2609) ☉
//    *Mercury: (U+263F) ☿
//    *Venus: (U+2640) ♀
//    *Earth: (U+2295) ⊕
//    *Moon: (U+263D) ☽
//    *Mars: (U+2642) ♂

    //Celestial variables:
    
    public partial class Form1 : Form
    {
        
        //Celestial variables:
        const int SunRadius = 696000; //kilometers
        const int SunDiameter = SunRadius * 2;

        //Graphics g = Graphics.FromImage(bmap);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Black;
            drawSun(this);
            
        }

        private void drawSun(Control control)
        {
            Point FormCenter = new Point(control.Width / 2, control.Height / 2);//dont use this one, use SolarCenter
            Point SolarCenter = FormCenter;
            Bitmap bmap = new Bitmap(control.Width,control.Height);
            int SunWidth = 80;
            int SunHeight = 80;
            Rectangle Sun = new Rectangle(SolarCenter.X-SunWidth/2, SolarCenter.Y-SunHeight/2, SunWidth, SunHeight);
            Rectangle Space = new Rectangle(0, 0, bmap.Width, bmap.Height);
            Graphics g = Graphics.FromImage(bmap);
            g.FillRectangle(Brushes.Black, 0, 0, bmap.Width, bmap.Height);
            g.FillEllipse(Brushes.Yellow, Sun);
            control.BackgroundImage = bmap;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            drawSun(this);
        }
    }
}
