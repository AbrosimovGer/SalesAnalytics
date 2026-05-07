using SalesAnalytics.Services;

namespace SalesAnalytics.Forms;

public partial class ProductsForm : Form
{
    public ProductsForm()
    {
        InitializeComponent();
    }

    private void ProductsForm_Load(object? sender, EventArgs e)
    {
        dataGridViewProducts.DataSource = DataService.GetProductsTable();
        dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
}
