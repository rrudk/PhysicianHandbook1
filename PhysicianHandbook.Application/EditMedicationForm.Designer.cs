namespace PhysicianHandbook.Application;

partial class EditMedicationForm
{
    private System.ComponentModel.IContainer components = null;
    private Label labelName;
    private TextBox textBoxName;
    private Label labelAmount;
    private NumericUpDown numericUpDownAmount;
    private Label labelPrice;
    private NumericUpDown numericUpDownPrice;
    private Label labelAlternatives;
    private CheckedListBox checkedListBoxAlternatives;
    private Button buttonOK;
    private Button buttonCancel;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.labelName = new System.Windows.Forms.Label();
        this.textBoxName = new System.Windows.Forms.TextBox();
        this.labelAmount = new System.Windows.Forms.Label();
        this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
        this.labelPrice = new System.Windows.Forms.Label();
        this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
        this.labelAlternatives = new System.Windows.Forms.Label();
        this.checkedListBoxAlternatives = new System.Windows.Forms.CheckedListBox();
        this.buttonOK = new System.Windows.Forms.Button();
        this.buttonCancel = new System.Windows.Forms.Button();
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
        this.SuspendLayout();
        // 
        // labelName
        // 
        this.labelName.AutoSize = true;
        this.labelName.Location = new System.Drawing.Point(10, 20);
        this.labelName.Name = "labelName";
        this.labelName.Size = new System.Drawing.Size(63, 20);
        this.labelName.TabIndex = 0;
        this.labelName.Text = "Назва:";
        // 
        // textBoxName
        // 
        this.textBoxName.Location = new System.Drawing.Point(120, 17);
        this.textBoxName.Name = "textBoxName";
        this.textBoxName.Size = new System.Drawing.Size(250, 27);
        this.textBoxName.TabIndex = 1;
        // 
        // labelAmount
        // 
        this.labelAmount.AutoSize = true;
        this.labelAmount.Location = new System.Drawing.Point(10, 60);
        this.labelAmount.Name = "labelAmount";
        this.labelAmount.Size = new System.Drawing.Size(60, 20);
        this.labelAmount.TabIndex = 2;
        this.labelAmount.Text = "Кількість:";
        // 
        // numericUpDownAmount
        // 
        this.numericUpDownAmount.Location = new System.Drawing.Point(120, 58);
        this.numericUpDownAmount.Maximum = new decimal(new int[] {
                100000,
                0,
                0,
                0});
        this.numericUpDownAmount.Name = "numericUpDownAmount";
        this.numericUpDownAmount.Size = new System.Drawing.Size(250, 27);
        this.numericUpDownAmount.TabIndex = 3;
        // 
        // labelPrice
        // 
        this.labelPrice.AutoSize = true;
        this.labelPrice.Location = new System.Drawing.Point(10, 100);
        this.labelPrice.Name = "labelPrice";
        this.labelPrice.Size = new System.Drawing.Size(45, 20);
        this.labelPrice.TabIndex = 4;
        this.labelPrice.Text = "Ціна:";
        // 
        // numericUpDownPrice
        // 
        this.numericUpDownPrice.DecimalPlaces = 2;
        this.numericUpDownPrice.Location = new System.Drawing.Point(120, 98);
        this.numericUpDownPrice.Maximum = new decimal(new int[] {
                100000,
                0,
                0,
                0});
        this.numericUpDownPrice.Name = "numericUpDownPrice";
        this.numericUpDownPrice.Size = new System.Drawing.Size(250, 27);
        this.numericUpDownPrice.TabIndex = 5;
        // 
        // labelAlternatives
        // 
        this.labelAlternatives.AutoSize = true;
        this.labelAlternatives.Location = new System.Drawing.Point(10, 140);
        this.labelAlternatives.Name = "labelAlternatives";
        this.labelAlternatives.Size = new System.Drawing.Size(119, 20);
        this.labelAlternatives.TabIndex = 6;
        this.labelAlternatives.Text = "Альтернативи:";
        // 
        // checkedListBoxAlternatives
        // 
        this.checkedListBoxAlternatives.FormattingEnabled = true;
        this.checkedListBoxAlternatives.Location = new System.Drawing.Point(120, 140);
        this.checkedListBoxAlternatives.Name = "checkedListBoxAlternatives";
        this.checkedListBoxAlternatives.Size = new System.Drawing.Size(250, 124);
        this.checkedListBoxAlternatives.TabIndex = 7;
        // 
        // buttonOK
        // 
        this.buttonOK.Location = new System.Drawing.Point(120, 290);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new System.Drawing.Size(100, 40);
        this.buttonOK.TabIndex = 8;
        this.buttonOK.Text = "Зберегти";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
        // 
        // buttonCancel
        // 
        this.buttonCancel.Location = new System.Drawing.Point(270, 290);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new System.Drawing.Size(100, 40);
        this.buttonCancel.TabIndex = 9;
        this.buttonCancel.Text = "Відмінити";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
        // 
        // EditMedicationForm
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.ClientSize = new System.Drawing.Size(400, 350);
        this.Controls.Add(this.buttonCancel);
        this.Controls.Add(this.buttonOK);
        this.Controls.Add(this.checkedListBoxAlternatives);
        this.Controls.Add(this.labelAlternatives);
        this.Controls.Add(this.numericUpDownPrice);
        this.Controls.Add(this.labelPrice);
        this.Controls.Add(this.numericUpDownAmount);
        this.Controls.Add(this.labelAmount);
        this.Controls.Add(this.textBoxName);
        this.Controls.Add(this.labelName);
        this.Name = "EditMedicationForm";
        this.Text = "Редагувати Медикамент";
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}