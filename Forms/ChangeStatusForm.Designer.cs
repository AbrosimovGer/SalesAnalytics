namespace SalesAnalytics.Forms;

partial class ChangeStatusForm
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblNewStatus = null!;
    private ComboBox cbNewStatus = null!;
    private Button btnApplyStatus = null!;

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
        lblNewStatus = new Label();
        cbNewStatus = new ComboBox();
        btnApplyStatus = new Button();
        SuspendLayout();
        // 
        // lblNewStatus
        // 
        lblNewStatus.AutoSize = true;
        lblNewStatus.Location = new Point(22, 20);
        lblNewStatus.Name = "lblNewStatus";
        lblNewStatus.Size = new Size(86, 15);
        lblNewStatus.TabIndex = 0;
        lblNewStatus.Text = "Новый статус:";
        // 
        // cbNewStatus
        // 
        cbNewStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cbNewStatus.FormattingEnabled = true;
        cbNewStatus.Location = new Point(22, 38);
        cbNewStatus.Name = "cbNewStatus";
        cbNewStatus.Size = new Size(300, 23);
        cbNewStatus.TabIndex = 1;
        // 
        // btnApplyStatus
        // 
        btnApplyStatus.Location = new Point(22, 76);
        btnApplyStatus.Name = "btnApplyStatus";
        btnApplyStatus.Size = new Size(300, 34);
        btnApplyStatus.TabIndex = 2;
        btnApplyStatus.Text = "Применить";
        btnApplyStatus.UseVisualStyleBackColor = true;
        btnApplyStatus.Click += btnApplyStatus_Click;
        // 
        // ChangeStatusForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(348, 132);
        Controls.Add(btnApplyStatus);
        Controls.Add(cbNewStatus);
        Controls.Add(lblNewStatus);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ChangeStatusForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Смена статуса заказа";
        ResumeLayout(false);
        PerformLayout();
    }
}
