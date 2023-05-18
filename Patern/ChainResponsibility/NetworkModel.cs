namespace Patern.ChainResponsibility
{
    public class NetworkModel
    {
        public string IP { get; set; }  
        public bool  Success { get; set; }

        public NetworkModel(string ip, bool success) 
        {
            this.IP = ip;
            this.Success = success;
        }

    }
}
