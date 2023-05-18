namespace Patern.Facade
{
    public class Socket
    {
        public int IP { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }    
        public Socket(string protocol)
        {
            this.Protocol = protocol;
        }
         
        public void BuildSocket()
        {
            System.Console.WriteLine("Build Socket");
        }
    }
}
