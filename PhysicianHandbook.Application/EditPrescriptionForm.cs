using PhysicianHandbook.Application.Models;

namespace PhysicianHandbook.Application;

public partial class EditPrescriptionForm : Form
{
    private Prescription _originalPrescription;
    private List<Disease> _allDiseases;
    private List<Medication> _allMedications;

    public Prescription EditedPrescription { get; private set; }

    public EditPrescriptionForm(Prescription prescription, List<Disease> allDiseases, List<Medication> allMedications)
    {
        InitializeComponent();
        _originalPrescription = prescription;
        _allDiseases = allDiseases;
        _allMedications = allMedications;
        PopulateFields();
    }

    private void PopulateFields()
    {
        textBoxPatientFirstName.Text = _originalPrescription.PatientFirstName;
        textBoxPatientLastName.Text = _originalPrescription.PatientLastName;
        textBoxDoctorName.Text = _originalPrescription.DoctorName;

        comboBoxDisease.DataSource = _allDiseases;
        comboBoxDisease.DisplayMember = "Name";
        comboBoxDisease.ValueMember = "Id";
        comboBoxDisease.SelectedItem = _allDiseases.FirstOrDefault(d => d.Id == _originalPrescription.Disease.Id);

        listBoxAdditionalMedications.DataSource = _allMedications;
        listBoxAdditionalMedications.DisplayMember = "Name";
        listBoxAdditionalMedications.ValueMember = "Id";

        foreach (var med in _allMedications)
        {
            if (_originalPrescription.AdditionalRecommendations.Any(m => m.Medication.Id == med.Id))
            {
                listBoxAdditionalMedications.SetSelected(_allMedications.IndexOf(med), true);
            }
        }

        dateTimePickerIllness.Value = _originalPrescription.DateOfIllness;
        dateTimePickerRecovery.Value = _originalPrescription.DateOfRecovery;
    }

    private async void buttonSaveEdit_Click(object sender, EventArgs e)
    {
        // Валідація введених даних
        if (string.IsNullOrWhiteSpace(textBoxPatientFirstName.Text) ||
            string.IsNullOrWhiteSpace(textBoxPatientLastName.Text) ||
            comboBoxDisease.SelectedItem == null ||
            listBoxAdditionalMedications.SelectedItems.Count == 0 ||
            string.IsNullOrWhiteSpace(textBoxDoctorName.Text))
        {
            MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var patientFirstName = textBoxPatientFirstName.Text.Trim();
        var patientLastName = textBoxPatientLastName.Text.Trim();
        var selectedDisease = comboBoxDisease.SelectedItem as Disease;
        var selectedMedications = listBoxAdditionalMedications.SelectedItems.Cast<Medication>().ToList();
        var dateOfIllness = dateTimePickerIllness.Value.Date;
        var dateOfRecovery = dateTimePickerRecovery.Value.Date;
        var doctorName = textBoxDoctorName.Text.Trim();

        if (dateOfRecovery < dateOfIllness)
        {
            MessageBox.Show("Дата одужання не може бути раніше дати захворювання.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var editedPrescription = new Prescription
        {
            Id = _originalPrescription.Id,
            PatientFirstName = patientFirstName,
            PatientLastName = patientLastName,
            Disease = selectedDisease,
            AdditionalRecommendations = selectedMedications.Select(m => new MedicationDetail
            {
                Medication = m,
                Quantity = 1
            }).ToList(),
            DateOfIllness = dateOfIllness,
            DateOfRecovery = dateOfRecovery,
            DoctorName = doctorName
        };

        EditedPrescription = editedPrescription;

        DialogResult = DialogResult.OK;
        Close();
    }

    private void buttonCancelEdit_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}