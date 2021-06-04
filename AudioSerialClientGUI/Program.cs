using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioSerialClientGUI
{
    public class Program
    {
                /// <summary>
            ///  The main entry point for the application.
            /// </summary>
            [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            ComboBox comboBox1 = new ComboBox();

            comboBox1.Location = new System.Drawing.Point(20, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(245, 25);
            comboBox1.BackColor = System.Drawing.Color.Orange;
            comboBox1.ForeColor = System.Drawing.Color.Black;



        }
    }
}
