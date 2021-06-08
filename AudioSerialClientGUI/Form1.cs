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
        private const int SLIDER_MAX = 65520;
        private const int SLIDER_MIN = 224;


        private List<Process> audioProcesses = new List<Process>();
        private Process[] selectedProcs = { null, null };
        private static SerialPort port;
        private CSCore.CoreAudioAPI.AudioSessionControl2[] allSessions;
        private string[] latestVals = { "0 : 0.00\r", "1 : 0.00\r" };
        NotifyIcon notifyIcon;


        public Form1()
        {
            InitializeComponent();
            notifyIcon = notifyIcon1;
            comboBox_ComPorts.DataSource = SerialPort.GetPortNames();
            notifyIcon.DoubleClick += TrayIcon_DoubleClick;
            Thread t = new Thread(getAudioProcs);
            t.Start();
            t.Join();
            comboBox_App1.DataSource = getProcNames(audioProcesses);
            comboBox_App2.DataSource = getProcNames(audioProcesses);
            comboBox_App1.SelectedItem = 0;
            comboBox_App2.SelectedItem = 1;
            if (comboBox_App1.SelectedIndex != -1)
            {
                selectedProcs[0] = getAppProc(comboBox_App1.SelectedItem.ToString());
            }
            if (comboBox_App2.SelectedIndex != -1)
            {
                selectedProcs[1] = getAppProc(comboBox_App2.SelectedItem.ToString());
            }
        }



        private void comPortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (port == null || !port.IsOpen)
            {
                port = new SerialPort(comboBox_ComPorts.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
                port.Handshake = Handshake.None;
                port.DtrEnable = true;
                port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                port.Open();
            }
        }

        

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            Control control = textbox_Val1;

            for (int x = 0; x < latestVals.Length; x++)
            {
                string lastLine = sp.ReadLine();
                latestVals[int.Parse(lastLine.Substring(0, 1))] = lastLine;
                control.Invoke((MethodInvoker)delegate ()
                {
                    textbox_Val1.Text = latestVals[0];
                    textbox_Val2.Text = latestVals[1];
                });
            }

            foreach (string indata in latestVals)
            {
                if (indata != "")
                {
                    int index = int.Parse(indata.Substring(0, 1));
                    if (selectedProcs[index] != null)
                    {
                        adjustVol(index, indata);
                    }
                }
                
            }

        }
        
        private void adjustVol(int index, string indata)
        {
            Control appVol1 = textbox_App1;
            Control appVol2 = textbox_App2;
            //data[0].Length - 4 because you are going 3 out and length is 1 greater than [string]array indices
            indata = indata.Split(":")[1];
            indata = indata.Substring(0, indata.IndexOf('\r')).Trim();
            decimal volToSet = Decimal.Round(Decimal.Parse(indata), 2);
            decimal finalVol = Audio.setVolume(selectedProcs[index].Id, allSessions, volToSet);

            if (selectedProcs[0] != null)
            {
                appVol1.Invoke((MethodInvoker)delegate ()
                {
                    appVol1.Text = Audio.getVolume(selectedProcs[0].Id, allSessions).ToString();
                });
            }
            if (selectedProcs[1] != null)
            {
                appVol2.Invoke((MethodInvoker)delegate ()
            {
                appVol2.Text = Audio.getVolume(selectedProcs[1].Id, allSessions).ToString();
            });
            }
        }
        public void getAudioProcs()
        {
            List<Process> ap = new List<Process>();
            allSessions = Audio.getSessions();
            Process[] allProcesses = Process.GetProcesses();

            foreach (Process theprocess in allProcesses)
            {
                foreach(CSCore.CoreAudioAPI.AudioSessionControl2 audSesh in allSessions)
                {
                    if (theprocess.Id == audSesh.ProcessID)
                    {
                        audioProcesses.Add(theprocess);
                    }
                }
            }
        }
               
        private List<string> getProcNames(List<Process> audioProcesses)
        {
            List<string> procNames = new List<string>();
            foreach (Process theprocess in audioProcesses)
            {
                procNames.Add(theprocess.ProcessName);                
            }
            return procNames;
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
            }
        }

        private Process getAppProc(string appName )
        {
            Process[] allProcesses = Process.GetProcesses();
            foreach (Process proc in allProcesses)
            {
                if(proc.ProcessName == appName)
                {
                    return proc;
                }
            }
            return null;
        }

        private void comboBox_AudioApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProcs[0] = getAppProc(comboBox_App1.SelectedItem.ToString());
            textbox_App1.Text = Audio.getVolume(selectedProcs[0].Id, allSessions).ToString();
        }

        private void comboBox_App2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProcs[1] = getAppProc(comboBox_App2.SelectedItem.ToString());
            textbox_App2.Text = Audio.getVolume(selectedProcs[1].Id, allSessions).ToString();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = true;
            }
        }


        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }

}
                                                                     