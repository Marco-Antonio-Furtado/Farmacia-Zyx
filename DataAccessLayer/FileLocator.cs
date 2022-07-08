namespace DataAccessLayer
{
    internal class FileLocator
    {
        /// <summary>
        /// Classe para deixar um caminho padrao do banco de dados do sistema 
        /// onde o mesmo devera se encontrar nos documentos do windows para ser achado
        /// </summary>
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
