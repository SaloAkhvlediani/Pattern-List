namespace Patern.Singelton
{
    public class Singleton
    {
        static Singleton instanse;

        public string Setting { get; set; } = "Color blue";
        public object IP { get; set; }=3.3;
        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            if(instanse==null)
            {
                instanse= new Singleton();
            }
            return instanse;
        }

     }
}
