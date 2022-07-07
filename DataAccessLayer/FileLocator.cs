namespace DataAccessLayer
{
    internal class FileLocator
    {
        private FileLocator()
        {

        }
        private static FileLocator instance;
        public static FileLocator GetInstance()
        {
            if (instance == null)
            {
                instance = new FileLocator();
            }
            return instance;
        }

        public string GetPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
