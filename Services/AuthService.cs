using MySql.Data.MySqlClient;
using SalesAnalytics.Database;
using SalesAnalytics.Helpers;
using SalesAnalytics.Models;
using System.Configuration;

namespace SalesAnalytics.Services;

public static class AuthService
{
    public static CurrentUser? ValidateCredentials(string login, string password)
    {
        const string sql = """
                           SELECT u.user_id, u.full_name, u.password_salt, u.password_hash, r.role_name
                           FROM users u
                           JOIN roles r ON u.role_id = r.role_id
                           WHERE u.login = @login
                             AND u.is_active = 1;
                           """;

        var connectionString = ConfigurationManager.ConnectionStrings["SalesAnalyticsDb"]?.ConnectionString
                               ?? throw new InvalidOperationException("Connection string SalesAnalyticsDb not found.");

        using var connection = DbConnectionFactory.Create(connectionString);
        using var command = new MySqlCommand(sql, connection);
        command.Parameters.AddWithValue("@login", login);

        connection.Open();
        using var reader = command.ExecuteReader();
        if (!reader.Read())
        {
            return null;
        }

        var salt = reader["password_salt"]?.ToString() ?? string.Empty;
        var expectedHash = reader["password_hash"]?.ToString() ?? string.Empty;
        if (!PasswordHelper.VerifyWithSalt(password, salt, expectedHash))
        {
            return null;
        }

        return new CurrentUser
        {
            UserId = Convert.ToInt32(reader["user_id"]),
            FullName = reader["full_name"]?.ToString() ?? string.Empty,
            RoleName = reader["role_name"]?.ToString() ?? string.Empty
        };
    }
}
