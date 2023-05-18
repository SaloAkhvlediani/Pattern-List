namespace Patern.Adapter.DataProccessor
{
    public class DataProcessor: IDataProcessor
    {
        public bool DataProcess()
        {
            System.Console.WriteLine("Processes data");
            return true;
        }

        public void SendNetworkRequsest(string ip, string apiKey)
        {
            System.Console.WriteLine(" (dataprocessor) Send network requset with " +
                "Ip adress that requires API Key: " + ip );
        }
    }
}
