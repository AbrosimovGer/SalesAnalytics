namespace SalesAnalytics.Forms;

partial class NewOrderForm
{
    private System.ComponentModel.IContainer? components = null;
    private ComboBox cbClient = null!;
    private ComboBox cbPayment = null!;
    private TextBox txtNotes = null!;
    private Button btnCreate = null!;
    private Label lblClient = null!;
    private Label lblPayment = null!;
    private Label lblNotes = null!;

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
        cbClient = new ComboBox();
        cbPayment = new ComboBox();
        txtNotes = new TextBox();
        btnCreate = new Button();
        lblClient = new Label();
        lblPayment = new Label();
        lblNotes = new Label();
        SuspendLayout();
        // 
        // cbClient
        // 
        cbClient.DropDownStyle = ComboBoxStyle.DropDownList;
        cbClient.FormattingEnabled = true;
        cbClient.Location = new Point(22, 44);
        cbClient.Name = "cbClient";
        cbClient.Size = new Size(320, 23);
        // 
        // cbPayment
        // 
        cbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
        cbPayment.FormattingEnabled = true;
        cbPayment.Location = new Point(22, 100);
        cbPayment.Name = "cbPayment";
        cbPayment.Size = new Size(320, 23);
        // 
        // txtNotes
        // 
        txtNotes.Location = new Point(22, 157);
        txtNotes.Multiline = true;
        txtNotes.Name = "txtNotes";
        txtNotes.Size = new Size(320, 90);
        // 
        // btnCreate
        // 
        btnCreate.Location = new Point(22, 267);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new Size(320, 36);
        btnCreate.Text = "Создать заказ";
        btnCreate.UseVisualStyleBackColor = true;
        btnCreate.Click += btnCreate_Click;
        // 
        // labels
        // 
        lblClient.AutoSize = true;
        lblClient.Location = new Point(22, 26);
        lblClient.Name = "lblClient";
        lblClient.Size = new Size(51, 15);
        lblClient.Text = "Клиент:";

        lblPayment.AutoSize = true;
        lblPayment.Location = new Point(22, 82);
        lblPayment.Name = "lblPayment";
        lblPayment.Size = new Size(53, 15);
        lblPayment.Text = "Оплата:";

        lblNotes.AutoSize = true;
        lblNotes.Location = new Point(22, 139);
        lblNotes.Name = "lblNotes";
        lblNotes.Size = new Size(92, 15);
        lblNotes.Text = "Комментарий:";
        // 
        // NewOrderForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(364, 326);
        Controls.Add(lblNotes);
        Controls.Add(lblPayment);
        Controls.Add(lblClient);
        Controls.Add(btnCreate);
        Controls.Add(txtNotes);
        Controls.Add(cbPayment);
        Controls.Add(cbClient);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "NewOrderForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Новый заказ";
        ResumeLayout(false);
        PerformLayout();
    }
}
