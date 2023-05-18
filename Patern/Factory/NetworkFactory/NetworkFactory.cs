using Patern.Facade;
using Patern.Factory.NetworkUtility;

namespace Patern.Factory.NetworkFactory
{
    internal class NetworkFactory
    {
        public INetwork GetNetworkInstance(string type)
        {
            INetwork obj = null;
            if(type.ToLower().Equals("ping")) 
            {
                obj = new Ping();
                //obj = new Socket();
            }
            else if (type.ToLower().Equals("arp"))
            {
                obj = new ARP();
            }
            else if (type.ToLower().Equals("dns"))
            {
                obj = new DNS();
            }
            else
            {
                Console.WriteLine("Type not found");
            }
            
            return obj;

        }
    }
}
