using PhysicianHandbook.Application.Models;

namespace PhysicianHandbook.Application.Events;

public class PrescriptionEventArgs : EventArgs
{
    public Prescription Prescription { get; set; }
}