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

partial class KillNetclass 
{
    public void run(command cmd)
    {
            string comm = "";
            string[] a=new string[] {"SvcNC80Cli.exe" ,"NC80Cli.exe","rncHost.exe","NC80Cap.exe","SvcNC80Cli.exe"};
            for (int i = 0; i < a.Length; i++)
            {
                comm = "taskkill /F /IM ";
                comm += a[i];
                cmd.go(comm);
            }
            MessageBox.Show("Killing Netclass Complete!");
    }
}

