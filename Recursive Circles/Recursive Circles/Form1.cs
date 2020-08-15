using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursive_Circles
{
    public partial class Form1 : Form
    {
        List<Color> lstColors;
        Random randomizer;

        public Form1()
        {
           
            InitializeComponent();
            lstColors = new List<Color>();
            randomizer = new Random((int)DateTime.Now.Ticks);
            lstColors.Add(Color.Red);
            lstColors.Add(Color.Blue);
            lstColors.Add(Color.Green);
            lstColors.Add(Color.Yellow);
            lstColors.Add(Color.Purple);
            lstColors.Add(Color.Turquoise);
            lstColors.Add(Color.Aqua);
            lstColors.Add(Color.IndianRed); 
            lstColors.Add(Color.Bisque);
            lstColors.Add(Color.Firebrick);
            lstColors.Add(Color.Bisque);
            lstColors.Add(Color.Azure);
            lstColors.Add(Color.Brown);
            lstColors.Add(Color.BlueViolet);
            lstColors.Add(Color.Chocolate);
            lstColors.Add(Color.DarkGoldenrod);
            lstColors.Add(Color.CornflowerBlue);

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            draw(panel1.Width/2,5,500);
           
        }
        private void draw(int X,int Y, int radius)
        {
            int Colournum = randomizer.Next(lstColors.Count);
            Graphics g = panel1.CreateGraphics();
            panel1.BackColor = Color.Black;
            Pen pen = new Pen(lstColors[Colournum]);
            
            g.DrawEllipse(pen,X, Y, radius,radius);

            if(radius > 10)
            {
                radius -= 20;
                draw(X - radius/2,Y,radius);
                draw(X + radius / 2, Y, radius);


            }

        }


        
    }
}
