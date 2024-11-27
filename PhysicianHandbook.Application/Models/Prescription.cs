using PhysicianHandbook.Application.Models.Interfaces;

namespace PhysicianHandbook.Application.Models;

public class Prescription : IIdentifiable
{
    public Guid Id { get; set; }
    public string PatientFirstName { get; set; }
    public string PatientLastName { get; set; }
    public Disease Disease { get; set; }
    public List<MedicationDetail> AdditionalRecommendations { get; set; }
    public DateTime DateOfIllness { get; set; }
    public DateTime DateOfRecovery { get; set; }
    public string DoctorName { get; set; }
    public string PatientFullName => $"{PatientFirstName} {PatientLastName}";
    public string DiseaseName => Disease.Name;

    public Prescription()
    {
        AdditionalRecommendations = new List<MedicationDetail>();
    }
}