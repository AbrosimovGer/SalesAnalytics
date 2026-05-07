namespace SalesAnalytics.Forms;

partial class UsersForm
{
    private System.ComponentModel.IContainer? components = null;
    private DataGridView dataGridViewUsers = null!;

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
        dataGridViewUsers = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
        SuspendLayout();
        dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewUsers.Dock = DockStyle.Fill;
        dataGridViewUsers.Name = "dataGridViewUsers";
        dataGridViewUsers.TabIndex = 0;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dataGridViewUsers);
        Name = "UsersForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Пользователи";
        Load += UsersForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
        ResumeLayout(false);
    }
}
