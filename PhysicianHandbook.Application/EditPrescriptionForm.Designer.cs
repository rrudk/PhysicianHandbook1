namespace PhysicianHandbook.Application;

partial class EditPrescriptionForm
{
    /// <summary>
    /// Обов'язкова змінна конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
    private System.Windows.Forms.Label labelPatientFirstName;
    private System.Windows.Forms.TextBox textBoxPatientFirstName;
    private System.Windows.Forms.Label labelPatientLastName;
    private System.Windows.Forms.TextBox textBoxPatientLastName;
    private System.Windows.Forms.Label labelDisease;
    private System.Windows.Forms.ComboBox comboBoxDisease;
    private System.Windows.Forms.Label labelAdditionalMedications;
    private System.Windows.Forms.ListBox listBoxAdditionalMedications;
    private System.Windows.Forms.Label labelDateOfIllness;
    private System.Windows.Forms.DateTimePicker dateTimePickerIllness;
    private System.Windows.Forms.Label labelDateOfRecovery;
    private System.Windows.Forms.DateTimePicker dateTimePickerRecovery;
    private System.Windows.Forms.Label labelDoctorName;
    private System.Windows.Forms.TextBox textBoxDoctorName;
    private System.Windows.Forms.Button buttonSaveEdit;
    private System.Windows.Forms.Button buttonCancelEdit;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }


    #region Код, створений конструктором форм Windows

    /// <summary>
    /// Обов'язковий метод для підтримки конструктора - не змінюйте
    /// вміст цього методу за допомогою редактора коду.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanelMain = new TableLayoutPanel();
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
        buttonSaveEdit = new Button();
        buttonCancelEdit = new Button();
        tableLayoutPanelMain.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanelMain
        // 
        tableLayoutPanelMain.ColumnCount = 2;
        tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        tableLayoutPanelMain.Controls.Add(labelPatientFirstName, 0, 0);
        tableLayoutPanelMain.Controls.Add(textBoxPatientFirstName, 1, 0);
        tableLayoutPanelMain.Controls.Add(labelPatientLastName, 0, 1);
        tableLayoutPanelMain.Controls.Add(textBoxPatientLastName, 1, 1);
        tableLayoutPanelMain.Controls.Add(labelDisease, 0, 2);
        tableLayoutPanelMain.Controls.Add(comboBoxDisease, 1, 2);
        tableLayoutPanelMain.Controls.Add(labelAdditionalMedications, 0, 3);
        tableLayoutPanelMain.Controls.Add(listBoxAdditionalMedications, 1, 3);
        tableLayoutPanelMain.Controls.Add(labelDateOfIllness, 0, 4);
        tableLayoutPanelMain.Controls.Add(dateTimePickerIllness, 1, 4);
        tableLayoutPanelMain.Controls.Add(labelDateOfRecovery, 0, 5);
        tableLayoutPanelMain.Controls.Add(dateTimePickerRecovery, 1, 5);
        tableLayoutPanelMain.Controls.Add(labelDoctorName, 0, 6);
        tableLayoutPanelMain.Controls.Add(textBoxDoctorName, 1, 6);
        tableLayoutPanelMain.Controls.Add(buttonSaveEdit, 1, 7);
        tableLayoutPanelMain.Controls.Add(buttonCancelEdit, 1, 8);
        tableLayoutPanelMain.Dock = DockStyle.Fill;
        tableLayoutPanelMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        tableLayoutPanelMain.Location = new Point(10, 10);
        tableLayoutPanelMain.Name = "tableLayoutPanelMain";
        tableLayoutPanelMain.RowCount = 9;
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        tableLayoutPanelMain.Size = new Size(580, 630);
        tableLayoutPanelMain.TabIndex = 0;
        // 
        // labelPatientFirstName
        // 
        labelPatientFirstName.Anchor = AnchorStyles.Right;
        labelPatientFirstName.AutoSize = true;
        labelPatientFirstName.Location = new Point(98, 2);
        labelPatientFirstName.Name = "labelPatientFirstName";
        labelPatientFirstName.Size = new Size(102, 20);
        labelPatientFirstName.TabIndex = 0;
        labelPatientFirstName.Text = "Ім'я пацієнта:";
        // 
        // textBoxPatientFirstName
        // 
        textBoxPatientFirstName.Anchor = AnchorStyles.Left;
        textBoxPatientFirstName.Location = new Point(206, 3);
        textBoxPatientFirstName.Name = "textBoxPatientFirstName";
        textBoxPatientFirstName.Size = new Size(371, 27);
        textBoxPatientFirstName.TabIndex = 1;
        // 
        // labelPatientLastName
        // 
        labelPatientLastName.Anchor = AnchorStyles.Right;
        labelPatientLastName.AutoSize = true;
        labelPatientLastName.Location = new Point(56, 27);
        labelPatientLastName.Name = "labelPatientLastName";
        labelPatientLastName.Size = new Size(144, 20);
        labelPatientLastName.TabIndex = 2;
        labelPatientLastName.Text = "Прізвище пацієнта:";
        // 
        // textBoxPatientLastName
        // 
        textBoxPatientLastName.Anchor = AnchorStyles.Left;
        textBoxPatientLastName.Location = new Point(206, 28);
        textBoxPatientLastName.Name = "textBoxPatientLastName";
        textBoxPatientLastName.Size = new Size(371, 27);
        textBoxPatientLastName.TabIndex = 3;
        // 
        // labelDisease
        // 
        labelDisease.Anchor = AnchorStyles.Right;
        labelDisease.AutoSize = true;
        labelDisease.Location = new Point(127, 52);
        labelDisease.Name = "labelDisease";
        labelDisease.Size = new Size(73, 20);
        labelDisease.TabIndex = 4;
        labelDisease.Text = "Хвороба:";
        // 
        // comboBoxDisease
        // 
        comboBoxDisease.Anchor = AnchorStyles.Left;
        comboBoxDisease.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDisease.FormattingEnabled = true;
        comboBoxDisease.Location = new Point(206, 53);
        comboBoxDisease.Name = "comboBoxDisease";
        comboBoxDisease.Size = new Size(371, 28);
        comboBoxDisease.TabIndex = 5;
        // 
        // labelAdditionalMedications
        // 
        labelAdditionalMedications.Anchor = AnchorStyles.Right;
        labelAdditionalMedications.AutoSize = true;
        labelAdditionalMedications.Location = new Point(21, 115);
        labelAdditionalMedications.Name = "labelAdditionalMedications";
        labelAdditionalMedications.Size = new Size(179, 20);
        labelAdditionalMedications.TabIndex = 6;
        labelAdditionalMedications.Text = "Додаткові медикаменти:";
        // 
        // listBoxAdditionalMedications
        // 
        listBoxAdditionalMedications.Anchor = AnchorStyles.Left;
        listBoxAdditionalMedications.FormattingEnabled = true;
        listBoxAdditionalMedications.Location = new Point(206, 93);
        listBoxAdditionalMedications.Name = "listBoxAdditionalMedications";
        listBoxAdditionalMedications.SelectionMode = SelectionMode.MultiExtended;
        listBoxAdditionalMedications.Size = new Size(371, 64);
        listBoxAdditionalMedications.TabIndex = 7;
        // 
        // labelDateOfIllness
        // 
        labelDateOfIllness.Anchor = AnchorStyles.Right;
        labelDateOfIllness.AutoSize = true;
        labelDateOfIllness.Location = new Point(92, 177);
        labelDateOfIllness.Name = "labelDateOfIllness";
        labelDateOfIllness.Size = new Size(108, 20);
        labelDateOfIllness.TabIndex = 8;
        labelDateOfIllness.Text = "Дата хвороби:";
        // 
        // dateTimePickerIllness
        // 
        dateTimePickerIllness.Anchor = AnchorStyles.Left;
        dateTimePickerIllness.Format = DateTimePickerFormat.Short;
        dateTimePickerIllness.Location = new Point(206, 178);
        dateTimePickerIllness.Name = "dateTimePickerIllness";
        dateTimePickerIllness.Size = new Size(371, 27);
        dateTimePickerIllness.TabIndex = 9;
        // 
        // labelDateOfRecovery
        // 
        labelDateOfRecovery.Anchor = AnchorStyles.Right;
        labelDateOfRecovery.AutoSize = true;
        labelDateOfRecovery.Location = new Point(83, 202);
        labelDateOfRecovery.Name = "labelDateOfRecovery";
        labelDateOfRecovery.Size = new Size(117, 20);
        labelDateOfRecovery.TabIndex = 10;
        labelDateOfRecovery.Text = "Дата одужання:";
        // 
        // dateTimePickerRecovery
        // 
        dateTimePickerRecovery.Anchor = AnchorStyles.Left;
        dateTimePickerRecovery.Format = DateTimePickerFormat.Short;
        dateTimePickerRecovery.Location = new Point(206, 203);
        dateTimePickerRecovery.Name = "dateTimePickerRecovery";
        dateTimePickerRecovery.Size = new Size(371, 27);
        dateTimePickerRecovery.TabIndex = 11;
        // 
        // labelDoctorName
        // 
        labelDoctorName.Anchor = AnchorStyles.Right;
        labelDoctorName.AutoSize = true;
        labelDoctorName.Location = new Point(150, 227);
        labelDoctorName.Name = "labelDoctorName";
        labelDoctorName.Size = new Size(50, 20);
        labelDoctorName.TabIndex = 12;
        labelDoctorName.Text = "Лікар:";
        // 
        // textBoxDoctorName
        // 
        textBoxDoctorName.Anchor = AnchorStyles.Left;
        textBoxDoctorName.Location = new Point(206, 228);
        textBoxDoctorName.Name = "textBoxDoctorName";
        textBoxDoctorName.Size = new Size(371, 27);
        textBoxDoctorName.TabIndex = 13;
        // 
        // buttonSaveEdit
        // 
        buttonSaveEdit.Anchor = AnchorStyles.Right;
        buttonSaveEdit.Location = new Point(477, 253);
        buttonSaveEdit.Name = "buttonSaveEdit";
        buttonSaveEdit.Size = new Size(100, 29);
        buttonSaveEdit.TabIndex = 14;
        buttonSaveEdit.Text = "Зберегти";
        buttonSaveEdit.UseVisualStyleBackColor = true;
        buttonSaveEdit.Click += buttonSaveEdit_Click;
        // 
        // buttonCancelEdit
        // 
        buttonCancelEdit.Anchor = AnchorStyles.Right;
        buttonCancelEdit.Location = new Point(477, 442);
        buttonCancelEdit.Name = "buttonCancelEdit";
        buttonCancelEdit.Size = new Size(100, 30);
        buttonCancelEdit.TabIndex = 15;
        buttonCancelEdit.Text = "Скасувати";
        buttonCancelEdit.UseVisualStyleBackColor = true;
        buttonCancelEdit.Click += buttonCancelEdit_Click;
        // 
        // EditPrescriptionForm
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(600, 650);
        Controls.Add(tableLayoutPanelMain);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "EditPrescriptionForm";
        Padding = new Padding(10);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Редагування виписки";
        tableLayoutPanelMain.ResumeLayout(false);
        tableLayoutPanelMain.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
}