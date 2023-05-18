namespace Patern.Proxy
{
    public class SuperSecretDatabase: ISuperSecretDatabase
    {
        private string _databaseName;

        public SuperSecretDatabase (string databaseName)
        {
            _databaseName = databaseName;
        }
        public void DisplayDatabaseName()
        {
            System.Console.WriteLine("Display database Name :" 
                + _databaseName);
        }

    }
}
