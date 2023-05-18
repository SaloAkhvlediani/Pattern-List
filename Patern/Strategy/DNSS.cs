namespace Patern.Strategy
{
    public class DNSS : IStrategy
    {
        public void CalculateSum()
        {
            throw new NotImplementedException();
        }

        void IStrategy.Excute()
        {
            System.Console.WriteLine("Sending DNS!");
        }
    }
}
