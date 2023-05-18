namespace Patern.Adapter.Network
{
    public class NetworkClient : INetworkClient
    {
         public   void SendRequest(string ipAddress)

        {
            System.Console.WriteLine("1 - NetWork client requset To IP: " + ipAddress);
        }
    }
}
