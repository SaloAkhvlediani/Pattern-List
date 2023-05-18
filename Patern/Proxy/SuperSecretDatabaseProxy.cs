namespace Patern.Proxy
{
    public class SuperSecretDatabaseProxy:ISuperSecretDatabase
    {
        private SuperSecretDatabase superSecretDatabase;
        private string databaseName;
        private string password;

        public SuperSecretDatabaseProxy(string databaseName, string password)
        {
            this.databaseName = databaseName;
            this.password = password;   

        }
        public void DisplayDatabaseName()
        {
            if(password.Equals("password"))
            {

                if(superSecretDatabase == null)
                {
                    superSecretDatabase = new SuperSecretDatabase(databaseName);
                }
                superSecretDatabase.DisplayDatabaseName();
            }
        }
    }
}
