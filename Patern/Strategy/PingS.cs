namespace Patern.Strategy
{
    public class PingS : IStrategy
    {
        public void CalculateSum()
        {
            throw new NotImplementedException();
        }

        public void Excute()
        {
            Console.WriteLine("Sending Ping !");
        }
    }
}
