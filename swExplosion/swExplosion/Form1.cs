using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swExplosion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        Graphics g;
        public void Explosion(float x, float y, float pixels)
        {
            Pen exPen = new Pen(Color.White);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            //Pen bluePen = new Pen(Color.SlateBlue, 4);
            Pen redPen = new Pen(Color.Red, 4);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            g.DrawRectangle(exPen, x, y, pixels, pixels);

            float scale = pixels / 150;


            //g.DrawLine(redPen, x - 25, y + pixels, (this.Width / 2) - x, (this.Height / 2));
            //g.DrawLine(redPen, (50 * scale) + x, (75 * scale) + y, (x - 10) * scale, (75 + y) * scale);
            //g.DrawLine(redPen, (this.Height / 2), (this.Width / 2) - y + 25, (this.Height / 2), (this.Width / 2) - y);
            //g.DrawLine(redPen,  (this.Height / 2), (this.Width / 2) + y - 25, (this.Height / 2), (this.Width / 2) + y);


            g.FillEllipse(blueBrush, x, y, 150 * scale, 150 * scale);
            g.FillEllipse(whiteBrush, (25 * scale) + x, (25 * scale) + y, 100 * scale, 100 * scale);

        }
    }
}
