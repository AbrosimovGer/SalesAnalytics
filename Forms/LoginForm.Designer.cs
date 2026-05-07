namespace SalesAnalytics.Forms;

partial class LoginForm
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private Label lblLogin = null!;
    private Label lblPassword = null!;
    private TextBox txtLogin = null!;
    private TextBox txtPassword = null!;
    private Button btnLogin = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblLogin = new Label();
        lblPassword = new Label();
        txtLogin = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitle.Location = new Point(106, 30);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(188, 30);
        lblTitle.Text = "SalesAnalytics вход";
        // 
        // lblLogin
        // 
        lblLogin.AutoSize = true;
        lblLogin.Location = new Point(62, 95);
        lblLogin.Name = "lblLogin";
        lblLogin.Size = new Size(43, 15);
        lblLogin.Text = "Логин:";
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(62, 146);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(53, 15);
        lblPassword.Text = "Пароль:";
        // 
        // txtLogin
        // 
        txtLogin.Location = new Point(62, 113);
        txtLogin.Name = "txtLogin";
        txtLogin.PlaceholderText = "Введите логин";
        txtLogin.Size = new Size(270, 23);
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(62, 164);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.PlaceholderText = "Введите пароль";
        txtPassword.Size = new Size(270, 23);
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(62, 212);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(270, 36);
        btnLogin.Text = "Войти";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 290);
        Controls.Add(btnLogin);
        Controls.Add(txtPassword);
        Controls.Add(txtLogin);
        Controls.Add(lblPassword);
        Controls.Add(lblLogin);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Авторизация";
        ResumeLayout(false);
        PerformLayout();
    }
}
