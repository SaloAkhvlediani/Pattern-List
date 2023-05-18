namespace Patern.Facade
{
    public class Transmission
    {
        public int Id { get; set; }
         public string Name { get; set; }
         
        public Transmission(string ProtocolName)
        {
            this.Name = ProtocolName;
        }
         
        public void SendTransmission()
        {
            System.Console.WriteLine(" Send Transmisson");
        }
            
    }
}
