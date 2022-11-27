using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Remoting
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel chan = new TcpChannel(8085);
            ChannelServices.RegisterChannel(chan);

            RemotingConfiguration.RegisterWellKnownServiceType(System.Type.GetType("SeverClass.myRemoteClass, ServerClass"), "RemoteTest",
            WellKnownObjectMode.SingleCall);

            System.Console.WriteLine("Hit <enter> to exit..");
            System.Console.ReadLine();
        }
            
    }
}
