namespace Patern.ChainResponsibility
{
    public class SendSSh : IChain
    {
        private IChain next;
        void IChain.SendRequest(NetworkModel request)
        {
            if(request.Success==false)
            {
                Console.WriteLine("Send SSH faild  Sending PING");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send Ping Success");
            }
        }

        void IChain.SetNext(IChain nextChain)
        {
            this.next = nextChain;
        }
    }
}
