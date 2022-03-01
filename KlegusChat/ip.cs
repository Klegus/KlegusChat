using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KlegusChat
{
    internal class ip
    {
        public static string grab()
        {
            var externalip = new WebClient().DownloadString("https://ipv4.icanhazip.com/").TrimEnd();
            return externalip;
        }
    }
}
