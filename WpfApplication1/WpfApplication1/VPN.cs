using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class VPN
{
    public void run(command cmd)
    {
        cmd.go("powershell Add-VpnConnection -Name \"chika.kr\" -ServerAddress \"chika.kr\" -TunnelType L2tp -L2tpPsk railgun\n\ny\n");
        Thread.Sleep(3000);
        cmd.go("powershell rasdial chika.kr sunrin1 tsuki");
    }
}
