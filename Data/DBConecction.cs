namespace LibraryApi.Data
{
    public class DBConecction
    {
        private string connectionString = string.Empty;
        public DBConecction()
        {
            var buildSection = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile
                ("appsettings.json").Build();
            connectionString = buildSection.GetSection("ConnectionStrings:strConn").Value;
            //temporal
        }
        public string ConnectionStringSQLServer() { return connectionString; }
    }
}
