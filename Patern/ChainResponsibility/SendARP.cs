namespace Patern.ChainResponsibility
{
    public class SendARP : IChain
    {
        private IChain next;
        

        void IChain.SendRequest(NetworkModel request)
        {
            if(request.Success==false)
            {
                Console.WriteLine("Senf ARP failed");
                if(next != null)
                {
                    next.SendRequest(request);  
                }else
                {
                    Console.WriteLine("Networ trasmission faild !! Terminating");
                }

                    
                
            } else
            {
                Console.WriteLine("Send SSH Success");
            }
        }

        public void SetNext(IChain nextCain)
        {
            this.next = nextCain;
        }
    }
}
