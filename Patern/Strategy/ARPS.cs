namespace Patern.Strategy
{
    public class ARPS : IStrategy
    {
        public void CalculateSum()
        {
            throw new NotImplementedException();
        }

        public void Excute()
        {
            System.Console.WriteLine("Sending ARPS request!");
        }
    }
}
