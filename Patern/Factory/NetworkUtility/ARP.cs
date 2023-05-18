namespace Patern.Factory.NetworkUtility
{
    public class ARP: INetwork
    {
        public void SendRequest(string ip, int timeSent)
        {
            System.Console.WriteLine("ARP request sent to "
                + ip + "  " + timeSent + "times");

        }
    }
}
