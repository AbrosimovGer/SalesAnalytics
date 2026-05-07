namespace SalesAnalytics.Forms;

partial class ClientsForm
{
    private System.ComponentModel.IContainer? components = null;
    private DataGridView dataGridViewClients = null!;

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
        dataGridViewClients = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
        SuspendLayout();
        dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewClients.Dock = DockStyle.Fill;
        dataGridViewClients.Name = "dataGridViewClients";
        dataGridViewClients.TabIndex = 0;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dataGridViewClients);
        Name = "ClientsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Клиенты";
        Load += ClientsForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
        ResumeLayout(false);
    }
}
