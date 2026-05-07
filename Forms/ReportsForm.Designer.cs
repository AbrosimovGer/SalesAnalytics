namespace SalesAnalytics.Forms;

partial class ReportsForm
{
    private System.ComponentModel.IContainer? components = null;
    private DataGridView dataGridViewReports = null!;

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
        dataGridViewReports = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
        SuspendLayout();
        dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewReports.Dock = DockStyle.Fill;
        dataGridViewReports.Name = "dataGridViewReports";
        dataGridViewReports.RowTemplate.Height = 25;
        dataGridViewReports.TabIndex = 0;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dataGridViewReports);
        Name = "ReportsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Отчеты";
        Load += ReportsForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
        ResumeLayout(false);
    }
}
