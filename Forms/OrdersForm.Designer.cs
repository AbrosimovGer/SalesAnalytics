namespace SalesAnalytics.Forms;

partial class OrdersForm
{
    private System.ComponentModel.IContainer? components = null;
    private DataGridView dataGridViewOrders = null!;
    private Button btnNewOrder = null!;
    private Button btnDeleteOrder = null!;
    private Button btnChangeStatus = null!;
    private ComboBox cbStatusFilter = null!;
    private Label lblFilter = null!;
    private Button btnRefresh = null!;

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
        dataGridViewOrders = new DataGridView();
        btnNewOrder = new Button();
        btnDeleteOrder = new Button();
        btnChangeStatus = new Button();
        cbStatusFilter = new ComboBox();
        lblFilter = new Label();
        btnRefresh = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewOrders
        // 
        dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewOrders.Location = new Point(12, 53);
        dataGridViewOrders.Name = "dataGridViewOrders";
        dataGridViewOrders.Size = new Size(960, 430);
        dataGridViewOrders.TabIndex = 0;
        // 
        // btnNewOrder
        // 
        btnNewOrder.Location = new Point(12, 500);
        btnNewOrder.Name = "btnNewOrder";
        btnNewOrder.Size = new Size(150, 35);
        btnNewOrder.Text = "Новый заказ";
        btnNewOrder.UseVisualStyleBackColor = true;
        btnNewOrder.Click += btnNewOrder_Click;
        // 
        // btnDeleteOrder
        // 
        btnDeleteOrder.Location = new Point(168, 500);
        btnDeleteOrder.Name = "btnDeleteOrder";
        btnDeleteOrder.Size = new Size(150, 35);
        btnDeleteOrder.Text = "Удалить";
        btnDeleteOrder.UseVisualStyleBackColor = true;
        btnDeleteOrder.Click += btnDelete_Click;
        // 
        // btnChangeStatus
        // 
        btnChangeStatus.Location = new Point(324, 500);
        btnChangeStatus.Name = "btnChangeStatus";
        btnChangeStatus.Size = new Size(180, 35);
        btnChangeStatus.Text = "Сменить статус";
        btnChangeStatus.UseVisualStyleBackColor = true;
        btnChangeStatus.Click += btnChangeStatus_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(510, 500);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(150, 35);
        btnRefresh.Text = "Обновить";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // cbStatusFilter
        // 
        cbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cbStatusFilter.FormattingEnabled = true;
        cbStatusFilter.Location = new Point(116, 18);
        cbStatusFilter.Name = "cbStatusFilter";
        cbStatusFilter.Size = new Size(220, 23);
        cbStatusFilter.SelectedIndexChanged += cbStatusFilter_SelectedIndexChanged;
        // 
        // lblFilter
        // 
        lblFilter.AutoSize = true;
        lblFilter.Location = new Point(12, 21);
        lblFilter.Name = "lblFilter";
        lblFilter.Size = new Size(98, 15);
        lblFilter.Text = "Статус фильтра:";
        // 
        // OrdersForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(984, 561);
        Controls.Add(lblFilter);
        Controls.Add(cbStatusFilter);
        Controls.Add(btnRefresh);
        Controls.Add(btnChangeStatus);
        Controls.Add(btnDeleteOrder);
        Controls.Add(btnNewOrder);
        Controls.Add(dataGridViewOrders);
        Name = "OrdersForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Заказы";
        Load += OrdersForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
