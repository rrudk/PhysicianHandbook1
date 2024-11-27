namespace PhysicianHandbook.Application.Views;

partial class PrescriptionView
{
    private System.ComponentModel.IContainer components = null;

    private SplitContainer splitContainerMain;
    private Label labelPatientFirstName;
    private TextBox textBoxPatientFirstName;
    private Label labelPatientLastName;
    private TextBox textBoxPatientLastName;
    private Label labelDisease;
    private ComboBox comboBoxDisease;
    private Label labelAdditionalMedications;
    private ListBox listBoxAdditionalMedications;
    private Label labelDateOfIllness;
    private DateTimePicker dateTimePickerIllness;
    private Label labelDateOfRecovery;
    private DateTimePicker dateTimePickerRecovery;
    private Label labelDoctorName;
    private TextBox textBoxDoctorName;
    private Button buttonSavePrescription;
    private DataGridView dataGridViewPrescriptions;

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
        splitContainerMain = new SplitContainer();
        labelPatientFirstName = new Label();
        textBoxPatientFirstName = new TextBox();
        labelPatientLastName = new Label();
        textBoxPatientLastName = new TextBox();
        labelDisease = new Label();
        comboBoxDisease = new ComboBox();
        labelAdditionalMedications = new Label();
        listBoxAdditionalMedications = new ListBox();
        labelDateOfIllness = new Label();
        dateTimePickerIllness = new DateTimePicker();
        labelDateOfRecovery = new Label();
        dateTimePickerRecovery = new DateTimePicker();
        labelDoctorName = new Label();
        textBoxDoctorName = new TextBox();
        buttonSavePrescription = new Button();
        dataGridViewPrescriptions = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
        splitContainerMain.Panel1.SuspendLayout();
        splitContainerMain.Panel2.SuspendLayout();
        splitContainerMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPrescriptions).BeginInit();
        SuspendLayout();
        // 
        // splitContainerMain
        // 
        splitContainerMain.Dock = DockStyle.Fill;
        splitContainerMain.Location = new Point(0, 0);
        splitContainerMain.Name = "splitContainerMain";
        // 
        // splitContainerMain.Panel1
        // 
        splitContainerMain.Panel1.Controls.Add(labelPatientFirstName);
        splitContainerMain.Panel1.Controls.Add(textBoxPatientFirstName);
        splitContainerMain.Panel1.Controls.Add(labelPatientLastName);
        splitContainerMain.Panel1.Controls.Add(textBoxPatientLastName);
        splitContainerMain.Panel1.Controls.Add(labelDisease);
        splitContainerMain.Panel1.Controls.Add(comboBoxDisease);
        splitContainerMain.Panel1.Controls.Add(labelAdditionalMedications);
        splitContainerMain.Panel1.Controls.Add(listBoxAdditionalMedications);
        splitContainerMain.Panel1.Controls.Add(labelDateOfIllness);
        splitContainerMain.Panel1.Controls.Add(dateTimePickerIllness);
        splitContainerMain.Panel1.Controls.Add(labelDateOfRecovery);
        splitContainerMain.Panel1.Controls.Add(dateTimePickerRecovery);
        splitContainerMain.Panel1.Controls.Add(labelDoctorName);
        splitContainerMain.Panel1.Controls.Add(textBoxDoctorName);
        splitContainerMain.Panel1.Controls.Add(buttonSavePrescription);
        // 
        // splitContainerMain.Panel2
        // 
        splitContainerMain.Panel2.Controls.Add(dataGridViewPrescriptions);
        splitContainerMain.Size = new Size(1250, 650);
        splitContainerMain.SplitterDistance = 400;
        splitContainerMain.TabIndex = 0;
        // 
        // labelPatientFirstName
        // 
        labelPatientFirstName.AutoSize = true;
        labelPatientFirstName.Location = new Point(20, 20);
        labelPatientFirstName.Name = "labelPatientFirstName";
        labelPatientFirstName.Size = new Size(81, 15);
        labelPatientFirstName.TabIndex = 0;
        labelPatientFirstName.Text = "Ім'я пацієнта:";
        // 
        // textBoxPatientFirstName
        // 
        textBoxPatientFirstName.Location = new Point(188, 14);
        textBoxPatientFirstName.Name = "textBoxPatientFirstName";
        textBoxPatientFirstName.Size = new Size(200, 23);
        textBoxPatientFirstName.TabIndex = 1;
        // 
        // labelPatientLastName
        // 
        labelPatientLastName.AutoSize = true;
        labelPatientLastName.Location = new Point(20, 60);
        labelPatientLastName.Name = "labelPatientLastName";
        labelPatientLastName.Size = new Size(114, 15);
        labelPatientLastName.TabIndex = 2;
        labelPatientLastName.Text = "Прізвище пацієнта:";
        // 
        // textBoxPatientLastName
        // 
        textBoxPatientLastName.Location = new Point(188, 54);
        textBoxPatientLastName.Name = "textBoxPatientLastName";
        textBoxPatientLastName.Size = new Size(200, 23);
        textBoxPatientLastName.TabIndex = 3;
        // 
        // labelDisease
        // 
        labelDisease.AutoSize = true;
        labelDisease.Location = new Point(20, 100);
        labelDisease.Name = "labelDisease";
        labelDisease.Size = new Size(57, 15);
        labelDisease.TabIndex = 4;
        labelDisease.Text = "Хвороба:";
        // 
        // comboBoxDisease
        // 
        comboBoxDisease.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDisease.FormattingEnabled = true;
        comboBoxDisease.Location = new Point(188, 94);
        comboBoxDisease.Name = "comboBoxDisease";
        comboBoxDisease.Size = new Size(200, 23);
        comboBoxDisease.TabIndex = 5;
        // 
        // labelAdditionalMedications
        // 
        labelAdditionalMedications.AutoSize = true;
        labelAdditionalMedications.Location = new Point(20, 140);
        labelAdditionalMedications.Name = "labelAdditionalMedications";
        labelAdditionalMedications.Size = new Size(141, 15);
        labelAdditionalMedications.TabIndex = 6;
        labelAdditionalMedications.Text = "Додаткові медикаменти:";
        // 
        // listBoxAdditionalMedications
        // 
        listBoxAdditionalMedications.FormattingEnabled = true;
        listBoxAdditionalMedications.ItemHeight = 15;
        listBoxAdditionalMedications.Location = new Point(188, 137);
        listBoxAdditionalMedications.Name = "listBoxAdditionalMedications";
        listBoxAdditionalMedications.SelectionMode = SelectionMode.MultiExtended;
        listBoxAdditionalMedications.Size = new Size(200, 94);
        listBoxAdditionalMedications.TabIndex = 7;
        // 
        // labelDateOfIllness
        // 
        labelDateOfIllness.AutoSize = true;
        labelDateOfIllness.Location = new Point(20, 260);
        labelDateOfIllness.Name = "labelDateOfIllness";
        labelDateOfIllness.Size = new Size(117, 15);
        labelDateOfIllness.TabIndex = 8;
        labelDateOfIllness.Text = "Дата захворювання:";
        // 
        // dateTimePickerIllness
        // 
        dateTimePickerIllness.Format = DateTimePickerFormat.Short;
        dateTimePickerIllness.Location = new Point(188, 254);
        dateTimePickerIllness.Name = "dateTimePickerIllness";
        dateTimePickerIllness.Size = new Size(200, 23);
        dateTimePickerIllness.TabIndex = 9;
        // 
        // labelDateOfRecovery
        // 
        labelDateOfRecovery.AutoSize = true;
        labelDateOfRecovery.Location = new Point(20, 300);
        labelDateOfRecovery.Name = "labelDateOfRecovery";
        labelDateOfRecovery.Size = new Size(92, 15);
        labelDateOfRecovery.TabIndex = 10;
        labelDateOfRecovery.Text = "Дата одужання:";
        // 
        // dateTimePickerRecovery
        // 
        dateTimePickerRecovery.Format = DateTimePickerFormat.Short;
        dateTimePickerRecovery.Location = new Point(188, 294);
        dateTimePickerRecovery.Name = "dateTimePickerRecovery";
        dateTimePickerRecovery.Size = new Size(200, 23);
        dateTimePickerRecovery.TabIndex = 11;
        // 
        // labelDoctorName
        // 
        labelDoctorName.AutoSize = true;
        labelDoctorName.Location = new Point(20, 340);
        labelDoctorName.Name = "labelDoctorName";
        labelDoctorName.Size = new Size(69, 15);
        labelDoctorName.TabIndex = 12;
        labelDoctorName.Text = "Ім'я лікаря:";
        // 
        // textBoxDoctorName
        // 
        textBoxDoctorName.Location = new Point(188, 334);
        textBoxDoctorName.Name = "textBoxDoctorName";
        textBoxDoctorName.Size = new Size(200, 23);
        textBoxDoctorName.TabIndex = 13;
        // 
        // buttonSavePrescription
        // 
        buttonSavePrescription.Location = new Point(188, 377);
        buttonSavePrescription.Name = "buttonSavePrescription";
        buttonSavePrescription.Size = new Size(150, 30);
        buttonSavePrescription.TabIndex = 14;
        buttonSavePrescription.Text = "Зберегти виписку";
        buttonSavePrescription.UseVisualStyleBackColor = true;
        buttonSavePrescription.Click += ButtonSavePrescription_Click;
        // 
        // dataGridViewPrescriptions
        // 
        dataGridViewPrescriptions.AllowUserToAddRows = false;
        dataGridViewPrescriptions.AllowUserToDeleteRows = false;
        dataGridViewPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewPrescriptions.Dock = DockStyle.Fill;
        dataGridViewPrescriptions.Location = new Point(0, 0);
        dataGridViewPrescriptions.Name = "dataGridViewPrescriptions";
        dataGridViewPrescriptions.ReadOnly = true;
        dataGridViewPrescriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewPrescriptions.Size = new Size(846, 650);
        dataGridViewPrescriptions.TabIndex = 15;
        // 
        // PrescriptionView
        // 
        AutoScaleMode = AutoScaleMode.None;
        Controls.Add(splitContainerMain);
        Name = "PrescriptionView";
        Size = new Size(1250, 650);
        splitContainerMain.Panel1.ResumeLayout(false);
        splitContainerMain.Panel1.PerformLayout();
        splitContainerMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
        splitContainerMain.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewPrescriptions).EndInit();
        ResumeLayout(false);
    }
}