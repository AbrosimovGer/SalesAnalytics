namespace SalesAnalytics.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private static void OpenDialog(Form form)
    {
        using (form)
        {
            form.ShowDialog();
        }
    }

    private void menuItemOrders_Click(object? sender, EventArgs e) => OpenDialog(new OrdersForm());
    private void menuItemProducts_Click(object? sender, EventArgs e) => OpenDialog(new ProductsForm());
    private void menuItemClients_Click(object? sender, EventArgs e) => OpenDialog(new ClientsForm());
    private void menuItemReports_Click(object? sender, EventArgs e) => OpenDialog(new ReportsForm());
    private void menuItemUsers_Click(object? sender, EventArgs e) => OpenDialog(new UsersForm());
}
