using PhysicianHandbook.Application.Models.Interfaces;

namespace PhysicianHandbook.Application.Models;

public class Medication : IIdentifiable
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }
    public string MedicationPrice => $"{Price:C2}";
    public string MedicationAmount => $"{Stock} шт.";
    public string MedicationTotal => $"{Stock * Price:C2}";
    public List<Medication> Alternatives { get; set; }
    public string AlternativesSummary => string.Join(", ", Alternatives.Select(a => a.Name));

    public Medication()
    {
        Alternatives = new List<Medication>();
    }

    public override string ToString()
    {
        return Name;
    }
}