namespace Patern.Factory.NetworkUtility
{
    public class DNS: INetwork
    {
        public void SendRequest(string ip, int timeSent)
        {
            System.Console.WriteLine(" DNS request sent to "
                + ip + "  " + timeSent + "times");

        }
    }
}
