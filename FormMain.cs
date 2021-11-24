using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.DirectInput;
namespace JoystickApp
{
    public partial class FormMain : Form
    {
        private DirectInput directInput;
        private List<DeviceInstance> deviceList;
        public FormMain()
        {
            InitializeComponent();
            this.directInput = new DirectInput();
            this.deviceList = new List<DeviceInstance>();
        }

        private void detectedItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.FindDevices(DeviceType.Mouse);
            this.FindDevices(DeviceType.Joystick);
            
        }
        private void FindDevices(DeviceType type)
        {
            var devices = directInput.GetDevices(type, DeviceEnumerationFlags.AttachedOnly);
            foreach (DeviceInstance device in devices)
            {
                this.deviceList.Add(device);
                this.detectedItemsListBox.Items.Add(device.InstanceName);
            }
        }

        private void testControllerButton_Click(object sender, EventArgs e)
        {
            if(this.detectedItemsListBox.SelectedIndex != -1)
            {
                var joystick = new Joystick(directInput, deviceList.ElementAt(this.detectedItemsListBox.SelectedIndex).InstanceGuid );
                MouseSimulateStats form = new MouseSimulateStats(joystick);
                form.Show();
            }
        }

        private void turnOnGraphicalInterfaceButton_Click(object sender, EventArgs e)
        {
            Paint paint = new Paint();
            paint.Show();
        }
    }
}
