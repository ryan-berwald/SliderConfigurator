using System;
using System.IO.Ports;

namespace Serial
{
    class Serial
    {
        public static string inData;
        public Serial(string port)
        {
            SerialPort _serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            _serialPort.Handshake = Handshake.None;
            _serialPort.DtrEnable = true;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        public static string[] getPorts()
        {
            return SerialPort.GetPortNames();
        }


        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            inData = sp.ReadExisting();
        }
    }
}
