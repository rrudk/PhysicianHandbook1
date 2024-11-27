using PhysicianHandbook.Application.Events;
using PhysicianHandbook.Application.Models;

namespace PhysicianHandbook.Application.Views.Interfaces;

public interface IPrescriptionView
{
    event EventHandler<PrescriptionEventArgs> AddPrescriptionRequested;
    event EventHandler<PrescriptionEventArgs> EditPrescriptionRequested;
    event EventHandler<Guid> DeletePrescriptionRequested;

    void SetPrescriptions(List<Prescription> prescriptions);
    void ClearInputFields();
}