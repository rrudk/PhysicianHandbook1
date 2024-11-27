using PhysicianHandbook.Application.Models.Enums;
using PhysicianHandbook.Application.Models;

namespace PhysicianHandbook.Application;

public partial class EditDiseaseForm : Form
{
    public Disease Disease { get; private set; }

    public EditDiseaseForm(Disease disease, List<Medication> allMedications)
    {
        InitializeComponent();

        Disease = new Disease
        {
            Id = disease.Id,
            Name = disease.Name,
            Symptoms = disease.Symptoms,
            Procedures = disease.Procedures,
            Severity = disease.Severity,
            Medications = new List<MedicationDetail>(disease.Medications)
        };
        PopulateFields(allMedications);
    }

    private void PopulateFields(List<Medication> allMedications)
    {
        textBoxName.Text = Disease.Name;
        textBoxSymptoms.Text = Disease.Symptoms;
        textBoxProcedures.Text = Disease.Procedures;
        comboBoxSeverity.DataSource = Enum.GetValues(typeof(Severity));
        comboBoxSeverity.SelectedItem = Disease.Severity;

        var availableMedications = allMedications.OrderBy(m => m.Name).ToList();
        checkedListBoxMedications.Items.Clear();
        foreach (var med in availableMedications)
        {
            var isChecked = Disease.Medications.Any(md => md.Medication.Id == med.Id);
            checkedListBoxMedications.Items.Add(med, isChecked);
        }
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        var name = textBoxName.Text.Trim();
        var symptoms = textBoxSymptoms.Text.Trim();
        var procedures = textBoxProcedures.Text.Trim();

        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("Назва хвороби не може бути порожньою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selectedMedications = checkedListBoxMedications.CheckedItems.Cast<Medication>().ToList();
        if (selectedMedications.Count == 0)
        {
            MessageBox.Show("Додайте хоча б один медикамент.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Disease.Name = name;
        Disease.Symptoms = symptoms;
        Disease.Procedures = procedures;

        // Обновляем список медикаментов
        Disease.Medications = selectedMedications.Select(med => new MedicationDetail
        {
            Medication = med,
            Quantity = 1,
            Unit = UnitType.Шт
        }).ToList();

        DialogResult = DialogResult.OK;
        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}