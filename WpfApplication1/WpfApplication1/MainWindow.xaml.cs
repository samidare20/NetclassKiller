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
        command cmd=new command();
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window1_Loaded);
        } 


        private void KillNetclass(object sender, RoutedEventArgs e)
        {
            KillNetclass a = new KillNetclass();
            a.run(cmd,ProcessBox);
        }

        private void VPN(object sender,RoutedEventArgs e)
        {
            VPN vpn = new VPN();
            vpn.run(cmd);
        }

        /// <summary>
        /// 창 크기 변환에 맞춰 클래스 조정
        /// </summary>

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            orginalWidth = this.Width;
            originalHeight = this.Height;
            if (this.WindowState == WindowState.Maximized)
                ChangeSize(this.ActualWidth, this.ActualHeight);
            this.SizeChanged += new SizeChangedEventHandler(Window1_SizeChanged);
        }

        void Window1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ChangeSize(e.NewSize.Width, e.NewSize.Height);
        }

        private void ChangeSize(double width, double height)
        {
            scale.ScaleX = width / orginalWidth;
            scale.ScaleY = height / originalHeight;
            FrameworkElement rootElement = this.Content as FrameworkElement;
            rootElement.LayoutTransform = scale;
        }
    
    }
}