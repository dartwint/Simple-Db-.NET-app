using System.Xml.Serialization;

namespace EmployeesDbApp.ConnectionSetup
{
    public static class DbConfigManager
    {
        private static readonly string _configPath = "dbconfig.xml";

        public static void SaveConfig(DbConfig config)
        {
            var serializer = new XmlSerializer(typeof(DbConfig));
            using var writer = new StreamWriter(_configPath);
            serializer.Serialize(writer, config);
        }

        public static DbConfig LoadConfig()
        {
            if (!File.Exists(_configPath))
                return new DbConfig();

            var serializer = new XmlSerializer(typeof(DbConfig));
            using var reader = new StreamReader(_configPath);
            return (DbConfig) serializer.Deserialize(reader)!;
        }
    }
}
