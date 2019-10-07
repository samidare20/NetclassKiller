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
namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        double orginalWidth, originalHeight;
        ScaleTransform scale = new ScaleTransform();
        command oscmd=new command();
        public MainWindow()
        {
        InitializeComponent();
        this.Loaded += new RoutedEventHandler(Window1_Loaded);
        }
        /// <summary>
        /// 사이즈 조정
        /// </summary>
        void Window1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        ChangeSize(e.NewSize.Width, e.NewSize.Height);
        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
        orginalWidth = this.Width;
        originalHeight = this.Height;
        if (this.WindowState == WindowState.Maximized)
            ChangeSize(this.ActualWidth, this.ActualHeight);
        this.SizeChanged += new SizeChangedEventHandler(Window1_SizeChanged);
        }

        private void ChangeSize(double width, double height)
        {
        scale.ScaleX = width / orginalWidth;
        scale.ScaleY = height / originalHeight;
        FrameworkElement rootElement = this.Content as FrameworkElement;
        rootElement.LayoutTransform = scale;
        }

        /// <summary>
        /// kill netclass
        /// </summary>
        private void KillNetclass(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            KillNetclass a = new KillNetclass();
            a.test(cmd);
        }
    
=======
            string comm = "";
            string[] a=new string[] {"SvcNC80Cli.exe" ,"NC80Cli.exe","rncHost.exe","NC80Cap.exe","SvcNC80Cli.exe"};
            for (int i = 0; i < a.Length; i++)
            {
                comm = "taskkill /F /IM ";
                comm += a[i];
                oscmd.go(comm );
            }
            MessageBox.Show("Killing Netclass Complete!");
        }


        private void Korvpn(object sender, RoutedEventArgs e)
        {
            oscmd.go("powershell Add-VpnConnection -Name \"vpn\" -ServerAddress \"chika.kr\" -TunnelType L2tp -L2tpPsk railgun");
            oscmd.go("y" );
            MessageBox.Show("complete");
        }
        /// <summary>
        /// cmd
        /// </summary>
        public class command
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            Process process = new Process();
            public command()
            {
                cmd.FileName=@"cmd";
               // cmd.WindowStyle=ProcessWindowStyle.Hidden;
                cmd.CreateNoWindow=false;
                cmd.UseShellExecute=false;
                cmd.RedirectStandardOutput=true;
                cmd.RedirectStandardInput=true;
                cmd.RedirectStandardError=true;
            }
            public void go(string com)
            {
                process.StartInfo = cmd;
                process.Start();
                process.StandardInput.Write(@com + Environment.NewLine);
                process.WaitForExit();
                //process.StandardInput.Close();
            }
        }
>>>>>>> 24390d61e5eaafa328d9e799f0dea4c1c384aa28
    }
}