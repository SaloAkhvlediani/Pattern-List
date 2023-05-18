using Patern.Adapter.DataProccessor;
using Patern.Adapter.Network;

namespace Patern.Adapter
{
    internal class NetworkAdapter : INetworkClient

    {
        private readonly IDataProcessor _dataProcessor;
       // private readonly IDataProcessor _dataProcessor;

        public NetworkAdapter(IDataProcessor dataProcessor) 
        { 
            _dataProcessor = dataProcessor;
        }
        public void SendRequest(string ipAddress)
        {
            var apiKey = "11.22.33.44";
            _dataProcessor.SendNetworkRequsest(ipAddress, apiKey);
        }
    }
}
