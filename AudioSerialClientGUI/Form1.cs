using System;
using System.Windows.Forms;
using System.IO.Ports;
using AudioControl;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;

namespace AudioSerialClientGUI
{
    public partial class Form1 : Form
    {
        private static SerialPort port;
        private List<string> procList = new List<string>();
        private List<int> procIDs = new List<int>();



        public Form1()
        {
            InitializeComponent();

            

            comboBox_ComPorts.Items.AddRange(SerialPort.GetPortNames());
            
            
            

        }

 

        private void comPortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            port = new SerialPort(comboBox_ComPorts.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
            port.Handshake = Handshake.None;
            port.DtrEnable = true;
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            port.Open();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Invoke((MethodInvoker)delegate
            {
                outputBox.AppendText(indata);
            });
        }


        public  void ThreadProc()
        {
            CSCore.CoreAudioAPI.AudioSessionControl2[] allSessions = Audio.getSessions();
            Process[] processList = Process.GetProcesses();

            foreach (Process theprocess in processList)
            {
                foreach(CSCore.CoreAudioAPI.AudioSessionControl2 ac in allSessions)
                {
                    if (theprocess.Id == ac.ProcessID)
                    {
                        procList.Add(theprocess.ProcessName);
                        procIDs.Add(theprocess.Id);
                    }
                }
            }
        }


        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
            if (port.IsOpen)
            {
                port.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(ThreadProc);
            t.Start();
            t.Join();

            foreach(string proc in procList)
            {
                //comboBox_AudioApps.Items.Add(Audio.getAppGUID(ac)); 
                comboBox_AudioApps.Items.Add(proc);
            }

            
           
        }
    }

}
