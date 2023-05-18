namespace Patern.Strategy
{
    public class Contex
    {
        IStrategy _strategy;
        public Contex(IStrategy strategy)
        {
            this._strategy = strategy;
        }


        public void ExecuteStrategy()
        {
            _strategy.Excute();
        }
    }

    public class Test
    {

    }
}
