namespace Patern.Adapter.DataProccessor
{
    public interface IDataProcessor
    {
        bool DataProcess();
        void SendNetworkRequsest(string ip, string apiKey);
    }
}
