namespace SalesAnalytics.Forms;

partial class ProductsForm
{
    private System.ComponentModel.IContainer? components = null;
    private DataGridView dataGridViewProducts = null!;

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
        dataGridViewProducts = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        SuspendLayout();
        dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewProducts.Dock = DockStyle.Fill;
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.TabIndex = 0;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dataGridViewProducts);
        Name = "ProductsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Товары";
        Load += ProductsForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
        ResumeLayout(false);
    }
}
