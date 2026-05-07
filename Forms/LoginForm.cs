using SalesAnalytics.Helpers;
using SalesAnalytics.Services;

namespace SalesAnalytics.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
        BackColor = UiThemeHelper.Background;
        UiThemeHelper.ApplyButtonStyle(btnLogin);
    }

    private void btnLogin_Click(object? sender, EventArgs e)
    {
        var user = AuthService.ValidateCredentials(txtLogin.Text.Trim(), txtPassword.Text);
        if (user == null)
        {
            MessageBox.Show("Неверный логин или пароль.", "Ошибка входа",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        SessionService.SetUser(user);
        Hide();
        using var mainForm = new MainForm();
        mainForm.ShowDialog();
        Show();
    }
}
