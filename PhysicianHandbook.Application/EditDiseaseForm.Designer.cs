namespace PhysicianHandbook.Application;

partial class EditDiseaseForm
{
    private System.ComponentModel.IContainer components = null;
    private Label labelName;
    private TextBox textBoxName;
    private Label labelSymptoms;
    private TextBox textBoxSymptoms;
    private Label labelProcedures;
    private TextBox textBoxProcedures;
    private Label labelSeverity;
    private ComboBox comboBoxSeverity;
    private Label labelMedications;
    private CheckedListBox checkedListBoxMedications;
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
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        labelName = new Label();
        textBoxName = new TextBox();
        labelSymptoms = new Label();
        textBoxSymptoms = new TextBox();
        labelProcedures = new Label();
        textBoxProcedures = new TextBox();
        labelSeverity = new Label();
        comboBoxSeverity = new ComboBox();
        labelMedications = new Label();
        checkedListBoxMedications = new CheckedListBox();
        buttonOK = new Button();
        buttonCancel = new Button();
        SuspendLayout();
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Location = new Point(10, 20);
        labelName.Name = "labelName";
        labelName.Size = new Size(42, 15);
        labelName.TabIndex = 0;
        labelName.Text = "Назва:";
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(120, 17);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(250, 23);
        textBoxName.TabIndex = 1;
        // 
        // labelSymptoms
        // 
        labelSymptoms.AutoSize = true;
        labelSymptoms.Location = new Point(10, 60);
        labelSymptoms.Name = "labelSymptoms";
        labelSymptoms.Size = new Size(69, 15);
        labelSymptoms.TabIndex = 2;
        labelSymptoms.Text = "Симптоми:";
        // 
        // textBoxSymptoms
        // 
        textBoxSymptoms.Location = new Point(120, 57);
        textBoxSymptoms.Multiline = true;
        textBoxSymptoms.Name = "textBoxSymptoms";
        textBoxSymptoms.Size = new Size(250, 60);
        textBoxSymptoms.TabIndex = 3;
        // 
        // labelProcedures
        // 
        labelProcedures.AutoSize = true;
        labelProcedures.Location = new Point(10, 140);
        labelProcedures.Name = "labelProcedures";
        labelProcedures.Size = new Size(72, 15);
        labelProcedures.TabIndex = 4;
        labelProcedures.Text = "Процедури:";
        // 
        // textBoxProcedures
        // 
        textBoxProcedures.Location = new Point(120, 137);
        textBoxProcedures.Multiline = true;
        textBoxProcedures.Name = "textBoxProcedures";
        textBoxProcedures.Size = new Size(250, 60);
        textBoxProcedures.TabIndex = 5;
        // 
        // labelSeverity
        // 
        labelSeverity.AutoSize = true;
        labelSeverity.Location = new Point(10, 200);
        labelSeverity.Name = "labelSeverity";
        labelSeverity.Size = new Size(62, 15);
        labelSeverity.TabIndex = 6;
        labelSeverity.Text = "Тяжкість:";
        // 
        // comboBoxSeverity
        // 
        comboBoxSeverity.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxSeverity.FormattingEnabled = true;
        comboBoxSeverity.Location = new Point(120, 197);
        comboBoxSeverity.Name = "comboBoxSeverity";
        comboBoxSeverity.Size = new Size(250, 23);
        comboBoxSeverity.TabIndex = 7;
        // 
        // labelMedications
        // 
        labelMedications.AutoSize = true;
        labelMedications.Location = new Point(10, 240);
        labelMedications.Name = "labelMedications";
        labelMedications.Size = new Size(86, 15);
        labelMedications.TabIndex = 8;
        labelMedications.Text = "Медикаменти:";
        // 
        // checkedListBoxMedications
        // 
        checkedListBoxMedications.FormattingEnabled = true;
        checkedListBoxMedications.Location = new Point(120, 240);
        checkedListBoxMedications.Name = "checkedListBoxMedications";
        checkedListBoxMedications.Size = new Size(250, 124);
        checkedListBoxMedications.TabIndex = 9;
        // 
        // buttonOK
        // 
        buttonOK.Location = new Point(120, 400);
        buttonOK.Name = "buttonOK";
        buttonOK.Size = new Size(100, 40);
        buttonOK.TabIndex = 10;
        buttonOK.Text = "Зберегти";
        buttonOK.UseVisualStyleBackColor = true;
        buttonOK.Click += new System.EventHandler(buttonOK_Click);
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(270, 400);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(100, 40);
        buttonCancel.TabIndex = 11;
        buttonCancel.Text = "Відмінити";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += new System.EventHandler(buttonCancel_Click);
        // 
        // EditDiseaseForm
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(400, 460);
        Controls.Add(buttonCancel);
        Controls.Add(buttonOK);
        Controls.Add(checkedListBoxMedications);
        Controls.Add(labelMedications);
        Controls.Add(comboBoxSeverity);
        Controls.Add(labelSeverity);
        Controls.Add(textBoxProcedures);
        Controls.Add(labelProcedures);
        Controls.Add(textBoxSymptoms);
        Controls.Add(labelSymptoms);
        Controls.Add(textBoxName);
        Controls.Add(labelName);
        Name = "EditDiseaseForm";
        Text = "Редагувати Хворобу";
        ResumeLayout(false);
        PerformLayout();
    }
}