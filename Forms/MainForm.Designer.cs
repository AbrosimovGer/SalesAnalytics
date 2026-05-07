namespace SalesAnalytics.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private MenuStrip menuStripMain = null!;
    private ToolStripMenuItem menuItemOrders = null!;
    private ToolStripMenuItem menuItemProducts = null!;
    private ToolStripMenuItem menuItemClients = null!;
    private ToolStripMenuItem menuItemReports = null!;
    private ToolStripMenuItem menuItemUsers = null!;
    private Label lblWelcome = null!;

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
        menuStripMain = new MenuStrip();
        menuItemOrders = new ToolStripMenuItem();
        menuItemProducts = new ToolStripMenuItem();
        menuItemClients = new ToolStripMenuItem();
        menuItemReports = new ToolStripMenuItem();
        menuItemUsers = new ToolStripMenuItem();
        lblWelcome = new Label();
        menuStripMain.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.Items.AddRange([menuItemOrders, menuItemProducts, menuItemClients, menuItemReports, menuItemUsers]);
        menuStripMain.Location = new Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Size = new Size(900, 24);
        // 
        // menu items
        // 
        menuItemOrders.Name = "menuItemOrders";
        menuItemOrders.Size = new Size(61, 20);
        menuItemOrders.Text = "Заказы";
        menuItemOrders.Click += menuItemOrders_Click;

        menuItemProducts.Name = "menuItemProducts";
        menuItemProducts.Size = new Size(64, 20);
        menuItemProducts.Text = "Товары";
        menuItemProducts.Click += menuItemProducts_Click;

        menuItemClients.Name = "menuItemClients";
        menuItemClients.Size = new Size(67, 20);
        menuItemClients.Text = "Клиенты";
        menuItemClients.Click += menuItemClients_Click;

        menuItemReports.Name = "menuItemReports";
        menuItemReports.Size = new Size(67, 20);
        menuItemReports.Text = "Отчеты";
        menuItemReports.Click += menuItemReports_Click;

        menuItemUsers.Name = "menuItemUsers";
        menuItemUsers.Size = new Size(97, 20);
        menuItemUsers.Text = "Пользователи";
        menuItemUsers.Click += menuItemUsers_Click;
        // 
        // lblWelcome
        // 
        lblWelcome.Dock = DockStyle.Fill;
        lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
        lblWelcome.Location = new Point(0, 24);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(900, 476);
        lblWelcome.Text = "SalesAnalytics\nГлавное меню";
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 500);
        Controls.Add(lblWelcome);
        Controls.Add(menuStripMain);
        MainMenuStrip = menuStripMain;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SalesAnalytics";
        menuStripMain.ResumeLayout(false);
        menuStripMain.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
