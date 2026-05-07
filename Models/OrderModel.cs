namespace SalesAnalytics.Models;

public sealed class OrderModel
{
    public int Id { get; set; }
    public string Client { get; set; } = string.Empty;
    public string Product { get; set; } = string.Empty;
    public string Payment { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public decimal Total { get; set; }
    public DateTime Date { get; set; }
    public string Notes { get; set; } = string.Empty;
}
