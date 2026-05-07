using System.Data;
using MySql.Data.MySqlClient;
using SalesAnalytics.Database;
using System.Configuration;

namespace SalesAnalytics.Services;

public static class DataService
{
    private static string ConnectionString =>
        ConfigurationManager.ConnectionStrings["SalesAnalyticsDb"]?.ConnectionString
        ?? throw new InvalidOperationException("Connection string SalesAnalyticsDb not found.");

    public static DataTable GetOrdersTable(string? statusFilter = null)
    {
        const string sqlBase = """
                               SELECT order_id, order_date, status, total_amount, client_name, manager_name, department_name
                               FROM v_orders_full
                               """;
        string sql;
        var parameters = new List<MySqlParameter>();
        if (string.IsNullOrWhiteSpace(statusFilter) || statusFilter == "Все")
        {
            sql = $"{sqlBase} ORDER BY order_date DESC;";
        }
        else
        {
            sql = $"{sqlBase} WHERE status = @status ORDER BY order_date DESC;";
            parameters.Add(new MySqlParameter("@status", statusFilter));
        }

        return ExecuteDataTable(sql, parameters.ToArray(), "v_orders_full");
    }

    public static DataTable GetStatuses()
    {
        const string sql = """
                           SELECT status
                           FROM orders
                           GROUP BY status
                           ORDER BY status;
                           """;
        return ExecuteDataTable(sql, [], "statuses");
    }

    public static DataTable GetClientsLookup()
    {
        const string sql = """
                           SELECT client_id, full_name
                           FROM clients
                           ORDER BY full_name;
                           """;
        return ExecuteDataTable(sql, [], "clients_lookup");
    }

    public static DataTable GetPaymentsLookup()
    {
        const string sql = """
                           SELECT DISTINCT payment_method
                           FROM orders
                           WHERE payment_method IS NOT NULL
                             AND payment_method <> ''
                           ORDER BY payment_method;
                           """;
        return ExecuteDataTable(sql, [], "payments_lookup");
    }

    public static int AddOrder(int clientId, string paymentMethod, string notes, int managerId)
    {
        const string sql = """
                           INSERT INTO orders (order_date, status, client_id, manager_id, payment_method, notes)
                           VALUES (NOW(), 'new', @clientId, @managerId, @paymentMethod, @notes);
                           """;
        return ExecuteNonQuery(sql,
        [
            new MySqlParameter("@clientId", clientId),
            new MySqlParameter("@managerId", managerId),
            new MySqlParameter("@paymentMethod", paymentMethod),
            new MySqlParameter("@notes", notes)
        ]);
    }

    public static int DeleteOrder(int orderId)
    {
        const string sql = "DELETE FROM orders WHERE order_id = @id;";
        return ExecuteNonQuery(sql, [new MySqlParameter("@id", orderId)]);
    }

    public static int ChangeOrderStatus(int orderId, string status)
    {
        const string sql = "UPDATE orders SET status = @status WHERE order_id = @id;";
        return ExecuteNonQuery(sql,
        [
            new MySqlParameter("@status", status),
            new MySqlParameter("@id", orderId)
        ]);
    }

    public static DataTable GetReportsTable()
    {
        return ExecuteDataTable("SELECT * FROM v_sales_stats;", [], "v_sales_stats");
    }

    public static DataTable GetUsersTable()
    {
        const string sql = """
                           SELECT u.user_id, u.login, u.full_name, r.role_name, u.is_active
                           FROM users u
                           JOIN roles r ON r.role_id = u.role_id
                           ORDER BY u.user_id;
                           """;
        return ExecuteDataTable(sql, [], "users");
    }

    public static DataTable GetProductsTable()
    {
        return ExecuteDataTable("SELECT * FROM products ORDER BY product_id;", [], "products");
    }

    public static DataTable GetClientsTable()
    {
        return ExecuteDataTable("SELECT * FROM clients ORDER BY client_id;", [], "clients");
    }

    private static DataTable ExecuteDataTable(string sql, IReadOnlyCollection<MySqlParameter> parameters, string tableName)
    {
        var table = new DataTable(tableName);
        using var connection = DbConnectionFactory.Create(ConnectionString);
        using var command = new MySqlCommand(sql, connection);
        if (parameters.Count > 0)
        {
            command.Parameters.AddRange(parameters.ToArray());
        }

        using var adapter = new MySqlDataAdapter(command);
        adapter.Fill(table);
        return table;
    }

    private static int ExecuteNonQuery(string sql, IReadOnlyCollection<MySqlParameter> parameters)
    {
        using var connection = DbConnectionFactory.Create(ConnectionString);
        using var command = new MySqlCommand(sql, connection);
        if (parameters.Count > 0)
        {
            command.Parameters.AddRange(parameters.ToArray());
        }

        connection.Open();
        return command.ExecuteNonQuery();
    }
}
