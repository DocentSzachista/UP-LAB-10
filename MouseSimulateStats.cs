using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SharpDX.DirectInput;
namespace JoystickApp
{
    public partial class MouseSimulateStats : Form
    {
        private Joystick joystick;
        private readonly int mouseSpeed;
        private int x=0, y=0;
        private bool fireClicked;
        public MouseSimulateStats(Joystick joystick)
        {
            this.joystick = joystick;
            this.mouseSpeed = 150;
            InitializeComponent();
            joystick.Acquire();
            while(true)
            {
                this.x = joystick.GetCurrentState().X;
                this.y = joystick.GetCurrentState().Y;
                this.xBox.Text = this.x.ToString();
                this.yBox.Text = this.y.ToString();
                this.fireClicked = this.joystick.GetCurrentState().Buttons[0];
                if(fireClicked)
                {
                    this.fireText.Text = "Wcisnięto";
                }
                else
                {
                    this.fireText.Text = "Niewciśnięto";
                }
            }
        }


       
    }
}
