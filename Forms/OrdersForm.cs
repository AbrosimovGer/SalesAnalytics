using SalesAnalytics.Services;
using System.Data;

namespace SalesAnalytics.Forms;

public partial class OrdersForm : Form
{
    private const string AllStatusesCaption = "Все";

    public OrdersForm()
    {
        InitializeComponent();
    }

    private void OrdersForm_Load(object? sender, EventArgs e)
    {
        LoadStatuses();
        LoadOrders();
    }

    private void cbStatusFilter_SelectedIndexChanged(object? sender, EventArgs e)
    {
        LoadOrders();
    }

    private void btnNewOrder_Click(object? sender, EventArgs e)
    {
        using var form = new NewOrderForm();
        if (form.ShowDialog() == DialogResult.OK)
        {
            LoadOrders();
        }
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (!TryGetCurrentOrderId(out var orderId))
        {
            return;
        }

        var confirmResult = MessageBox.Show(
            $"Удалить заказ №{orderId}?",
            "Подтверждение удаления",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirmResult != DialogResult.Yes)
        {
            return;
        }

        DataService.DeleteOrder(orderId);
        LoadOrders();
    }

    private void btnChangeStatus_Click(object? sender, EventArgs e)
    {
        if (!TryGetCurrentOrderId(out var orderId))
        {
            return;
        }

        var currentStatus = dataGridViewOrders.CurrentRow?.Cells["status"].Value?.ToString();
        var statuses = DataService.GetStatuses()
            .AsEnumerable()
            .Select(r => r.Field<string>("status") ?? string.Empty)
            .Where(s => !string.Equals(s, AllStatusesCaption, StringComparison.OrdinalIgnoreCase))
            .ToList();

        using var form = new ChangeStatusForm(statuses, currentStatus);
        if (form.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        DataService.ChangeOrderStatus(orderId, form.SelectedStatus);
        LoadOrders();
    }

    private void btnRefresh_Click(object? sender, EventArgs e)
    {
        LoadOrders();
    }

    private void LoadOrders()
    {
        var statusFilter = cbStatusFilter.SelectedValue?.ToString();
        dataGridViewOrders.DataSource = DataService.GetOrdersTable(statusFilter);
        dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void LoadStatuses()
    {
        var statusTable = DataService.GetStatuses();
        var allRow = statusTable.NewRow();
        allRow["status"] = AllStatusesCaption;
        statusTable.Rows.InsertAt(allRow, 0);

        cbStatusFilter.DataSource = statusTable;
        cbStatusFilter.DisplayMember = "status";
        cbStatusFilter.ValueMember = "status";
    }

    private bool TryGetCurrentOrderId(out int orderId)
    {
        orderId = 0;
        var value = dataGridViewOrders.CurrentRow?.Cells["order_id"].Value;
        if (value == null)
        {
            return false;
        }

        return int.TryParse(value.ToString(), out orderId);
    }
}
