using PhysicianHandbook.Application.Models;

namespace PhysicianHandbook.Application;

public partial class ViewPrescriptionForm : Form
{
    private Prescription _prescription;

    public ViewPrescriptionForm(Prescription prescription)
    {
        InitializeComponent();
        _prescription = prescription;
        PopulateFields();
    }

    private void PopulateFields()
    {
        // Заповнення інформації про пацієнта
        labelPatientNameValue.Text = $"{_prescription.PatientFirstName} {_prescription.PatientLastName}";

        // Заповнення інформації про хворобу
        labelDiseaseValue.Text = _prescription.Disease.Name;

        // Заповнення медикаментів
        foreach (var medDetail in _prescription.AdditionalRecommendations)
        {
            var listItem = $"Медикамент: {medDetail.Medication.Name}, Кількість: {medDetail.Quantity} {medDetail.Unit}";
            listBoxMedications.Items.Add(listItem);
        }

        // Заповнення дат
        labelDateOfIllnessValue.Text = _prescription.DateOfIllness.ToShortDateString();
        labelDateOfRecoveryValue.Text = _prescription.DateOfRecovery.ToShortDateString();

        // Заповнення інформації про лікаря
        labelDoctorNameValue.Text = _prescription.DoctorName;
    }
}