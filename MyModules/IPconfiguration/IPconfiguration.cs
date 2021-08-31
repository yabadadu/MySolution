using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MyModules.IPconfiguration
{
    public class IPconfiguration
    {
        public static string GetIPAddressV4()
        {
            string result = "";
            String strHostName = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                if (ipaddress.AddressFamily.ToString().Equals("InterNetwork"))
                    result = ipaddress.ToString();
            }
            return strHostName + "; " + result;
        }

        public static string GetIPAddressV6()
        {
            string result = "";
            String strHostName = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                if (ipaddress.AddressFamily.ToString().Equals("InterNetworkV6"))
                    result = ipaddress.ToString();
            }
            return strHostName + "; " + result;
        }

    }
}
