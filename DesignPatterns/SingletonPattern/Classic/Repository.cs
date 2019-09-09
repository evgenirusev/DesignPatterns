namespace SingletonPattern
{
    public sealed class Repository
    {
        private Repository() { }

        private static Repository _instance;

        public static Repository Instance()
        {
            if (_instance == null) {
                // Create DB Connection...
                _instance = new Repository();
                
            }

            return _instance;
        }

        public string GetByUserId(string id)
        {
            return "User from Database with ID - " + id;
        }
    }
}
