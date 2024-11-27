using PhysicianHandbook.Application.Models.Enums;
using PhysicianHandbook.Application.Models.Interfaces;

namespace PhysicianHandbook.Application.Models;

public class Disease : IIdentifiable
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Symptoms { get; set; }
    public string Procedures { get; set; }
    public Severity Severity { get; set; } = Severity.Легка;
    public List<MedicationDetail> Medications { get; set; }

    public Disease()
    {
        Medications = new List<MedicationDetail>();
    }
}