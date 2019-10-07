using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

    partial class command
    {
        ProcessStartInfo cmd = new ProcessStartInfo();
        Process process = new Process();
        public command()
        {
            cmd.FileName = @"cmd";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.CreateNoWindow = false;

            cmd.UseShellExecute = false;
            cmd.RedirectStandardOutput = true;
            cmd.RedirectStandardInput = true;
            cmd.RedirectStandardError = true;

        }
        public void go(string com)
        {
            process.EnableRaisingEvents = false;
            process.StartInfo = cmd;
            process.Start();
            process.StandardInput.Write(@com + Environment.NewLine);

            process.StandardInput.Close();
        }
    }


