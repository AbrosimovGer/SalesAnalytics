using SalesAnalytics.Services;

namespace SalesAnalytics.Forms;

public partial class NewOrderForm : Form
{
    public NewOrderForm()
    {
        InitializeComponent();
        LoadLookups();
    }

    private void btnCreate_Click(object? sender, EventArgs e)
    {
        if (cbClient.SelectedValue == null || cbPayment.SelectedValue == null)
        {
            MessageBox.Show("Выберите клиента и метод оплаты.", "Проверка данных",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var clientId = Convert.ToInt32(cbClient.SelectedValue);
        var paymentMethod = cbPayment.SelectedValue?.ToString();
        if (string.IsNullOrWhiteSpace(paymentMethod))
        {
            MessageBox.Show("Не выбран способ оплаты.", "Проверка данных",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var managerId = SessionService.CurrentUser?.UserId ?? 0;
        if (managerId == 0)
        {
            MessageBox.Show("Не определен авторизованный пользователь.", "Ошибка сессии",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataService.AddOrder(clientId, paymentMethod, txtNotes.Text.Trim(), managerId);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void LoadLookups()
    {
        cbClient.DataSource = DataService.GetClientsLookup();
        cbClient.DisplayMember = "full_name";
        cbClient.ValueMember = "client_id";

        cbPayment.DataSource = DataService.GetPaymentsLookup();
        cbPayment.DisplayMember = "payment_method";
        cbPayment.ValueMember = "payment_method";
    }
}
