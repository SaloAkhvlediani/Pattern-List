namespace Patern.ChainResponsibility
{
    public interface IChain
    {
        void SendRequest(NetworkModel request);
        void SetNext(IChain nextChain);
    }
}
