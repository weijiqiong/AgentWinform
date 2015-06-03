
using System.Configuration;
using System.IO;
using System.Reflection;

namespace XmlDatabase
{
    static class PathRoute
    {
        public static readonly string DataFolder = ConfigurationManager.AppSettings["DataFolder"];
        public static string GetXmlPath<T>()
        {
            string dataFolder = DataFolder;
            if (string.IsNullOrEmpty(dataFolder))
            {
                dataFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data");
            }
            return Path.ChangeExtension(dataFolder, ".xml");
        }
    }
}