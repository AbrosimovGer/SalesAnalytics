using SalesAnalytics.Models;

namespace SalesAnalytics.Services;

public static class SessionService
{
    public static CurrentUser? CurrentUser { get; private set; }

    public static void SetUser(CurrentUser user)
    {
        CurrentUser = user;
    }
}
