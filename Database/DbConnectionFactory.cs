using MySql.Data.MySqlClient;

namespace SalesAnalytics.Database;

public static class DbConnectionFactory
{
    public static MySqlConnection Create(string connectionString)
    {
        return new MySqlConnection(connectionString);
    }
}
