using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
