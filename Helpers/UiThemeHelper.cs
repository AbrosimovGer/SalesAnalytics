namespace SalesAnalytics.Helpers;

public static class UiThemeHelper
{
    public static Color Accent => Color.FromArgb(37, 99, 235);
    public static Color Background => Color.FromArgb(245, 247, 250);

    public static void ApplyButtonStyle(Button button)
    {
        button.BackColor = Accent;
        button.ForeColor = Color.White;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
    }
}
