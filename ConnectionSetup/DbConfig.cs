namespace EmployeesDbApp.ConnectionSetup
{
    public class DbConfig
    {
        private static DbConfig? _default;

        public static DbConfig Default
        {
            get {
                if (_default == null) _default = new DbConfig();
                
                return _default;
            }
        }

        public string Host { get; set; } = "localhost";
        public string Port { get; set; } = "5432";
        public string User { get; set; } = "postgres";
        public string Password { get; set; } = "masterkey";
        public string Database { get; set; } = "EmployeeDB";

        public string GetConnectionString() =>
            $"Host={Host};Port={Port};Username={User};Password={Password};Database={Database};";

        public DbConfig() { }

        public DbConfig(string host, string port, string user, string password)
        {
            Host = host;
            Port = port;
            User = user;
            Password = password;
        }

        public DbConfig(string host, string port, string user, string password, string database)
        {
            Host = host;
            Port = port;
            User = user;
            Password = password;
            Database = database;
        }
    }
}
