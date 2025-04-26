namespace PTB2App_New
{
    public static class AppConfig
    {
        public static string ConnectionString => 
            "Server=localhost,1433;Database=master;User Id=sa;Password=YOUR_PASSWORD_HERE;TrustServerCertificate=True;";
    }
}
