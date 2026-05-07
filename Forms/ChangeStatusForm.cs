namespace SalesAnalytics.Forms;

public partial class ChangeStatusForm : Form
{
    public string SelectedStatus => cbNewStatus.SelectedValue?.ToString() ?? string.Empty;

    public ChangeStatusForm(IEnumerable<string> statuses, string? currentStatus)
    {
        InitializeComponent();

        var list = statuses
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();

        cbNewStatus.DataSource = list;
        if (!string.IsNullOrWhiteSpace(currentStatus) && list.Contains(currentStatus))
        {
            cbNewStatus.SelectedItem = currentStatus;
        }
    }

    private void btnApplyStatus_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(SelectedStatus))
        {
            MessageBox.Show("Выберите статус.", "Изменение статуса", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DialogResult = DialogResult.OK;
        Close();
    }
}
