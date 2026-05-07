using SalesAnalytics.Services;

namespace SalesAnalytics.Forms;

public partial class ReportsForm : Form
{
    public ReportsForm()
    {
        InitializeComponent();
    }

    private void ReportsForm_Load(object? sender, EventArgs e)
    {
        dataGridViewReports.DataSource = DataService.GetReportsTable();
        dataGridViewReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
}
