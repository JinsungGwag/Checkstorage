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
        SerialPort currentPort;
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
                rcComboBox.Items.Clear();
            });

            foreach (string port in SerialPort.GetPortNames())
            {
                Invoke((MethodInvoker)delegate
                {
                    rcComboBox.Items.Add(port);
                });
            }
        }
        
        public void DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string recievedData = sp.ReadLine();
                count++;
                showReceived("Data" + count + " : " + recievedData + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail to receive\n\r" + ex.Message);
            }
        }

        public void showReceived(string data)
        {
            Invoke((MethodInvoker)delegate
            {
                rsListBox.Items.Add(data);
            });
        }

        private void cnButton_Click(object sender, EventArgs e)
        {
            currentPort = new SerialPort(rcComboBox.SelectedItem.ToString())
            {
                BaudRate = 9600
            };
            currentPort.DataReceived += new SerialDataReceivedEventHandler(DataRecieved);

            try
            {
                if (!currentPort.IsOpen)
                    currentPort.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dcButton_Click(object sender, EventArgs e)
        {
            currentPort.Close();
            currentPort.DataReceived -= new SerialDataReceivedEventHandler(DataRecieved);
            count = 0;
        }
    }
}