using SalesAnalytics.Services;

namespace SalesAnalytics.Forms;

public partial class ClientsForm : Form
{
    public ClientsForm()
    {
        InitializeComponent();
    }

    private void ClientsForm_Load(object? sender, EventArgs e)
    {
        dataGridViewClients.DataSource = DataService.GetClientsTable();
        dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
}
