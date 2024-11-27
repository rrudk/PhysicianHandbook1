namespace PhysicianHandbook.Application.Views;

partial class DiseaseView
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dataGridViewDiseases;
    private GroupBox groupBoxAddDisease;
    private Label labelName;
    private TextBox textBoxName;
    private Label labelSymptoms;
    private TextBox textBoxSymptoms;
    private Label labelProcedures;
    private TextBox textBoxProcedures;
    private Label labelMedications;
    private ListBox listBoxMedications;
    private Button buttonAddMedication;
    private DataGridView dataGridViewMedicationDetails;
    private Button buttonSaveDisease;
    private Button buttonRemoveMedication;
    private Label labelSeverity;
    private ComboBox comboBoxSeverity;

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
        dataGridViewDiseases = new DataGridView();
        groupBoxAddDisease = new GroupBox();
        buttonRemoveMedication = new Button();
        labelName = new Label();
        textBoxName = new TextBox();
        labelSymptoms = new Label();
        textBoxSymptoms = new TextBox();
        labelProcedures = new Label();
        textBoxProcedures = new TextBox();
        labelMedications = new Label();
        listBoxMedications = new ListBox();
        buttonAddMedication = new Button();
        dataGridViewMedicationDetails = new DataGridView();
        buttonSaveDisease = new Button();
        labelSeverity = new Label();
        comboBoxSeverity = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)dataGridViewDiseases).BeginInit();
        groupBoxAddDisease.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewMedicationDetails).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewDiseases
        // 
        dataGridViewDiseases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewDiseases.Location = new Point(10, 10);
        dataGridViewDiseases.MultiSelect = false;
        dataGridViewDiseases.Name = "dataGridViewDiseases";
        dataGridViewDiseases.RowHeadersWidth = 51;
        dataGridViewDiseases.RowTemplate.Height = 29;
        dataGridViewDiseases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewDiseases.Size = new Size(650, 630);
        dataGridViewDiseases.TabIndex = 0;
        // 
        // groupBoxAddDisease
        // 
        groupBoxAddDisease.Controls.Add(buttonRemoveMedication);
        groupBoxAddDisease.Controls.Add(labelName);
        groupBoxAddDisease.Controls.Add(textBoxName);
        groupBoxAddDisease.Controls.Add(labelSymptoms);
        groupBoxAddDisease.Controls.Add(textBoxSymptoms);
        groupBoxAddDisease.Controls.Add(labelProcedures);
        groupBoxAddDisease.Controls.Add(textBoxProcedures);
        groupBoxAddDisease.Controls.Add(labelMedications);
        groupBoxAddDisease.Controls.Add(listBoxMedications);
        groupBoxAddDisease.Controls.Add(buttonAddMedication);
        groupBoxAddDisease.Controls.Add(dataGridViewMedicationDetails);
        groupBoxAddDisease.Controls.Add(buttonSaveDisease);
        groupBoxAddDisease.Controls.Add(labelSeverity);
        groupBoxAddDisease.Controls.Add(comboBoxSeverity);
        groupBoxAddDisease.Location = new Point(677, 10);
        groupBoxAddDisease.Name = "groupBoxAddDisease";
        groupBoxAddDisease.Size = new Size(500, 630);
        groupBoxAddDisease.TabIndex = 1;
        groupBoxAddDisease.TabStop = false;
        groupBoxAddDisease.Text = "Додати Хворобу";
        // 
        // buttonRemoveMedication
        // 
        buttonRemoveMedication.Location = new Point(360, 276);
        buttonRemoveMedication.Name = "buttonRemoveMedication";
        buttonRemoveMedication.Size = new Size(130, 30);
        buttonRemoveMedication.TabIndex = 11;
        buttonRemoveMedication.Text = "Видалити";
        buttonRemoveMedication.UseVisualStyleBackColor = true;
        buttonRemoveMedication.Click += buttonRemoveMedication_Click;
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
        textBoxName.Location = new Point(150, 27);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(200, 23);
        textBoxName.TabIndex = 1;
        // 
        // labelSymptoms
        // 
        labelSymptoms.AutoSize = true;
        labelSymptoms.Location = new Point(10, 70);
        labelSymptoms.Name = "labelSymptoms";
        labelSymptoms.Size = new Size(69, 15);
        labelSymptoms.TabIndex = 2;
        labelSymptoms.Text = "Симптоми:";
        // 
        // textBoxSymptoms
        // 
        textBoxSymptoms.Location = new Point(150, 57);
        textBoxSymptoms.Multiline = true;
        textBoxSymptoms.Name = "textBoxSymptoms";
        textBoxSymptoms.Size = new Size(200, 60);
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
        textBoxProcedures.Location = new Point(150, 137);
        textBoxProcedures.Multiline = true;
        textBoxProcedures.Name = "textBoxProcedures";
        textBoxProcedures.Size = new Size(200, 60);
        textBoxProcedures.TabIndex = 5;
        // 
        // labelMedications
        // 
        labelMedications.AutoSize = true;
        labelMedications.Location = new Point(10, 236);
        labelMedications.Name = "labelMedications";
        labelMedications.Size = new Size(86, 15);
        labelMedications.TabIndex = 6;
        labelMedications.Text = "Медикаменти:";
        // 
        // listBoxMedications
        // 
        listBoxMedications.FormattingEnabled = true;
        listBoxMedications.ItemHeight = 15;
        listBoxMedications.Location = new Point(150, 236);
        listBoxMedications.Name = "listBoxMedications";
        listBoxMedications.SelectionMode = SelectionMode.MultiSimple;
        listBoxMedications.Size = new Size(200, 124);
        listBoxMedications.TabIndex = 7;
        // 
        // buttonAddMedication
        // 
        buttonAddMedication.Location = new Point(360, 236);
        buttonAddMedication.Name = "buttonAddMedication";
        buttonAddMedication.Size = new Size(130, 30);
        buttonAddMedication.TabIndex = 8;
        buttonAddMedication.Text = "Додати";
        buttonAddMedication.UseVisualStyleBackColor = true;
        buttonAddMedication.Click += buttonAddMedication_Click;
        // 
        // dataGridViewMedicationDetails
        // 
        dataGridViewMedicationDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewMedicationDetails.Location = new Point(10, 374);
        dataGridViewMedicationDetails.Name = "dataGridViewMedicationDetails";
        dataGridViewMedicationDetails.RowHeadersWidth = 51;
        dataGridViewMedicationDetails.RowTemplate.Height = 29;
        dataGridViewMedicationDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewMedicationDetails.Size = new Size(480, 180);
        dataGridViewMedicationDetails.TabIndex = 9;
        // 
        // buttonSaveDisease
        // 
        buttonSaveDisease.Location = new Point(150, 574);
        buttonSaveDisease.Name = "buttonSaveDisease";
        buttonSaveDisease.Size = new Size(200, 30);
        buttonSaveDisease.TabIndex = 10;
        buttonSaveDisease.Text = "Зберегти хворобу";
        buttonSaveDisease.UseVisualStyleBackColor = true;
        buttonSaveDisease.Click += buttonSaveDisease_Click;
        // 
        // labelSeverity
        // 
        labelSeverity.AutoSize = true;
        labelSeverity.Location = new Point(10, 210);
        labelSeverity.Name = "labelSeverity";
        labelSeverity.Size = new Size(57, 15);
        labelSeverity.TabIndex = 7;
        labelSeverity.Text = "Тяжкість:";
        // 
        // comboBoxSeverity
        // 
        comboBoxSeverity.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxSeverity.Location = new Point(150, 207);
        comboBoxSeverity.Name = "comboBoxSeverity";
        comboBoxSeverity.Size = new Size(200, 23);
        comboBoxSeverity.TabIndex = 8;
        // 
        // DiseaseView
        // 
        Controls.Add(dataGridViewDiseases);
        Controls.Add(groupBoxAddDisease);
        Name = "DiseaseView";
        Size = new Size(1214, 654);
        ((System.ComponentModel.ISupportInitialize)dataGridViewDiseases).EndInit();
        groupBoxAddDisease.ResumeLayout(false);
        groupBoxAddDisease.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewMedicationDetails).EndInit();
        ResumeLayout(false);
    }
}