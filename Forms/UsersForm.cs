using SalesAnalytics.Services;

namespace SalesAnalytics.Forms;

public partial class UsersForm : Form
{
    public UsersForm()
    {
        InitializeComponent();
    }

    private void UsersForm_Load(object? sender, EventArgs e)
    {
        dataGridViewUsers.DataSource = DataService.GetUsersTable();
        dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
}
