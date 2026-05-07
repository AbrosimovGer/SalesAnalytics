namespace SalesAnalytics.Models;

public sealed class CurrentUser
{
    public int UserId { get; init; }
    public string FullName { get; init; } = string.Empty;
    public string RoleName { get; init; } = string.Empty;
}
