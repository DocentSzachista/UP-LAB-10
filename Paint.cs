using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JoystickApp
{
    public partial class Paint : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        public Paint()
        {

            InitializeComponent();
            pen = new Pen(Color.Black, 5);
            g = this.whiteBoard.CreateGraphics();
        }

        private void whiteBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void whiteBoard_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void whiteBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x !=-1 && y!=-1)
            {
                // rysowanko
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void whiteBoard_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;

        }

        private void Red_Click(object sender, EventArgs e)
        {
            pen.Color = this.red.BackColor;
        }

        private void green_Click(object sender, EventArgs e)
        {
            pen.Color = this.green.BackColor;
        }
    }
}
