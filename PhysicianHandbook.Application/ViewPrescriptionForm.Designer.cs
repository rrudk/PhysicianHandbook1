namespace PhysicianHandbook.Application;

partial class ViewPrescriptionForm
{
    /// <summary>
    /// Обов'язкова змінна конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
    private System.Windows.Forms.Label labelPatientName;
    private System.Windows.Forms.Label labelPatientNameValue;
    private System.Windows.Forms.Label labelDisease;
    private System.Windows.Forms.Label labelDiseaseValue;
    private System.Windows.Forms.Label labelMedications;
    private System.Windows.Forms.ListBox listBoxMedications;
    private System.Windows.Forms.Label labelDateOfIllness;
    private System.Windows.Forms.Label labelDateOfIllnessValue;
    private System.Windows.Forms.Label labelDateOfRecovery;
    private System.Windows.Forms.Label labelDateOfRecoveryValue;
    private System.Windows.Forms.Label labelDoctorName;
    private System.Windows.Forms.Label labelDoctorNameValue;
    private System.Windows.Forms.Button buttonClose;

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
        labelPatientName = new Label();
        labelPatientNameValue = new Label();
        labelDisease = new Label();
        labelDiseaseValue = new Label();
        labelMedications = new Label();
        listBoxMedications = new ListBox();
        labelDateOfIllness = new Label();
        labelDateOfIllnessValue = new Label();
        labelDateOfRecovery = new Label();
        labelDateOfRecoveryValue = new Label();
        labelDoctorName = new Label();
        labelDoctorNameValue = new Label();
        buttonClose = new Button();
        tableLayoutPanelMain.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanelMain
        // 
        tableLayoutPanelMain.ColumnCount = 2;
        tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        tableLayoutPanelMain.Controls.Add(labelPatientName, 0, 0);
        tableLayoutPanelMain.Controls.Add(labelPatientNameValue, 1, 0);
        tableLayoutPanelMain.Controls.Add(labelDisease, 0, 1);
        tableLayoutPanelMain.Controls.Add(labelDiseaseValue, 1, 1);
        tableLayoutPanelMain.Controls.Add(labelMedications, 0, 2);
        tableLayoutPanelMain.Controls.Add(listBoxMedications, 1, 2);
        tableLayoutPanelMain.Controls.Add(labelDateOfIllness, 0, 3);
        tableLayoutPanelMain.Controls.Add(labelDateOfIllnessValue, 1, 3);
        tableLayoutPanelMain.Controls.Add(labelDateOfRecovery, 0, 4);
        tableLayoutPanelMain.Controls.Add(labelDateOfRecoveryValue, 1, 4);
        tableLayoutPanelMain.Controls.Add(labelDoctorName, 0, 5);
        tableLayoutPanelMain.Controls.Add(labelDoctorNameValue, 1, 5);
        tableLayoutPanelMain.Controls.Add(buttonClose, 1, 6);
        tableLayoutPanelMain.Dock = DockStyle.Fill;
        tableLayoutPanelMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        tableLayoutPanelMain.Location = new Point(0, 0);
        tableLayoutPanelMain.Name = "tableLayoutPanelMain";
        tableLayoutPanelMain.RowCount = 7;
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        tableLayoutPanelMain.Size = new Size(600, 650);
        tableLayoutPanelMain.TabIndex = 0;
        // 
        // labelPatientName
        // 
        labelPatientName.Anchor = AnchorStyles.Right;
        labelPatientName.AutoSize = true;
        labelPatientName.Location = new Point(111, 2);
        labelPatientName.Name = "labelPatientName";
        labelPatientName.Size = new Size(66, 20);
        labelPatientName.TabIndex = 0;
        labelPatientName.Text = "Пацієнт:";
        // 
        // labelPatientNameValue
        // 
        labelPatientNameValue.Anchor = AnchorStyles.Left;
        labelPatientNameValue.AutoSize = true;
        labelPatientNameValue.Location = new Point(183, 2);
        labelPatientNameValue.Name = "labelPatientNameValue";
        labelPatientNameValue.Size = new Size(35, 20);
        labelPatientNameValue.TabIndex = 1;
        labelPatientNameValue.Text = "Ім'я";
        // 
        // labelDisease
        // 
        labelDisease.Anchor = AnchorStyles.Right;
        labelDisease.AutoSize = true;
        labelDisease.Location = new Point(104, 27);
        labelDisease.Name = "labelDisease";
        labelDisease.Size = new Size(73, 20);
        labelDisease.TabIndex = 2;
        labelDisease.Text = "Хвороба:";
        // 
        // labelDiseaseValue
        // 
        labelDiseaseValue.Anchor = AnchorStyles.Left;
        labelDiseaseValue.AutoSize = true;
        labelDiseaseValue.Location = new Point(183, 27);
        labelDiseaseValue.Name = "labelDiseaseValue";
        labelDiseaseValue.Size = new Size(70, 20);
        labelDiseaseValue.TabIndex = 3;
        labelDiseaseValue.Text = "Хвороба";
        // 
        // labelMedications
        // 
        labelMedications.Anchor = AnchorStyles.Right;
        labelMedications.AutoSize = true;
        labelMedications.Location = new Point(69, 90);
        labelMedications.Name = "labelMedications";
        labelMedications.Size = new Size(108, 20);
        labelMedications.TabIndex = 4;
        labelMedications.Text = "Медикаменти:";
        // 
        // listBoxMedications
        // 
        listBoxMedications.Anchor = AnchorStyles.Left;
        listBoxMedications.FormattingEnabled = true;
        listBoxMedications.Location = new Point(183, 60);
        listBoxMedications.Name = "listBoxMedications";
        listBoxMedications.Size = new Size(400, 64);
        listBoxMedications.TabIndex = 5;
        // 
        // labelDateOfIllness
        // 
        labelDateOfIllness.Anchor = AnchorStyles.Right;
        labelDateOfIllness.AutoSize = true;
        labelDateOfIllness.Location = new Point(69, 152);
        labelDateOfIllness.Name = "labelDateOfIllness";
        labelDateOfIllness.Size = new Size(108, 20);
        labelDateOfIllness.TabIndex = 6;
        labelDateOfIllness.Text = "Дата хвороби:";
        // 
        // labelDateOfIllnessValue
        // 
        labelDateOfIllnessValue.Anchor = AnchorStyles.Left;
        labelDateOfIllnessValue.AutoSize = true;
        labelDateOfIllnessValue.Location = new Point(183, 152);
        labelDateOfIllnessValue.Name = "labelDateOfIllnessValue";
        labelDateOfIllnessValue.Size = new Size(105, 20);
        labelDateOfIllnessValue.TabIndex = 7;
        labelDateOfIllnessValue.Text = "Дата хвороби";
        // 
        // labelDateOfRecovery
        // 
        labelDateOfRecovery.Anchor = AnchorStyles.Right;
        labelDateOfRecovery.AutoSize = true;
        labelDateOfRecovery.Location = new Point(60, 177);
        labelDateOfRecovery.Name = "labelDateOfRecovery";
        labelDateOfRecovery.Size = new Size(117, 20);
        labelDateOfRecovery.TabIndex = 8;
        labelDateOfRecovery.Text = "Дата одужання:";
        // 
        // labelDateOfRecoveryValue
        // 
        labelDateOfRecoveryValue.Anchor = AnchorStyles.Left;
        labelDateOfRecoveryValue.AutoSize = true;
        labelDateOfRecoveryValue.Location = new Point(183, 177);
        labelDateOfRecoveryValue.Name = "labelDateOfRecoveryValue";
        labelDateOfRecoveryValue.Size = new Size(114, 20);
        labelDateOfRecoveryValue.TabIndex = 9;
        labelDateOfRecoveryValue.Text = "Дата одужання";
        // 
        // labelDoctorName
        // 
        labelDoctorName.Anchor = AnchorStyles.Right;
        labelDoctorName.AutoSize = true;
        labelDoctorName.Location = new Point(127, 202);
        labelDoctorName.Name = "labelDoctorName";
        labelDoctorName.Size = new Size(50, 20);
        labelDoctorName.TabIndex = 10;
        labelDoctorName.Text = "Лікар:";
        // 
        // labelDoctorNameValue
        // 
        labelDoctorNameValue.Anchor = AnchorStyles.Left;
        labelDoctorNameValue.AutoSize = true;
        labelDoctorNameValue.Location = new Point(183, 202);
        labelDoctorNameValue.Name = "labelDoctorNameValue";
        labelDoctorNameValue.Size = new Size(47, 20);
        labelDoctorNameValue.TabIndex = 11;
        labelDoctorNameValue.Text = "Лікар";
        // 
        // buttonClose
        // 
        buttonClose.Anchor = AnchorStyles.Right;
        buttonClose.Location = new Point(487, 422);
        buttonClose.Name = "buttonClose";
        buttonClose.Size = new Size(110, 30);
        buttonClose.TabIndex = 12;
        buttonClose.Text = "Закрити";
        buttonClose.UseVisualStyleBackColor = true;
        buttonClose.Click += ButtonClose_Click;
        // 
        // ViewPrescriptionForm
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(600, 650);
        Controls.Add(tableLayoutPanelMain);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "ViewPrescriptionForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Перегляд виписки";
        tableLayoutPanelMain.ResumeLayout(false);
        tableLayoutPanelMain.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private void ButtonClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}