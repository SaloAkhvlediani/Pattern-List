namespace Patern.Facade
{
    internal class NetworkFacade
    {
        private Packet packet;
        private Socket socket;
        private Transmission transmission;
         public NetworkFacade (string ip, string protocol, string ProtokolName)
        {
            this.packet= new Packet(ip);
            this.socket= new Socket(protocol);
            this.transmission = new Transmission(ProtokolName);
        }
        public void BuildNetworkLayer()
        {
            packet.PaketBuilt();
            socket.BuildSocket();
            //transmission.SendTransmission();
        }
        public  void SendPacketOverNetwork()
        {
            BuildNetworkLayer();
            transmission.SendTransmission();
        }
    }
}
