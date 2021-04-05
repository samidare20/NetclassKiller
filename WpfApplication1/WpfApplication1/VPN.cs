using System.Threading;
using System.Windows;
using System.Windows.Controls;

class VPN
{
    public void run(command cmd,TextBlock processbox)
    {
        processbox.Text = "Trying connect VPN...";
        cmd.go("powershell Add-VpnConnection -Name \"chika.kr\" -ServerAddress \"vpn1.shiki.kr\" -TunnelType L2tp -L2tpPsk railgun\n\ny\n");
        Thread.Sleep(3000);
        processbox.Text += "\nTrying login VPN...";
        cmd.go("powershell rasdial chika.kr sunrin1 tsuki");
        processbox.Text += "\nConnecting VPN complete!";
        MessageBox.Show("Connecting VPN complete!");
    }
}
