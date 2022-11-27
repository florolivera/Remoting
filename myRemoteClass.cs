using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ServerClass
{
    public class myRemoteClass : MarshalByRefObject
    {
        public myRemoteClass()
        {
            Console.WriteLine("CONSTRUCTOR");
        }

        public bool setString(string sTemp)
        {
            try
            {
                Console.WriteLine("this string '{0}' has a length of {1}", sTemp, sTemp.Length);
                return sTemp != "";
            }
            catch
            {
                return false;
            }
        }
    }
}
