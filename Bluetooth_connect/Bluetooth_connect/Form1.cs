using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluetooth_connect
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showPorts();
        }   

        public void showPorts()
        {
            Invoke((MethodInvoker)delegate
            {
                sdComboBox.Items.Clear();
                rcComboBox.Items.Clear();
            });

            foreach (string port in SerialPort.GetPortNames())
            {
                Invoke((MethodInvoker)delegate
                {
                    sdComboBox.Items.Add(port);
                    rcComboBox.Items.Add(port);
                });
            }
        }
    }
}