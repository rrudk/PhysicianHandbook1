using PhysicianHandbook.Application.Events;
using PhysicianHandbook.Application.Models;
using PhysicianHandbook.Application.Services.Interfaces;
using PhysicianHandbook.Application.Views.Interfaces;

namespace PhysicianHandbook.Application.Presenters;

public class PrescriptionPresenter : BasePresenter<IPrescriptionView, Prescription>
{
    public PrescriptionPresenter(IPrescriptionView view, IDataService dataService)
        : base(view, dataService)
    {
    }

    protected override void Initialize()
    {
        _view.AddPrescriptionRequested += OnAddPrescriptionRequested;
        _view.EditPrescriptionRequested += OnEditPrescriptionRequested;
        _view.DeletePrescriptionRequested += OnDeletePrescriptionRequested;

        LoadModelsAsync();
    }

    protected override async Task<List<Prescription>> GetModelsAsync()
    {
        return await _dataService.GetPrescriptionsAsync();
    }

    protected override async Task SaveModelsAsync(List<Prescription> models)
    {
        await _dataService.SavePrescriptionsAsync(models);
    }

    protected override void SetModelsInView(List<Prescription> models)
    {
        _view.SetPrescriptions(models);
    }

    private async void OnAddPrescriptionRequested(object sender, PrescriptionEventArgs e)
    {
        e.Prescription.Id = Guid.NewGuid();
        await AddModelAsync(e.Prescription);
    }

    private async void OnEditPrescriptionRequested(object sender, PrescriptionEventArgs e)
    {
        await UpdateModelAsync(e.Prescription);
    }

    private async void OnDeletePrescriptionRequested(object sender, Guid id)
    {
        await DeleteModelAsync(id);
    }
}