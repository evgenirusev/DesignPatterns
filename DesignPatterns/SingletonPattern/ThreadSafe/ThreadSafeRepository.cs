namespace SingletonPattern
{
    public class ThreadSafeRepository
    {
        private static volatile ThreadSafeRepository _instance;

        private static readonly object syncLock = new object();

        private ThreadSafeRepository() { }

        public static ThreadSafeRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncLock)
                    {
                        if (_instance == null)
                        {
                            // Creating DB Connection...
                            _instance = new ThreadSafeRepository();
                        }
                    }
                }

                return _instance;
            }
        }

        public string GetByUserId(string id)
        {
            return "Returning User with ID - " + id;
        }
    }
}
