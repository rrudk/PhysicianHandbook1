namespace PhysicianHandbook.Application.Views;

partial class MedicationView
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dataGridViewMedications;
    private ContextMenuStrip contextMenuMedications;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem deleteToolStripMenuItem;
    private GroupBox groupBoxAddMedication;
    private Label labelName;
    private TextBox textBoxName;
    private Label labelAmount;
    private NumericUpDown numericUpDownAmount;
    private Label labelPrice;
    private NumericUpDown numericUpDownPrice;
    private Label labelAlternatives;
    private CheckedListBox checkedListBoxAlternatives;
    private Button buttonAddMedication;

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
        components = new System.ComponentModel.Container();
        dataGridViewMedications = new DataGridView();
        contextMenuMedications = new ContextMenuStrip(components);
        editToolStripMenuItem = new ToolStripMenuItem();
        deleteToolStripMenuItem = new ToolStripMenuItem();
        groupBoxAddMedication = new GroupBox();
        labelName = new Label();
        textBoxName = new TextBox();
        labelAmount = new Label();
        numericUpDownAmount = new NumericUpDown();
        labelPrice = new Label();
        numericUpDownPrice = new NumericUpDown();
        labelAlternatives = new Label();
        checkedListBoxAlternatives = new CheckedListBox();
        buttonAddMedication = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewMedications).BeginInit();
        contextMenuMedications.SuspendLayout();
        groupBoxAddMedication.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewMedications
        // 
        dataGridViewMedications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewMedications.ContextMenuStrip = contextMenuMedications;
        dataGridViewMedications.Location = new Point(10, 10);
        dataGridViewMedications.Name = "dataGridViewMedications";
        dataGridViewMedications.RowHeadersWidth = 51;
        dataGridViewMedications.RowTemplate.Height = 29;
        dataGridViewMedications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewMedications.Size = new Size(700, 500);
        dataGridViewMedications.TabIndex = 0;
        // 
        // contextMenuMedications
        // 
        contextMenuMedications.ImageScalingSize = new Size(20, 20);
        contextMenuMedications.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
        contextMenuMedications.Name = "contextMenuMedications";
        contextMenuMedications.Size = new Size(135, 48);
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new Size(134, 22);
        editToolStripMenuItem.Text = "Редагувати";
        editToolStripMenuItem.Click += editToolStripMenuItem_Click;
        // 
        // deleteToolStripMenuItem
        // 
        deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        deleteToolStripMenuItem.Size = new Size(134, 22);
        deleteToolStripMenuItem.Text = "Видалити";
        deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
        // 
        // groupBoxAddMedication
        // 
        groupBoxAddMedication.Controls.Add(labelName);
        groupBoxAddMedication.Controls.Add(textBoxName);
        groupBoxAddMedication.Controls.Add(labelAmount);
        groupBoxAddMedication.Controls.Add(numericUpDownAmount);
        groupBoxAddMedication.Controls.Add(labelPrice);
        groupBoxAddMedication.Controls.Add(numericUpDownPrice);
        groupBoxAddMedication.Controls.Add(labelAlternatives);
        groupBoxAddMedication.Controls.Add(checkedListBoxAlternatives);
        groupBoxAddMedication.Controls.Add(buttonAddMedication);
        groupBoxAddMedication.Location = new Point(720, 10);
        groupBoxAddMedication.Name = "groupBoxAddMedication";
        groupBoxAddMedication.Size = new Size(333, 500);
        groupBoxAddMedication.TabIndex = 1;
        groupBoxAddMedication.TabStop = false;
        groupBoxAddMedication.Text = "Додати Медикамент";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Location = new Point(10, 30);
        labelName.Name = "labelName";
        labelName.Size = new Size(42, 15);
        labelName.TabIndex = 0;
        labelName.Text = "Назва:";
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(119, 27);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(180, 23);
        textBoxName.TabIndex = 1;
        // 
        // labelAmount
        // 
        labelAmount.AutoSize = true;
        labelAmount.Location = new Point(10, 70);
        labelAmount.Name = "labelAmount";
        labelAmount.Size = new Size(59, 15);
        labelAmount.TabIndex = 2;
        labelAmount.Text = "Кількість:";
        // 
        // numericUpDownAmount
        // 
        numericUpDownAmount.Location = new Point(119, 68);
        numericUpDownAmount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numericUpDownAmount.Name = "numericUpDownAmount";
        numericUpDownAmount.Size = new Size(180, 23);
        numericUpDownAmount.TabIndex = 3;
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Location = new Point(10, 110);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(35, 15);
        labelPrice.TabIndex = 4;
        labelPrice.Text = "Ціна:";
        // 
        // numericUpDownPrice
        // 
        numericUpDownPrice.DecimalPlaces = 2;
        numericUpDownPrice.Location = new Point(119, 108);
        numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numericUpDownPrice.Name = "numericUpDownPrice";
        numericUpDownPrice.Size = new Size(180, 23);
        numericUpDownPrice.TabIndex = 5;
        // 
        // labelAlternatives
        // 
        labelAlternatives.AutoSize = true;
        labelAlternatives.Location = new Point(10, 150);
        labelAlternatives.Name = "labelAlternatives";
        labelAlternatives.Size = new Size(87, 15);
        labelAlternatives.TabIndex = 6;
        labelAlternatives.Text = "Альтернативи:";
        // 
        // checkedListBoxAlternatives
        // 
        checkedListBoxAlternatives.FormattingEnabled = true;
        checkedListBoxAlternatives.Location = new Point(119, 150);
        checkedListBoxAlternatives.Name = "checkedListBoxAlternatives";
        checkedListBoxAlternatives.Size = new Size(180, 112);
        checkedListBoxAlternatives.TabIndex = 7;
        // 
        // buttonAddMedication
        // 
        buttonAddMedication.Location = new Point(119, 290);
        buttonAddMedication.Name = "buttonAddMedication";
        buttonAddMedication.Size = new Size(180, 40);
        buttonAddMedication.TabIndex = 8;
        buttonAddMedication.Text = "Додати Медикамент";
        buttonAddMedication.UseVisualStyleBackColor = true;
        buttonAddMedication.Click += buttonAddMedication_Click;
        // 
        // MedicationView
        // 
        AutoScaleMode = AutoScaleMode.None;
        Controls.Add(dataGridViewMedications);
        Controls.Add(groupBoxAddMedication);
        Name = "MedicationView";
        Size = new Size(1056, 520);
        ((System.ComponentModel.ISupportInitialize)dataGridViewMedications).EndInit();
        contextMenuMedications.ResumeLayout(false);
        groupBoxAddMedication.ResumeLayout(false);
        groupBoxAddMedication.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
        ResumeLayout(false);
    }
}