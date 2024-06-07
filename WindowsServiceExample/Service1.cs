using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServiceExample
{
    public partial class Service1 : ServiceBase
    {
        Timer timer=new Timer();
        private static int count = 0;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile($"Service started {Environment.NewLine}");
            timer.Enabled = true;
            timer.Interval = 5000;
            timer.Elapsed += new ElapsedEventHandler(OnElapse);
        }

        protected override void OnStop()
        {
            WriteToFile($"Service stopped {Environment.NewLine}");
        }

        void OnElapse(object src,EventArgs e)
        {
            count++;
            WriteToFile($"Service count -{count } {Environment.NewLine}");
        }

        static void WriteToFile( string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"D:\Code\DotNetConcept\WindowsServiceExample\bin\Debug\log.txt",true))
                {
                    writer.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
