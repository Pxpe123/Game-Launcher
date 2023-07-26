using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Reflection;

namespace GameLauncher.Forms
{
    public partial class FormPerformance : Form
    {

        //Performance Counter
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");
        PerformanceCounter perfGPUCounter = new PerformanceCounter("GPU Engine", "Utilization Percentage", "pid_1728_luid_0x00000000_0x000119B3_phys_0_eng_0_engtype_3D");
        //Text
        PerformanceCounter perfCPUCounter2 = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMemCounter2 = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemCounter2 = new PerformanceCounter("System", "System Up Time");
        PerformanceCounter perfGPUCounter2 = new PerformanceCounter("GPU Engine", "Utilization Percentage", "pid_1728_luid_0x00000000_0x000119B3_phys_0_eng_0_engtype_3D");
     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Value
            siticoneCircleProgressBar1.Value = (int)perfCPUCounter.NextValue();
            siticoneCircleProgressBar2.Value = (int)perfGPUCounter.NextValue();
            //Text
            siticoneCircleProgressBar2.Text = "GPU Usage: " + (int)perfGPUCounter2.NextValue() + "%";
            siticoneCircleProgressBar1.Text = "CPU Usage: " + (int)perfCPUCounter2.NextValue() + "%";
            label2.Text = "Available Memory:" + " " + (int)perfMemCounter.NextValue() + " " + "MB";
            label3.Text = "System Uptime:" + " " + (int)perfSystemCounter.NextValue() / 60 / 60 + "Hours";

        }

        private void siticoneCircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCircleProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
