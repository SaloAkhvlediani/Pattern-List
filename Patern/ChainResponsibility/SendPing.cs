using static System.Net.Mime.MediaTypeNames;

namespace Patern.ChainResponsibility
{
    public class SendPing : IChain
    {
        private IChain next;
        void IChain.SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send Pain faild  Sending Arp");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send SSH Success");
            }
        }

        void IChain.SetNext(IChain nextChain)
        {
            this.next = nextChain;

        }
    }
}
