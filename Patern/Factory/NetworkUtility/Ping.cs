namespace Patern.Factory.NetworkUtility
{
    internal class Ping: INetwork
    {
        public void SendRequest(string ip, int timeSent)
        {
            System.Console.WriteLine(" Ping request sent to "
                + ip + "  " + timeSent + "times");
                
        }
    }
}
