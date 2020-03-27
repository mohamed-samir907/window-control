using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int TogMove;
        int ValX;
        int ValY;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            ValX = e.X;
            ValY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - ValX, MousePosition.Y - ValY);
                
            }
            
        }
        bool b;
        private void Form1_Click(object sender, EventArgs e)
        {
            if (b)
            {
                this.Opacity = 50;
                b = !b;
            }
            else
            {
                this.Opacity = 100;
                b = !b;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (b)
            {
                this.Opacity = 50;
                b = !b;
            }
            else
            {
                this.Opacity = 100;
                b = !b;
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {

            if (b)
            {
                this.Opacity = 50;
                b = !b;
            }
            else
            {
                this.Opacity = 100;
                b = !b;
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {

            if (b)
            {
                this.Opacity = 50;
                b = !b;
            }
            else
            {
                this.Opacity = 100;
                b = !b;
            }
        }
    }
}
