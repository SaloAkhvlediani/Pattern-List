namespace Patern.Facade
{
    internal class Packet
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string IP { get;  set; }
         public Packet(string ip)
        {
            this.IP = ip;
        }

        public void PaketBuilt()
        {
            System.Console.WriteLine("Build Packet");
        }
    }
}
