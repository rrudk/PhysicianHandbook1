using PhysicianHandbook.Application.Models;

namespace PhysicianHandbook.Application;

public partial class EditMedicationForm : Form
{
    public Medication Medication { get; }

    public EditMedicationForm(Medication medication, List<Medication> allMedications)
    {
        InitializeComponent();

        Medication = new Medication
        {
            Id = medication.Id,
            Name = medication.Name,
            Stock = medication.Stock,
            Price = medication.Price,
            Alternatives = new List<Medication>(medication.Alternatives)
        };
        PopulateFields(allMedications);
    }

    private void PopulateFields(List<Medication> allMedications)
    {
        textBoxName.Text = Medication.Name;
        numericUpDownAmount.Value = Medication.Stock;
        numericUpDownPrice.Value = (decimal)Medication.Price;

        var availableMedications = allMedications
            .Where(m => m.Id != Medication.Id)
            .OrderBy(m => m.Name)
            .ToList();

        checkedListBoxAlternatives.Items.Clear();
        foreach (var med in availableMedications)
        {
            var isChecked = Medication.Alternatives.Any(a => a.Id == med.Id);
            checkedListBoxAlternatives.Items.Add(med, isChecked);
        }
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        var name = textBoxName.Text.Trim();
        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("Назва медикаменту не може бути порожньою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var amount = (int)numericUpDownAmount.Value;
        var price = (float)numericUpDownPrice.Value;

        Medication.Name = name;
        Medication.Stock = amount;
        Medication.Price = price;
        Medication.Alternatives.Clear();

        foreach (var checkedItem in checkedListBoxAlternatives.CheckedItems)
        {
            if (checkedItem is Medication med)
            {
                Medication.Alternatives.Add(med);
            }
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}