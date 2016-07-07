namespace BiblioTecca.DAL
{
    class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private readonly Context context;

        private Singleton()
        {
            context = new Context();
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        public Context Context
        {
            get
            {
                return context;
            }
        }        
    }
}
