using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JobQ
{
    public enum Status { Running, Stopped, Offline, Online }

    /// <summary>
    /// Properties of a machine should be extended by other more specific machines
    /// </summary>
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public string Status { get; set; }
        public string ConfigValues { get; set; }
    


        public Machine()
        {
            IpAddress = getIpAddress();
            Name = getMachineName();
            Status = "Online";
         
            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
            {
                ConfigValues += key + "=" + ConfigurationManager.AppSettings[key] + " ";
            }
        }

        private string getIpAddress()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        private string getMachineName()
        {
            return Dns.GetHostName();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string machine = String.Format("Name:{0}, IpAddress:{1}, Status:{2}, ConfigValues:{3}",Name, IpAddress, Status, ConfigValues);
            return machine;
        }

    }
}
